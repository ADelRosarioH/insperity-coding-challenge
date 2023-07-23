// author: Anthony Del Rosario
// Insperity Coding Challenge Encora. 
// Date: Sun 23 Jul 2023

using System.Text.RegularExpressions;
using Insperity.Core.Services;

var sortingService = new WordSortingService();
var onlyLettersRegex = new Regex(@"^[a-zA-Z]+$");

Console.WriteLine("Press Enter to start...");
Console.ReadKey();

var numberOfWords = -1;
while (numberOfWords < 1)
{
    Console.WriteLine("Enter the number of words: ");
    if (int.TryParse(Console.ReadLine(), out var n))
    {
        numberOfWords = n;
    }
}

var wordsToSort = new List<string>();
for (int i = 0; i < numberOfWords; i++)
{
    var wordToSort = string.Empty;
    var wordIsValid = false;
    while (!wordIsValid)
    {
        wordToSort = Console.ReadLine();
        wordIsValid = !string.IsNullOrEmpty(wordToSort) && onlyLettersRegex.IsMatch(wordToSort);
        if (!wordIsValid)
        {
            Console.WriteLine("Word cannot empty or contain numbers. Try again...");
        }
    }
    wordsToSort.Add(wordToSort!);
}

var sortedWords = sortingService.SortingOperations(wordsToSort.ToArray());

Console.WriteLine("Here's the list of sorted words: ");

foreach (var sortedWord in sortedWords)
{
    Console.WriteLine(sortedWord);
}