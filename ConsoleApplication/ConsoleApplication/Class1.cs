namespace ConsoleApplication
{
    public class CartEntry2
    {
        public float price;
        public int quantity;

        public float GetTotal()
        {
            return price*quantity;
        }
    }

    public class CartContent2
    {
        public CartEntry2[] items;

        public float TotalInEntry()
        {
            float total = 0;
            foreach (CartEntry2 item in items)
            {
                total += item.GetTotal();
            }
            return total;
        }
    }
    public class Order2
    {
        public CartContent2 cart;
        public float tax;
        public Order2(CartContent2 cart, float tax)
        {
            this.cart = cart;
            this.tax = tax;
        }

        public float OrderTotal()
        {
            return cart.TotalInEntry();
        }
    }
}
