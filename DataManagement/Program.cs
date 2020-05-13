using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DimitarYanakev_S00189753;

namespace DataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneData db = new PhoneData();

            using (db)
            {
                Phone p1 = new Phone() { Name="Samsung S20", Price = 500, Operating_System = "Android", OS_Image = "/images/android.png", Phone_Image = "/images/android.png" };
                Phone p2 = new Phone() { Name = "iPhone 11", Price = 600, Operating_System = "IOS", OS_Image = "/images/apple.png", Phone_Image = "/images/iphone11.jpg" };


                db.Phones.Add(p1);
                db.Phones.Add(p2);

                Console.WriteLine("Added Phones to Database");

                db.SaveChanges();

                Console.WriteLine("Saved to Database");
            }
        }
    }
}
