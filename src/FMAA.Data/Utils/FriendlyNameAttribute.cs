﻿using System;

namespace FMAA.Data.Utils
{
    /// <summary>
    /// Attribute to allow a friendly name (e.g. including spaces) and a shortened name to be attached to a property
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class FriendlyNameAttribute : Attribute
    {
        public string FriendlyName { get; set; }
        public string ShortName { get; set; }
    }
}