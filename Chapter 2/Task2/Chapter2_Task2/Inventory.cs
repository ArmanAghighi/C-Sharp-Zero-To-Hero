namespace Chapter2_Task2
{
    class Inventory
    {
        private List<Item> _items;

        public Inventory()
        {
            _items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            _items.Add(item);
        }

        public void RemoveItem(string itemName)
        {
            Item? itemToRemove = null;
            foreach (Item item in _items)
            {
                if (item.GetName() == itemName)
                    itemToRemove = item;
            }
            if (itemToRemove != null)
            {
                _items.Remove(itemToRemove);
            }
        }
    }
}
