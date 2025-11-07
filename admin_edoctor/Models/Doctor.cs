using System;
using System.Collections.Generic;

namespace admin_edoctor.Models;

public partial class Doctor
{
    public int Id { get; set; }

    public string? Email { get; set; }

    public string? Name { get; set; }

    public string? Password { get; set; }

    public string? IdentityNumber { get; set; }

    public string? PhoneNumber { get; set; }

    public int? SpecialtiesId { get; set; }

    public int? AdminId { get; set; }

    public virtual Admin? Admin { get; set; }

    public virtual ICollection<Schedule> Schedules { get; set; } = new List<Schedule>();

    public virtual Specialty? Specialties { get; set; }
}
