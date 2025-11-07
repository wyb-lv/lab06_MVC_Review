using System;
using System.Collections.Generic;

namespace admin_edoctor.Models;

public partial class Schedule
{
    public int Id { get; set; }

    public int? DoctorId { get; set; }

    public string? Title { get; set; }

    public DateOnly? Date { get; set; }

    public TimeOnly? Time { get; set; }

    public int? NumOfPatient { get; set; }

    public virtual Doctor? Doctor { get; set; }
}
