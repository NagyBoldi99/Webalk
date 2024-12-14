using System;
using System.Collections.Generic;

namespace Webalk_c_StorageProgram.Models;

/// <summary>
/// Base tables refered by a query
/// </summary>
public partial class MviewAdvBasetable
{
    public decimal Collectionid { get; set; }

    public decimal Queryid { get; set; }

    public string? Owner { get; set; }

    public string? TableName { get; set; }

    public decimal? TableType { get; set; }

    public virtual MviewAdvWorkload Query { get; set; } = null!;
}
