namespace HealthEdge.Model
{
    public class Inventory
    {
        public string name { get; set; } //Name of the item 
        public int quantity { get; set; } // Quantity of the item
        public DateTime date { get; set; } // Date the item was added to the List (for testing we will do today's date)

        public Inventory(string name, int quantity, DateTime date)
        {
            this.name = name;
            this.quantity = quantity;
            this.date = date;
        }

        
    }
}
