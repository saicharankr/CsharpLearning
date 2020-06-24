using System;
using System.Text.RegularExpressions;

namespace CsharpLearning
{
    public class RegexUnderstanding
    {
        public void Regex1()
        {
            string input = "Hello   World   ";

            /*where \s matches any whitespace character.
             "+" is A Quantifier Matches the previous element one or more times,
             i.e here Matches White spaces element one or more times.*/

            string pattern = @"\s+";
            string replacement = " ";

            //TODO: How to capture Groups
            //TODO: LookAround Operators - Done
            //TODO: how use MatchCollections - Done
            //TODO: How to use Regex.Replace
            //TODO: Greedy V/s Lazy capture - Done
            //TODO: Capture Group BackRef

            Regex rgx = new Regex(pattern);
            string result = rgx.Replace(input, replacement);

            Console.WriteLine("Original String: {0}", input);
            Console.WriteLine("Replacement String: {0}", result);
            Console.ReadKey();
        }

        public void GreedyRegex()
        {
            string input = "he is 'superman' with 'superpowers'";

            string Expression = @"'.+'";

            Regex rgx = new Regex(Expression);
            MatchCollection mc = rgx.Matches(input);

            foreach (Match m in mc)
            {
                Console.WriteLine(m);
            }
        }

        public void LazyRegex()
        {
            string input = "he is 'superman' with 'superpowers'";

            string Expression = @"'.+?'";

            Regex rgx = new Regex(Expression);
            MatchCollection mc = rgx.Matches(input);

            foreach (Match m in mc)
            {
                Console.WriteLine("This from Lazy regex");
                Console.WriteLine(m);
            }
        }

        public void LookAround()
        {
            string input1 = "2kg of Tomato costs $4 so 1kg is $2 in Euros 1kg of Tomato costs 5€";

            Console.WriteLine("1. Lookbehind");
            Console.WriteLine("2. NegativeLookAheard");
            Console.WriteLine("3. LookAheard");

            int regexpressionChoice = Int32.Parse(Console.ReadLine());

            switch (regexpressionChoice)
            {
                case 1:
                    string lookbehind = @$"(?<={Regex.Escape("$")})\d+";
                    Regex rgx = new Regex(lookbehind);
                    MatchCollection mc = rgx.Matches(input1);
                    foreach (Match m in mc)
                    {
                        Console.WriteLine("This from Lookbehind regex");
                        Console.WriteLine(m);
                    }
                    break;

                case 2:
                    string negativeLookAheard = @"\d+(?!€)(?!kg)";
                    Regex rgx1 = new Regex(negativeLookAheard);
                    MatchCollection mc1 = rgx1.Matches(input1);
                    foreach (Match m in mc1)
                    {
                        Console.WriteLine("This from NegativeLookAheard regex");
                        Console.WriteLine(m);
                    }
                    break;

                case 3:
                    string lookAheard = @"\d+(?=€)";
                    Regex rgx2 = new Regex(lookAheard);
                    MatchCollection mc2 = rgx2.Matches(input1);
                    foreach (Match m in mc2)
                    {
                        Console.WriteLine("This from LookAround regex");
                        Console.WriteLine(m);
                    }
                    break;

                default:
                    break;
            }
        }
    }
}