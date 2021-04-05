namespace CarManager0323.Model
{
    public class Customer
    {
        public Customer(string name, string tel, string addr, string email)
        {
            this.Name = name;
            this.Tel = tel;
            this.Addr = addr;
            this.Email = email;
        }

        public string Name { get; set; }
        public string Tel { get; set; }
        public string Addr { get; set; }
        public string Email { get; set; }
    }
}
