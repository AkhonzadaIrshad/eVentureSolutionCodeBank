using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingSiteApplicationEntitiesDemo.Users;

namespace ShoppingSiteApplicationEntitiesDemo.Orders
{
    public class SaleOrder:Order
    {
        
        private SaleOrderDetail[] saleOrderDetails;

        public SaleOrderDetail[] SaleOrderDetails
        {
            get { return saleOrderDetails; }
            set { saleOrderDetails = value; }
        }


        private DateTime dateTime;

        public DateTime DateTime
        {
            get { return dateTime; }
            set { dateTime = value; }
        }
        private string orderNumber;

        public string OrderNumber
        {
            get { return orderNumber; }
            set { orderNumber = value; }
        }
        private double total;

        public double Total
        {
            get { return total; }
            set { total = value; }
        }

        private Customer soldTo;

        public Customer SoldTo
        {
            get { return soldTo; }
            set { soldTo = value; }
        }
        private Employee soldBy;

        public Employee SoldBy
        {
            get { return soldBy; }
            set { soldBy = value; }
        }


    }
}
