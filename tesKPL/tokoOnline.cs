namespace tesKPL
{
    public enum Shipping_Type { pending = 1, processed = 2, shipped = 3, delivered = 4};
    public class tokoOnline
    {

        public String Customer_name { get; set; }
        public String product_name { get; set; }
        public int quantity { get; set; }
        public int total_price { get; set; }
        public String order_date { get; set; }
        public String shipping_address { get; set; }
       public Shipping_Type shipping_type { get; set; }

        public tokoOnline(string Customer_name, string product_name, int quantity, int total_price, string order_date, string shipping_address, Shipping_Type shipping_type)
        {
            this.Customer_name = Customer_name;
            this.product_name = product_name; 
            this.quantity = quantity;
            this.total_price = total_price;
            this.order_date = order_date;
            this.shipping_address = shipping_address;
            this.shipping_type = shipping_type;

        }


    }
}
