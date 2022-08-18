using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course1.Entities
{
    internal class ImportedProduct : Product
    {

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double CustomsFee { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is ImportedProduct product;
        }

        public override string PriceTag()
        {
            return $"{Name} $ {TotalPrice().ToString("F2",CultureInfo.InvariantCulture)} (Customs fee: $ {CustomsFee})";
            //StringBuilder sb = new StringBuilder();
            //sb.AppendLine($"(Customs fee: $ {TotalPrice()}");
            ////return sb.ToString() + base.PriceTag();
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }
    }
}
