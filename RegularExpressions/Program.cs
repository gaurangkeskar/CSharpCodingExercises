﻿using System.Text.RegularExpressions;

namespace ExtractingEmailAddress
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExtractPatterns("Contact us at support@example.com or sales@example.org.");
            Console.ReadKey();
        }
        public static void ExtractPatterns(string input)
        {
            // Define the regex pattern for matching email addresses
            string pattern = @"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}\b";

            // Find all matches of the regex pattern in the input string
            MatchCollection matches = Regex.Matches(input, pattern);

            // Iterate over the matches and print each matched email address
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}