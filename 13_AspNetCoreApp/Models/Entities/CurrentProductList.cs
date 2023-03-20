using System;
using System.Collections.Generic;

namespace _13_AspNetCoreApp.Models.Entities
{
    public partial class CurrentProductList
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
    }
}
