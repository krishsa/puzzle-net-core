using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace puzzle_net_core
{
    public partial class PartialClass
    {
        private string pattern = @"(^|\n)(?<optionName>[a-z0-9- ]+)=(?<value>[^\r]+)";

        public Dictionary<string, string> GetOptionDictionary(string optionText)
        {
            Console.WriteLine("Starts");
            Dictionary<string, string> options = new Dictionary<string, string>();
            var match = Regex.Match(optionText, pattern);
            Console.WriteLine("match :" + match.Groups.Keys.ToList().ToString());

            Console.WriteLine("Group1:" + match.Groups["optionName"]);
            Console.WriteLine("Group2:" + match.Groups["value"]);
            Console.WriteLine("Group1:" + match.Groups["optionName"]);
            Console.WriteLine("Group2:" + match.Groups["value"]);
            options.Add(match.Groups["optionName"].ToString(), match.Groups["value"].ToString());


            return options;
        }

        public void TestGetOptionDictionary()
        {
            GetOptionDictionary("name=senthil\rage=spsa\rphone=kadai\r");
        }
    }
}
