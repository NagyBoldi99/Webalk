using System;
using System.Collections.Generic;

namespace Webalk_c_StorageProgram.Models;

public partial class LogmnrProcessedLog
{
    public decimal Session { get; set; }

    public decimal Thread { get; set; }

    public decimal? Sequence { get; set; }

    public decimal? FirstChange { get; set; }

    public decimal? NextChange { get; set; }

    public DateTime? FirstTime { get; set; }

    public DateTime? NextTime { get; set; }

    public string? FileName { get; set; }

    public decimal? Status { get; set; }

    public string? Info { get; set; }

    public DateTime? Timestamp { get; set; }
}
