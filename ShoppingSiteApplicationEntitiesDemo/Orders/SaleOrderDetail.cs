using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingSiteApplicationEntitiesDemo.Products;

namespace ShoppingSiteApplicationEntitiesDemo.Orders
{
    public class SaleOrderDetail
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private int quantity;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        private double amount;

        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        private Product product;

        public Product Product
        {
            get { return product; }
            set { product = value; }
        }


    }
}
