using System;
using System.Collections.Generic;

namespace Webalk_c_StorageProgram.Models;

public partial class MviewException
{
    public decimal? Runid { get; set; }

    public string? Owner { get; set; }

    public string? TableName { get; set; }

    public string? DimensionName { get; set; }

    public string? Relationship { get; set; }

    public string? BadRowid { get; set; }
}
