using System;
using System.Collections.Generic;

namespace Webalk_c_StorageProgram.Models;

/// <summary>
/// Temporary table for workload collections
/// </summary>
public partial class MviewAdvSqldepend
{
    public decimal? Collectionid { get; set; }

    public decimal? InstId { get; set; }

    public Guid? FromAddress { get; set; }

    public decimal? FromHash { get; set; }

    public string? ToOwner { get; set; }

    public string? ToName { get; set; }

    public decimal? ToType { get; set; }

    public decimal? Cardinality { get; set; }
}
