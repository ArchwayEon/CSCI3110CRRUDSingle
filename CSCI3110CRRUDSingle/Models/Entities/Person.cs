using System.ComponentModel.DataAnnotations;

namespace CSCI3110CRRUDSingle.Models.Entities;

public class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; } = String.Empty;
    public string? MiddleName { get; set; }
    public string LastName { get; set; } = String.Empty;
    [DataType(DataType.Date)]
    public DateTime DateOfBirth { get; set; }
}

