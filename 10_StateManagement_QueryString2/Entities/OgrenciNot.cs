using System;
using System.Collections.Generic;

namespace _10_StateManagement_QueryString2.Entities
{
    public partial class OgrenciNot
    {
        public int NotId { get; set; }
        public decimal? Not { get; set; }
        public string? NotTur { get; set; }
        public int? OgrenciId { get; set; }

        public virtual Ogrenci? Ogrenci { get; set; }
    }
}
