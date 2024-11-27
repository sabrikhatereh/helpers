using System.Text.RegularExpressions;

namespace RegexHelper
{
    public class CommentPattern
    {
        private static readonly string pattern = "^[a-zA-Z0-9.,\\s]+$";

        public static bool isMatch(string input)
        {
            return Regex.IsMatch(input, pattern);
        }
    }
}
