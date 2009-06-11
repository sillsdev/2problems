using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using TwoProblems.Properties;

namespace TwoProblems
{
    public partial class View : Form
    {
        private readonly Controller _controller;



        public View(Controller controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(
                "Some people, when confronted with a problem, think 'I know, I'll use regular expressions.' Now they have two problems.  --Jamie Zawinski\r\n\r\n2P is brought to you (for better or worse) by John Hatton of SIL PNG.");
        }

        private void View_Load(object sender, System.EventArgs e)
        {
            this._rulesFilesCombo.SelectedIndexChanged += new System.EventHandler(this._rulesFilesCombo_SelectedIndexChanged);

            _rulesFilesCombo.Items.Clear();
            foreach (var ruleSet in _controller.RulesFileChoices)
            {
                _rulesFilesCombo.Items.Add(ruleSet);
            }

            foreach (RuleChoice item in _rulesFilesCombo.Items)
            {
                if(item.RulePath==Settings.Default.RuleSet )
                {
                    _rulesFilesCombo.SelectedItem = item;
                    break;
                }
            }
            if (_rulesFilesCombo.SelectedIndex <0 && _rulesFilesCombo.Items.Count > 0)
            {
                _rulesFilesCombo.SelectedIndex = 0;
            }

            UpdateDisplay();
        }



        private void _processAllButton_Click(object sender, EventArgs e)
        {
            try
            {
                _statusLabel.Text = "Processing";
                _controller.ProcessFiles();
                UpdateProcessedFiles();
                _statusLabel.Text = "Done";
                
                tabControl1.SelectTab(_resultsTab);

                if(_resultsList.Items.Count>0)
                {
                    if (_resultsList.SelectedItems.Count > 0)
                    {
                        _resultsList.SelectedItems[0].Selected = false;
                        _resultsList.SelectedItems[0].Selected = true;
                    }
                    else
                    {
                        _resultsList.Items[0].Selected = false;
                        _resultsList.Items[0].Selected = true;
                    }
                }
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void UpdateProcessedFiles()
        {
            _resultsList.Items.Clear();
            foreach (var path in _controller.ProcessedFiles)
            {
                var item = new ListViewItem(Path.GetFileName(path));
                item.Tag = path;
                _resultsList.Items.Add(item);
            }
        }

        private void _selectFilesLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var dlg = new OpenFileDialog();
            dlg.Multiselect = true;
            dlg.Title = "Choose Files...";
            if (Directory.Exists(dlg.InitialDirectory = Settings.Default.InputDirectory))
            {
                dlg.InitialDirectory = Settings.Default.InputDirectory;
            }


            if(System.Windows.Forms.DialogResult.OK != dlg.ShowDialog())
            {
                return;
            }

            Settings.Default.InputDirectory = dlg.InitialDirectory;

            _controller.SourceFilePaths.Clear();
            _controller.SourceFilePaths.AddRange(dlg.FileNames);
            var builder = new StringBuilder();
            foreach (var fileName in dlg.FileNames)
            {
                builder.Append(fileName + ", ");
            }
            Settings.Default.FilesToProcess = builder.ToString();
            Settings.Default.Save();
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            _sourceFilesList.Items.Clear();
            foreach (var file in _controller.SourceFilePaths)
            {
                _sourceFilesList.Items.Add(Path.GetFileName(file));
            }

            _processAllButton.Enabled = _controller.SourceFilePaths.Count > 0 && _rulesFilesCombo.SelectedIndex > -1;
        }

        private void _rulesFilesCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            _controller.SelectedRulesPath = ((RuleChoice) _rulesFilesCombo.SelectedItem).RulePath;
            Settings.Default.RuleSet = _controller.SelectedRulesPath;
            Settings.Default.Save();
        }

        private void _resultsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (_resultsList.SelectedItems.Count == 0)
                    return;
                string path = (string) _resultsList.SelectedItems[0].Tag;
                _resultText.Text = File.ReadAllText(path);

                _browser.Navigate(path);
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

    }
}