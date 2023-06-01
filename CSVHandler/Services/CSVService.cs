using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;

namespace CSVHandler.Services;

public class CSVService : ICSVService
{
    public IEnumerable<T> ReadCSV<T>(Stream file)
    {

        var config = new CsvConfiguration(CultureInfo.CurrentCulture) { Delimiter = "," };

        using var reader = new StreamReader(file);
        using var csv = new CsvReader(reader, config);
        var records = csv.GetRecords<T>().ToList();
       
        return records;
    }
}

