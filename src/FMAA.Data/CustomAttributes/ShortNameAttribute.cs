using System;

namespace FMAA.Data.CustomAttributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ShortNameAttribute : Attribute
    {
        public ShortNameAttribute(string shortName)
        {
            ShortName = shortName;
        }

        public string ShortName { get; set; }
    }
}
