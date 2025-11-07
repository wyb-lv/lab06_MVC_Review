using System;
using System.Collections.Generic;

namespace admin_edoctor.Models;

public partial class Patient
{
    public int Id { get; set; }

    public string? IdentityNumber { get; set; }

    public string? Email { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Password { get; set; }

    public string? Address { get; set; }

    public DateOnly? Dob { get; set; }

    public string? PhoneNumber { get; set; }

    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

    public Patient(int id, string? identityNumber, string? email, string? firstName, string? lastName, string? password, string? address, DateOnly? dob, string? phoneNumber)
    {
        Id = id;
        IdentityNumber = identityNumber;
        Email = email;
        FirstName = firstName;
        LastName = lastName;
        Password = password;
        Address = address;
        Dob = dob;
        PhoneNumber = phoneNumber;
    }
}
