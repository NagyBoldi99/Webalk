using System;
using System.Collections.Generic;

namespace Webalk_c_StorageProgram.Models;

public partial class LogmnrcT
{
    public decimal LogmnrUid { get; set; }

    public decimal Ts { get; set; }

    public string? Name { get; set; }

    public decimal StartScn { get; set; }

    public decimal? DropScn { get; set; }

    public decimal? Spare1 { get; set; }

    public decimal? Spare2 { get; set; }

    public string? Spare3 { get; set; }
}
