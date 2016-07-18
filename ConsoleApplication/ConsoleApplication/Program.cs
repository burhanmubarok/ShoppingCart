using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            private CartEntry2[] items;

            CartContent2 orderList = new CartContent2();
            Order2 newOrder = new Order2(orderList, 3);
            Console.Write(newOrder);
            Console.ReadKey();
        }
    }

    public class CartEntry
    {
        public float price;
        public int quantity;
    }

    public class CartContent
    {
        public CartEntry[] items;
    }
    public class Order
    {
        public CartContent cart;
        public float tax;
        public Order(CartContent cart, float tax)
        {
            this.cart = cart;
            this.tax = tax;
        }

        public float OrderTotal()
        {
            float total = 0;
            for (int i = 0; i < cart.items.Length; i++)
            {
                total += cart.items[i].price*cart.items[i].quantity;
            }
            total += total*tax;
            return total;
        }
    }
}
