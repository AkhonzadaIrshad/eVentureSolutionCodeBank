using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingSiteApplicationEntitiesDemo.Users;

namespace ShoppingSiteApplicationEntitiesDemo.Orders
{
    public class PurchaseOrderDetail
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private Vendor vendor;

        public Vendor Vendor
        {
            get { return vendor; }
            set { vendor = value; }
        }



    }
}
