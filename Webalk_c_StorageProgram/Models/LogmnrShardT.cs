using System;
using System.Collections.Generic;

namespace Webalk_c_StorageProgram.Models;

public partial class LogmnrShardT
{
    public decimal LogmnrUid { get; set; }

    public string TablespaceName { get; set; } = null!;

    public decimal ChunkNumber { get; set; }

    public decimal? StartScnbas { get; set; }

    public decimal? StartScnwrp { get; set; }
}
