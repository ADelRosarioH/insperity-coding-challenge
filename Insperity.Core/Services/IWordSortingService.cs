namespace Insperity.Core.Services;

public interface IWordSortingService
{
    ICollection<string> SortingOperations(string[] words);
}