namespace CSVHandler.Services;

public interface ICSVService
{
    IEnumerable<T> ReadCSV<T>(Stream file);
}
