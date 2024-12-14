using System;
using System.Collections.Generic;

namespace Webalk_c_StorageProgram.Models;

public partial class AqInternetAgent
{
    public string AgentName { get; set; } = null!;

    public decimal Protocol { get; set; }

    public string? Spare1 { get; set; }
}
