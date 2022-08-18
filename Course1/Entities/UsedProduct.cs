using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course1.Entities
{
    internal class UsedProduct : Product
    {
        public UsedProduct(string name, double price, DateTime manufactureDate) : base (name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public DateTime ManufactureDate { get; set; }

        public sealed override string PriceTag()
        {
            return $"{Name} (used) $ {Price.ToString("F2",CultureInfo.InvariantCulture)} (Manufacture date: {ManufactureDate:dd/MM/yyyy})";
            //StringBuilder sb = new StringBuilder();
            //sb.Append($"Manufacture date : {ManufactureDate}");
            //return sb.ToString() + base.PriceTag();
        }
    }
}
