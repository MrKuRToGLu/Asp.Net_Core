using System;
using System.Collections.Generic;

namespace _10_StateManagement_QueryString2.Entities
{
    public partial class OrderSubtotal
    {
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
