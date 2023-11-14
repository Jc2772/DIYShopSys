using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIYShopSys
{
    internal class Item
    {
        int id;
        String name;
        String Type;
        Double Price;
        int SupplierId;
        int Quantity;
        public Item(int id,String name,String Type,Double Price,int SupplierId,int Quantity)
        {
            this.id = id;
            this.name = name;
            this.Type = Type;
            this.Price = Price;
            this.SupplierId = SupplierId;
            this.Quantity = Quantity;
        }
        public void SetId(int id)
        {
            this.id = id;
        }
        public void SetName(String name)
        {
            this.name = name;
        }
        public void SetType(String type)
        {
            this.Type = type;
        }
        public void SetPrice(Double price)
        {
            this.Price = price;
        }
        public void SetSupplierId(int supplierId)
        {
            this.SupplierId = supplierId;
        }
        public void SetQuantity(int quantity)
        {
            this.Quantity = quantity;
        }
        public int GetSupplierId()
        {
            return this.SupplierId;
        }
        public String GetName()
        {
            return this.name;
        }
        public String GetType(String type)
        {
            return this.Type;
        }
        public Double GetPrice() { 
            return this.Price; 
        }
        public int getSupplierId()
        {
            return this.SupplierId;
        }
        public int getQuantity()
        {
            return this.Quantity;
        }
    }
}
