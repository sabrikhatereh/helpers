// See https://aka.ms/new-console-template for more information

using System.Text.RegularExpressions;

var random = new Random();

Console.WriteLine(GetString(3));




//Write a function solution that, given an integer N, returns a string of length N containing as many different lower-case
//letters ('a'-'z') as possible,
//in which each letter occurs an equal number of times.
//Examples:
//1.Given N = 3, the function may return "fig", "pea", "nut", etc. Each of these strings contains three different letters with the same number of occurrences.
//2. Given N = 5, the function may return "mango", "grape", "melon", etc.
//3. Given N = 30, the function may return "aabbcc...oo"
const string chars = "ABCDEFGHIJKLMNOPQRST";

string GetString(int length)
{
    int repeatable = length / chars.Length==0 ? 1 : length / chars.Length;
    var letters = "";
    for (int i = 0; i < length; i++)
    {
        var selectedchar = getChar();
        if (CountCharsUsingRegex(letters, selectedchar) == 0)
            for (int j = 0; j < repeatable; j++)
                letters += selectedchar;
    }
    return letters.ToLower();

}

char getChar()
{
    return chars[random.Next(chars.Length)];
}

int CountCharsUsingRegex(string source, char toFind)
{
    return new Regex(Regex.Escape(toFind.ToString())).Matches(source).Count;
}