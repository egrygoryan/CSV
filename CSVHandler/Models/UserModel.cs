using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSVHandler.Models;

public class UserModel
{
    [Key]
    public int UserId { get; set; }
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public bool Married { get; set; }
    public string Phone { get; set; }
    [Column(TypeName = "decimal(18,4)")]
    public decimal Salary { get; set; }
}

