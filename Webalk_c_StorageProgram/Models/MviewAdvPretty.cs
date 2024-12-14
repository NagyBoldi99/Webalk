using System;
using System.Collections.Generic;

namespace Webalk_c_StorageProgram.Models;

/// <summary>
/// Table for sql parsing
/// </summary>
public partial class MviewAdvPretty
{
    public decimal? Queryid { get; set; }

    public string? SqlText { get; set; }
}
