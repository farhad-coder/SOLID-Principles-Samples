using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_01
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int ProductType { get; set; }

        //public double GetDiscount()
        //{
        //    if (ProductType == 1)
        //    {
        //        return (Price / 100) * 5;
        //    }
        //    if (ProductType == 2)
        //    {
        //        return (Price / 100) * 10;
        //    }
        //    if (ProductType == 3) 
        //    {
        //        return (Price / 100) * 15;
        //    }
        //    return 0;
        //}

        public virtual double GetDiscount()
        {
            return 0;
        }
    }

    public class ProductType1 : Product
    {
        public override double GetDiscount()
        {
            return (Price / 100) * 5;
        }
    }

    public class ProductType2 : Product
    {
        public override double GetDiscount()
        {
            return (Price / 100) * 10;
        }
    }

    public class ProductType3 : Product
    {
        public override double GetDiscount()
        {
            return (Price / 100) * 15;
        }
    }

}
