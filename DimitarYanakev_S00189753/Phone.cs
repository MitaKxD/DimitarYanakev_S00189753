using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DimitarYanakev_S00189753
{
    public class Phone
    {
        public string PhoneID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Operating_System { get; set; }
        public string OS_Image { get; set; }
        public string Phone_Image { get; set; }

        public void IncreasedPrice(double amount)
        {
            double Percentage = 10;
            double PricePlus = (Price * (Percentage / 100));
            Price = PricePlus;
            return Price;
        }
    }

    public class PhoneData : DbContext
    {
        public PhoneData() : base("MyPhoneData") { }
        public DbSet<Phone> Phones { get; set; }
    }
}
