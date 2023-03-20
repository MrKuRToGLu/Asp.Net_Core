using System;
using System.Collections.Generic;

namespace _10_StateManagement_QueryString2.Entities
{
    public partial class Ogrenci
    {
        public Ogrenci()
        {
            OgrenciNots = new HashSet<OgrenciNot>();
        }

        public int OgrenciId { get; set; }
        public string? OgrenciAdi { get; set; }

        public virtual ICollection<OgrenciNot> OgrenciNots { get; set; }
    }
}
