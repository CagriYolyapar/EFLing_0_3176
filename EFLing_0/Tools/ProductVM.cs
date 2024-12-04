using EFLing_0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFLing_0.Tools
{
    public class ProductVM
    {
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
        public string CategoryName { get; set; }
    }
}
