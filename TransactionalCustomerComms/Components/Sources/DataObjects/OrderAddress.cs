namespace TransactionalCustomerComms.Components.Sources.DataObjects;

public class OrderAddress()
{
    
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string Company { get; set; }
    public required string StreetOne { get; set; }
    public required string StreetTwo { get; set; }
    public required string City { get; set; }
    public required string State { get; set; }
    public required string ZipCode { get; set; }
    public required string Country { get; set; }
    public required string Phone { get; set; }
    public required string Email { get; set; }
    
    public string GetFullName() => $"{FirstName} {LastName}";
}