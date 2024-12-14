using System;
using System.Collections.Generic;

namespace Webalk_c_StorageProgram.Models;

/// <summary>
/// Each row repesents either a functional dependency or join-key relationship
/// </summary>
public partial class MviewAdvRollup
{
    public decimal Runid { get; set; }

    public decimal Clevelid { get; set; }

    public decimal Plevelid { get; set; }

    public decimal Flags { get; set; }

    public virtual MviewAdvLevel MviewAdvLevel { get; set; } = null!;

    public virtual MviewAdvLevel MviewAdvLevelNavigation { get; set; } = null!;

    public virtual MviewAdvLog Run { get; set; } = null!;
}
