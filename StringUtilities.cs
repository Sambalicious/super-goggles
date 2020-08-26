using System.Collections.Generic;
namespace Basics
{
    public class StringUtilities
    {
        
        public static string SummarizedText(string sentence,int maxLength = 20)
    {
    if(sentence.Length < maxLength)
    System.Console.WriteLine(sentence);

    var words = sentence.Split(" ");

    var totalCharacter = 0;
    var summary = new List<string>();
    foreach (var word in words)
    {
        summary.Add(word);
        totalCharacter += word.Length + 1;
        if(totalCharacter > maxLength)
        break;
    }
    return string.Join(" ", summary) + "...";
    }
    }
}