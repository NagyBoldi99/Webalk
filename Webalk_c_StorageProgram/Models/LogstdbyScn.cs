using System;
using System.Collections.Generic;

namespace Webalk_c_StorageProgram.Models;

public partial class LogstdbyScn
{
    public decimal? Obj { get; set; }

    public string? Objname { get; set; }

    public string? Schema { get; set; }

    public string? Type { get; set; }

    public decimal? Scn { get; set; }

    public decimal? Spare1 { get; set; }

    public decimal? Spare2 { get; set; }

    public string? Spare3 { get; set; }
}
