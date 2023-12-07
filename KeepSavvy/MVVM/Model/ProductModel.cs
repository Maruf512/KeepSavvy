using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepSavvy.MVVM.Model
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double PerCarton { get; set; }
        public double DP { get; set; }
        public double TP { get; set; }
        public int DispatchAmount { get; set; }
        public int ReturnAmount { get; set; }
        public int SaleAmount { get; set; }
    }
}
