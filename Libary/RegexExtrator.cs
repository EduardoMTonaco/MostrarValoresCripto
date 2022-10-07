using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Libary
{
    public class RegexExtrator : IRegexExtrator
    {
        private string RegExpression { get; set; }

        private string FirstExpression { get; set; }

        private string EndExpression { get; set; }

        private string FullExpression { get; set; }

        private string Empty => "";

        public RegexExtrator(string regExpression, string firstExpression, string endExpression)
        {
            RegExpression = regExpression;
            FirstExpression = firstExpression;
            EndExpression = endExpression;
            FullExpression = FirstExpression + RegExpression + EndExpression;
        }

        public RegexExtrator(string regExpression, string firstExpression)
        {
            RegExpression = regExpression;
            FirstExpression = firstExpression;
            EndExpression = Empty;
            FullExpression = FirstExpression + RegExpression;
        }

        public RegexExtrator(string regExpression)
        {
            RegExpression = regExpression;
            FirstExpression = Empty;
            EndExpression = Empty;
            FullExpression = FirstExpression;
        }

        public string GetRegex(string text)
        {
            try
            {
                return new Regex(FullExpression).Match(text).ToString().Replace(FirstExpression, Empty)
                    .Replace(EndExpression, Empty)
                    .ToString();
            }
            catch (ArgumentException ex)
            {
                throw new Exception("Expression not found, Error: " + ex.Message);
            }
        }
    }
}
