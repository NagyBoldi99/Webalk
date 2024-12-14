using System;
using System.Collections.Generic;

namespace Webalk_c_StorageProgram.Models;

public partial class LogmnrtMddl
{
    public decimal SourceObj { get; set; }

    public string SourceRowid { get; set; } = null!;

    public string DestRowid { get; set; } = null!;
}
