using System;
using System.Collections.Generic;
using System.Text;
using Nop.Core;

namespace Nop.Plugin.Misc.Ninja.Domain
{
    public class NinjaCms:BaseEntity
    {
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }
        public bool Published { get; set; }

    }
}
