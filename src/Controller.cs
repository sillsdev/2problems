using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using TwoProblems.Properties;

namespace TwoProblems
{
    public class Controller
    {
        public List<string> ProcessedFiles { get; set; }
        private readonly string _pathToRulesDirectory;
        private string _selectedRulesPath;
        public List<string> SourceFilePaths { get; set; }
        public string FileNamePartMatch { get; set; }
        public string FileNamePartReplace { get; set; }
        public List<RuleChoice> RulesFileChoices { get; set; }

        public Controller(string pathToRulesDirectory)
        {

            _pathToRulesDirectory = pathToRulesDirectory;
        }

        public void Run()
        {

            SourceFilePaths = new List<string>();
            RulesFileChoices = new List<RuleChoice>();

            foreach (var f in Directory.GetFiles(_pathToRulesDirectory, "*.txt"))
            {
                var lines = File.ReadAllLines(f);
                if (lines.Length > 0 && lines[0].Length > 0 && lines[0].ToCharArray()[0] == '#')
                {
                    RulesFileChoices.Add(new RuleChoice(f));
                }
            }

            ProcessedFiles = new List<string>();

            foreach (var s in Settings.Default.FilesToProcess.Split(new[] { ',' }))
            {
                if (s.Trim().Length > 0)
                {
                    SourceFilePaths.Add(s);
                }
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new View(this));

            Settings.Default.Save();
        }

        public void ProcessFiles()
        {
            ProcessedFiles.Clear();
            Cursor.Current = Cursors.WaitCursor;
            var processor = new RegexFileProcessor(RulesContents);
            ReadFileNamingRules();
            foreach (var path in SourceFilePaths)
            {
                var outputPath = path.Replace(FileNamePartMatch, FileNamePartReplace);
                processor.ProcessFile(path, outputPath);
                ProcessedFiles.Add(outputPath);
            }

            Cursor.Current = Cursors.Default;
        }

        private void ReadFileNamingRules()
        {
            foreach (string line in RulesContents.Split(new char[]{'\n'}))
            {
                if(line.StartsWith("FileRename"))
                {
                    var parts = line.Split(new char[] {'\t', ' '}, StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length != 3)
                    {
                        MessageBox.Show("Expected FileName fileNamePartToMatch fileNamePartToReplace");
                        return;
                    }
                    FileNamePartMatch = parts[1].Trim();
                    FileNamePartReplace = parts[2].Trim();
                    return;
                }
            }
        }


        public string SelectedRulesPath
        {
            get
            {
                return _selectedRulesPath;
            }
            set
            {
                _selectedRulesPath = value;
                //enhance: read these out of the rules file
                FileNamePartMatch = ".";
                FileNamePartReplace = "-2p.";
            }
        }


        public string RulesContents
        {
            get
            {
                return File.ReadAllText(SelectedRulesPath);
            }

        }


    }

    public class RuleChoice
    {
        public RuleChoice(string rulePath)
        {
            RulePath = rulePath;
        }

        public string RulePath { get; set; }

        public override string ToString()
        {
            return Path.GetFileNameWithoutExtension(RulePath);
        }
    }
}


