using System;
using System.Collections.Generic;

namespace admin_edoctor.Models;

public partial class Appointment
{
    public int Id { get; set; }

    public int? PatientId { get; set; }

    public int? QueueNumber { get; set; }

    public int? ScheduleId { get; set; }

    public DateOnly? Date { get; set; }

    public int? SpecialtiesId { get; set; }

    public virtual Patient? Patient { get; set; }

    public virtual Specialty? Specialties { get; set; }
}
