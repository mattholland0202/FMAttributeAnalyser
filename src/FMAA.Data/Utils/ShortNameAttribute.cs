using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FMAA.Data.Utils
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
