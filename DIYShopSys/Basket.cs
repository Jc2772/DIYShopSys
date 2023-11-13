using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIYShopSys
{
    internal class Basket
    {
        int id;
        string name;
        double price;
        int quantity;
        public void basket(int id,string name,double price,int quantity)
        {
            setId(id);
            setName(name);
            setPrice(price);
            setQuantity(quantity);
        }
        public void setId(int id) {
            this.id = id;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void setPrice(double price)
        {
            this.price = price;
        }
        public void setQuantity(int quantity)
        {
            this.quantity = quantity;
        }
        public int getId()
        {
            return this.id;
        }
        public string getName()
        {
            return this.name;
        }
        public double getPrice()
        {
            return this.price;
        }
        public int getQuantity()
        {
            return this.quantity;
        }
    }
}
