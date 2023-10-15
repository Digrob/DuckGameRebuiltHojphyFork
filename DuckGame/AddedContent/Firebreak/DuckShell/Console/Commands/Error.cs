﻿using AddedContent.Firebreak;
using System;

namespace DuckGame.ConsoleEngine
{
    public static partial class Commands
    {
        [Marker.DSHCommand(Description = "Throws an error with the provided message")]
        public static object Error(string errorMessage)
        {
            throw new Exception($"Error: {errorMessage}");
        }
    }
}