using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace TwoProblems
{
    public class Model
    {
        private readonly string _pathToRulesDirectory;
        private string _selectedRulesPath;
        public List<string> Files { get; set; }
        public string FileNamePartMatch { get; set; }
        public string FileNamePartReplace { get; set; }
        public List<RuleChoice> RulesFileChoices { get; set; }

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

        public Model(string pathToRulesDirectory)
        {
            _pathToRulesDirectory = pathToRulesDirectory;
            Files = new List<string>();
            RulesFileChoices = new List<RuleChoice>();

            foreach(var f in Directory.GetFiles(pathToRulesDirectory, "*.txt"))
            {
                var lines = File.ReadAllLines(f);
                if(lines.Length > 0 && lines[0].Length>0 && lines[0].ToCharArray()[0]=='#')
                {
                    RulesFileChoices.Add(new RuleChoice(f));
                }
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


}
