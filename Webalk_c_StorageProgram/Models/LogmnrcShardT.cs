using System;
using System.Collections.Generic;

namespace Webalk_c_StorageProgram.Models;

public partial class LogmnrcShardT
{
    public decimal LogmnrUid { get; set; }

    public string TablespaceName { get; set; } = null!;

    public decimal ChunkNumber { get; set; }

    public decimal StartScn { get; set; }

    public decimal? DropScn { get; set; }

    public decimal? Spare1 { get; set; }

    public decimal? Spare2 { get; set; }

    public string? Spare3 { get; set; }
}
