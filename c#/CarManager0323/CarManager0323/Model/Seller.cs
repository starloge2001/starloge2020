namespace CarManager0323.Model
{
    public class Seller
    {
        public Seller(string name, string tel, string email, string jikwi, string officeName)
        {
            this.Name = name;
            this.Tel = tel;
            this.Email = email;
            this.Jikwi = jikwi;
            this.OfficeName = officeName;
        }

        public string Name { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public string Jikwi { get; set; }
        public string OfficeName { get; set; }
    }
}
