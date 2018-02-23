using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingSiteApplicationEntitiesDemo.Users;

namespace ShoppingSiteApplicationEntitiesDemo.Orders
{
    public class PurchaseOrder:Order
    {
        private PurchaseOrderDetail[] purchaseOrderDetail;

        public PurchaseOrderDetail[] PurchaseOrderDetail
        {
            get { return purchaseOrderDetail; }
            set { purchaseOrderDetail = value; }
        }
      
    }
}
