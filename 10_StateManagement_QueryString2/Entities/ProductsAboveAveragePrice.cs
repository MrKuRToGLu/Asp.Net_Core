using System;
using System.Collections.Generic;

namespace _10_StateManagement_QueryString2.Entities
{
    public partial class ProductsAboveAveragePrice
    {
        public string ProductName { get; set; } = null!;
        public decimal? UnitPrice { get; set; }
    }
}
