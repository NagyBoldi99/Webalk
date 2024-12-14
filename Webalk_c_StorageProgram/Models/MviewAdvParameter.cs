using System;
using System.Collections.Generic;

namespace Webalk_c_StorageProgram.Models;

/// <summary>
/// Summary advisor tuning parameters
/// </summary>
public partial class MviewAdvParameter
{
    public string ParameterName { get; set; } = null!;

    public decimal ParameterType { get; set; }

    public string? StringValue { get; set; }

    public DateTime? DateValue { get; set; }

    public decimal? NumericalValue { get; set; }
}
