using System;
using System.Collections.Generic;

namespace Webalk_c_StorageProgram.Models;

public partial class LogstdbyParameter
{
    public string? Name { get; set; }

    public string? Value { get; set; }

    public decimal? Type { get; set; }

    public decimal? Scn { get; set; }

    public decimal? Spare1 { get; set; }

    public decimal? Spare2 { get; set; }

    public string? Spare3 { get; set; }
}
