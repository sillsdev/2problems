using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace TwoProblems
{
    public class RegexFileProcessor
    {
        private readonly string _rules;

        public RegexFileProcessor(string rules)
        {
            _rules = rules;
        }

        public void ProcessFile(string inputPath, string outputPath)
        {
            var text = File.ReadAllText(inputPath);
            var rules = _rules.Split(new char[] { Environment.NewLine[0] });
            foreach (var unTrimmedRule in rules)
            {
                var rule = unTrimmedRule.Trim();
                if (rule == string.Empty)
                    continue;
                if (rule.StartsWith("#"))//comment
                    continue;
                var fromTo = rule.Split(new char[] { '\t' });
                var from = new System.Text.RegularExpressions.Regex(fromTo[0], RegexOptions.IgnoreCase | RegexOptions.Multiline);//| RegexOptions.IgnorePatternWhitespace
                string to = string.Empty;
                if (fromTo.Length > 1)
                    to = fromTo[1].Replace("\\n", Environment.NewLine).Replace(@"\s", " ");
                // var to = new System.Text.RegularExpressions.Regex(regexs[1]);

                new RegexOptions();
                string oldText;
                var doRepeat = fromTo.Length > 2 && fromTo[2].Contains("REPEAT");
                var doCapitalization = fromTo.Length == 2 && fromTo[1].Contains("SentenceCap");
                do
                {
                    oldText = text;
                    if (doCapitalization)
                    {
                        text = from.Replace(text, ApplySentenceCapitalization);
                    }
                    else
                    {
                        text = from.Replace(text, to);
                    }
                } while (doRepeat && text != oldText);

            }

            File.WriteAllText(outputPath, text);
        }
        enum States { normal, needSpace, capNext }
        static string ApplySentenceCapitalization(Match m)
        {

            string x = m.ToString();
            States state = States.normal;
            var builder = new StringBuilder();

            foreach (var c in x.ToCharArray())
            {
                if (state == States.capNext && char.IsLower(c))
                {
                    builder.Append(char.ToUpper(c));
                    state = States.normal;
                }
                else if (c == '.' || c == '?' || c == '!')
                {
                    state = States.needSpace;
                    builder.Append(c);
                }
                else if (c == '>')
                {
                    state = States.capNext;
                    builder.Append(c);
                }
                else if (state == States.needSpace && c == ' ') //don't stuff like.this
                {
                    state = States.capNext;
                    builder.Append(c);
                }
                else if (state == States.capNext && c == ' ') //don't stuff like.this
                {
                    builder.Append(c);
                }
                else
                {
                    state = States.normal;
                    builder.Append(c);
                }
            }
            return builder.ToString();
        }
    }
}
