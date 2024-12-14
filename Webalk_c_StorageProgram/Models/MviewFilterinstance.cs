using System;
using System.Collections.Generic;

namespace Webalk_c_StorageProgram.Models;

public partial class MviewFilterinstance
{
    public decimal Runid { get; set; }

    public decimal? Filterid { get; set; }

    public decimal? Subfilternum { get; set; }

    public string? Subfiltertype { get; set; }

    public string? StrValue { get; set; }

    public decimal? NumValue1 { get; set; }

    public decimal? NumValue2 { get; set; }

    public DateTime? DateValue1 { get; set; }

    public DateTime? DateValue2 { get; set; }
}
