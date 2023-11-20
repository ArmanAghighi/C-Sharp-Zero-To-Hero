namespace Chapter2_Task2
{
    class Shop
    {
        private Dictionary<string, int> _stock;
        private int _money;

        public Shop()
        {
            _stock = new Dictionary<string, int>();
            _money = 100;
        }

        public void AddItem(Item item)
        {
            if (_stock.ContainsKey(item.GetName()))
            {
                _stock[item.GetName()]++;
            }
            else
            {
                _stock.Add(item.GetName(), 1);
            }
        }

        public void RemoveItem(string itemName)
        {
            if (_stock.ContainsKey(itemName))
            {
                _stock.Remove(itemName);
            }
        }

        public void Sell(Player player, string itemName)
        {
            if (_stock.ContainsKey(itemName))
            {
                _money += _stock[itemName];
                _stock[itemName]--;
            }
        }

        public void Buy(Player player, string itemName , int price)
        {
            if (_stock.ContainsKey(itemName) && _money >= _stock[itemName])
            {
                _money -= _stock[itemName];
                _stock[itemName]--;
                Item itemBought = new Item(itemName, price);
                player.AddItem(itemBought);
            }
        }
    }
}
