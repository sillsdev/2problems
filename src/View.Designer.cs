namespace TwoProblems
{
    partial class View
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this._resultsList = new System.Windows.Forms.ListView();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.browserTab = new System.Windows.Forms.TabPage();
            this._browser = new System.Windows.Forms.WebBrowser();
            this.textTab = new System.Windows.Forms.TabPage();
            this._resultText = new System.Windows.Forms.TextBox();
            this._resultsTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this._rulesFilesCombo = new System.Windows.Forms.ComboBox();
            this._sourceFilesList = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this._selectFilesLink = new System.Windows.Forms.LinkLabel();
            this._processAllButton = new System.Windows.Forms.Button();
            this._statusLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.browserTab.SuspendLayout();
            this.textTab.SuspendLayout();
            this._resultsTab.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkLabel2
            // 
            this.linkLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(481, 9);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(44, 13);
            this.linkLabel2.TabIndex = 7;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "About...";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabControl2);
            this.tabPage2.Controls.Add(this._resultsList);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(509, 354);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Results";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // _resultsList
            // 
            this._resultsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this._resultsList.HideSelection = false;
            this._resultsList.Location = new System.Drawing.Point(6, 6);
            this._resultsList.MultiSelect = false;
            this._resultsList.Name = "_resultsList";
            this._resultsList.Size = new System.Drawing.Size(134, 339);
            this._resultsList.TabIndex = 9;
            this._resultsList.UseCompatibleStateImageBehavior = false;
            this._resultsList.View = System.Windows.Forms.View.List;
            this._resultsList.SelectedIndexChanged += new System.EventHandler(this._resultsList_SelectedIndexChanged);
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.textTab);
            this.tabControl2.Controls.Add(this.browserTab);
            this.tabControl2.Location = new System.Drawing.Point(146, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(357, 342);
            this.tabControl2.TabIndex = 10;
            // 
            // browserTab
            // 
            this.browserTab.Controls.Add(this._browser);
            this.browserTab.Location = new System.Drawing.Point(4, 22);
            this.browserTab.Name = "browserTab";
            this.browserTab.Padding = new System.Windows.Forms.Padding(3);
            this.browserTab.Size = new System.Drawing.Size(349, 316);
            this.browserTab.TabIndex = 1;
            this.browserTab.Text = "Browser";
            this.browserTab.UseVisualStyleBackColor = true;
            // 
            // _browser
            // 
            this._browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this._browser.Location = new System.Drawing.Point(3, 3);
            this._browser.MinimumSize = new System.Drawing.Size(20, 20);
            this._browser.Name = "_browser";
            this._browser.Size = new System.Drawing.Size(343, 310);
            this._browser.TabIndex = 0;
            // 
            // textTab
            // 
            this.textTab.Controls.Add(this._resultText);
            this.textTab.Location = new System.Drawing.Point(4, 22);
            this.textTab.Name = "textTab";
            this.textTab.Padding = new System.Windows.Forms.Padding(3);
            this.textTab.Size = new System.Drawing.Size(349, 316);
            this.textTab.TabIndex = 0;
            this.textTab.Text = "Text";
            this.textTab.UseVisualStyleBackColor = true;
            // 
            // _resultText
            // 
            this._resultText.Dock = System.Windows.Forms.DockStyle.Fill;
            this._resultText.Font = new System.Drawing.Font("Doulos SIL", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._resultText.Location = new System.Drawing.Point(3, 3);
            this._resultText.Multiline = true;
            this._resultText.Name = "_resultText";
            this._resultText.ReadOnly = true;
            this._resultText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this._resultText.Size = new System.Drawing.Size(343, 310);
            this._resultText.TabIndex = 0;
            // 
            // _resultsTab
            // 
            this._resultsTab.Controls.Add(this._statusLabel);
            this._resultsTab.Controls.Add(this._processAllButton);
            this._resultsTab.Controls.Add(this._selectFilesLink);
            this._resultsTab.Controls.Add(this.label2);
            this._resultsTab.Controls.Add(this._sourceFilesList);
            this._resultsTab.Controls.Add(this._rulesFilesCombo);
            this._resultsTab.Controls.Add(this.label1);
            this._resultsTab.Location = new System.Drawing.Point(4, 22);
            this._resultsTab.Name = "_resultsTab";
            this._resultsTab.Padding = new System.Windows.Forms.Padding(3);
            this._resultsTab.Size = new System.Drawing.Size(509, 354);
            this._resultsTab.TabIndex = 0;
            this._resultsTab.Text = "Process";
            this._resultsTab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Rules File";
            // 
            // _rulesFilesCombo
            // 
            this._rulesFilesCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._rulesFilesCombo.FormattingEnabled = true;
            this._rulesFilesCombo.Items.AddRange(new object[] {
            "pt7InterlinearToGlossOnly.txt"});
            this._rulesFilesCombo.Location = new System.Drawing.Point(74, 11);
            this._rulesFilesCombo.Name = "_rulesFilesCombo";
            this._rulesFilesCombo.Size = new System.Drawing.Size(393, 21);
            this._rulesFilesCombo.TabIndex = 7;
            // 
            // _sourceFilesList
            // 
            this._sourceFilesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._sourceFilesList.Location = new System.Drawing.Point(74, 77);
            this._sourceFilesList.Name = "_sourceFilesList";
            this._sourceFilesList.Size = new System.Drawing.Size(393, 227);
            this._sourceFilesList.TabIndex = 8;
            this._sourceFilesList.UseCompatibleStateImageBehavior = false;
            this._sourceFilesList.View = System.Windows.Forms.View.List;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Files to Process";
            // 
            // _selectFilesLink
            // 
            this._selectFilesLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._selectFilesLink.AutoSize = true;
            this._selectFilesLink.Location = new System.Drawing.Point(391, 50);
            this._selectFilesLink.Name = "_selectFilesLink";
            this._selectFilesLink.Size = new System.Drawing.Size(76, 13);
            this._selectFilesLink.TabIndex = 10;
            this._selectFilesLink.TabStop = true;
            this._selectFilesLink.Text = "Choose Files...";
            this._selectFilesLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._selectFilesLink_LinkClicked);
            // 
            // _processAllButton
            // 
            this._processAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._processAllButton.Location = new System.Drawing.Point(392, 325);
            this._processAllButton.Name = "_processAllButton";
            this._processAllButton.Size = new System.Drawing.Size(75, 23);
            this._processAllButton.TabIndex = 11;
            this._processAllButton.Text = "Process All";
            this._processAllButton.UseVisualStyleBackColor = true;
            this._processAllButton.Click += new System.EventHandler(this._processAllButton_Click);
            // 
            // _statusLabel
            // 
            this._statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._statusLabel.AutoSize = true;
            this._statusLabel.Location = new System.Drawing.Point(74, 325);
            this._statusLabel.Name = "_statusLabel";
            this._statusLabel.Size = new System.Drawing.Size(24, 13);
            this._statusLabel.TabIndex = 12;
            this._statusLabel.Text = "Idle";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this._resultsTab);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 9);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(517, 380);
            this.tabControl1.TabIndex = 6;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 401);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.tabControl1);
            this.Name = "View";
            this.Text = "2Problems";
            this.Load += new System.EventHandler(this.View_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.browserTab.ResumeLayout(false);
            this.textTab.ResumeLayout(false);
            this.textTab.PerformLayout();
            this._resultsTab.ResumeLayout(false);
            this._resultsTab.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage textTab;
        private System.Windows.Forms.TextBox _resultText;
        private System.Windows.Forms.TabPage browserTab;
        private System.Windows.Forms.WebBrowser _browser;
        private System.Windows.Forms.ListView _resultsList;
        private System.Windows.Forms.TabPage _resultsTab;
        private System.Windows.Forms.Label _statusLabel;
        private System.Windows.Forms.Button _processAllButton;
        private System.Windows.Forms.LinkLabel _selectFilesLink;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView _sourceFilesList;
        private System.Windows.Forms.ComboBox _rulesFilesCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;

    }
}