using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_01
{
    public class CustomerRepository
    {
        public void Add(Customer customer)
        {
            try
            {
                // add customer to database
            }
            catch (Exception e)
            {

                // System.IO.File.WriteAllText("D:\\errors.txt",e.ToString());
                FileLogger.Log(e.ToString());
            }

        }

    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }

    }
}
