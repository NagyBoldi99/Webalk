﻿using System;
using System.Collections.Generic;

namespace Webalk_c_StorageProgram.Models;

public partial class LogmnrProp
{
    public string? Value { get; set; }

    public string? Comment { get; set; }

    public string Name { get; set; } = null!;

    public decimal? LogmnrUid { get; set; }

    public decimal? LogmnrFlags { get; set; }
}
