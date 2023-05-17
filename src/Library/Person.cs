using System;

namespace Proyect;

public abstract class Person
{
    public string Name { get; set; }
    public int Id { get; set; }
    public string Address { get; set; }
    public int PhoneNumber { get; set; }

    public Person(string name, int id, string address, int phoneNumber)
    {
        this.Name = name
        this.Id = id
        this.Address = address
        this.PhoneNumber = phoneNumber
    }
}