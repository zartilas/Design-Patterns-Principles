namespace _4._Data_Mapper
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsVIP { get; set; }

        public Customer(int id, string name, bool isVip)
        {
            ID = id;
            Name = name;
            IsVIP = isVip;
        }
    }
}
