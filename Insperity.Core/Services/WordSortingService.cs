namespace Insperity.Core.Services;

public class WordSortingService : IWordSortingService
{
    public ICollection<string> SortingOperations(string[] words)
    {
        var results = new List<string>();
        foreach (var word in words)
        {
            var sorted = Sort(word);
            results.Add(sorted);
        }
        return results;
    }

    private string Sort(string word)
    {
        // count frequency of characters in word
        Dictionary<char, int> counter = new Dictionary<char, int>();
        for (int i = 0; i < word.Length; i++)
        {
            if (counter.ContainsKey(word[i]))
            {
                counter[word[i]]++;
                continue;
            }
            
            counter.Add(word[i], 1);
        }
        
        // sort by character frequency, then sort lexicographic by key
        var sorted = counter.OrderByDescending(x => x.Value).ThenBy(x => x.Key);
        
        string result = "";
        foreach (var (key, value) in sorted)
        {
            for (int i = 0; i < value; i++)
            {
                result += key;
            }
        }
        
        return result;
    }
}