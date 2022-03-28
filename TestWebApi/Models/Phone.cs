namespace TestWebApi.Models
{
    public class Phone
    {
        public static int _id = 1;

        public Phone(string name, int price)
        {
            Name = name;
            Price = price;
            SetId();
        }
        private void SetId()
        {
            this.Id = _id++;
        }
        public int Id { get; private set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
