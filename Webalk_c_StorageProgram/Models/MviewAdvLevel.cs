using System;
using System.Collections.Generic;

namespace Webalk_c_StorageProgram.Models;

/// <summary>
/// Level definition
/// </summary>
public partial class MviewAdvLevel
{
    public decimal Runid { get; set; }

    public decimal Levelid { get; set; }

    public decimal? Dimobj { get; set; }

    public decimal Flags { get; set; }

    public decimal Tblobj { get; set; }

    public byte[] Columnlist { get; set; } = null!;

    public string? Levelname { get; set; }

    public virtual ICollection<MviewAdvRollup> MviewAdvRollupMviewAdvLevelNavigations { get; set; } = new List<MviewAdvRollup>();

    public virtual ICollection<MviewAdvRollup> MviewAdvRollupMviewAdvLevels { get; set; } = new List<MviewAdvRollup>();

    public virtual MviewAdvLog Run { get; set; } = null!;
}
