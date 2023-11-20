namespace Chapter2_Task2
{
    class Player
    {
        private Inventory inventory;

        public Player()
        {
            inventory = new Inventory();
        }

        public void AddItem(Item item)
        {
            inventory.AddItem(item);
        }

        public void RemoveItem(string itemName)
        {
            inventory.RemoveItem(itemName);
        }
    }
}