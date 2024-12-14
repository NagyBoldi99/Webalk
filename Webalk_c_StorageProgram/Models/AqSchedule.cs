using System;
using System.Collections.Generic;

namespace Webalk_c_StorageProgram.Models;

public partial class AqSchedule
{
    public Guid Oid { get; set; }

    public string Destination { get; set; } = null!;

    public DateTime? StartTime { get; set; }

    public string? Duration { get; set; }

    public string? NextTime { get; set; }

    public string? Latency { get; set; }

    public DateTime? LastTime { get; set; }

    public decimal? Jobno { get; set; }
}
