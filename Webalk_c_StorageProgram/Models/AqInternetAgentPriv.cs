using System;
using System.Collections.Generic;

namespace Webalk_c_StorageProgram.Models;

public partial class AqInternetAgentPriv
{
    public string AgentName { get; set; } = null!;

    public string DbUsername { get; set; } = null!;

    public virtual AqInternetAgent AgentNameNavigation { get; set; } = null!;
}
