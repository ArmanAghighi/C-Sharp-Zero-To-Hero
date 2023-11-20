namespace Chapter2_Task2
{
    public class Item
    {
        protected string _name;
        protected int _price;

        public Item(string name, int price)
        {
            _name = name;
            _price = price;
        }

        public string GetName()
        {
            return _name;
        }
    }
}
