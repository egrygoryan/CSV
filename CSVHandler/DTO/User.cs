using CsvHelper.Configuration.Attributes;

namespace CSVHandler.DTO;

public class User
{
    public string Name { get; set; }
    [Name("Date of Birth")]
    public DateTime DateOfBirth{ get; set; }
    public bool Married { get; set; }
    public string Phone{ get; set; }
    public decimal Salary{ get; set; }
}