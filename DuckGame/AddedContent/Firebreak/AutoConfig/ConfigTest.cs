﻿using System;
using System.Collections.Generic;

namespace DuckGame;

public static class ConfigTest
{
    // [AutoConfigField]
    public static string Test
    {
        get => "test value";
        set => DevConsole.Log(value);
    }
}