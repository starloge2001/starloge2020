namespace CarManager0323.Model
{
    public class Car
    {
        public Car(string model, string price, string color, string company, string year)
        {
            this.Model = model;
            this.Price = price;
            this.Color = color;
            this.Company = company;
            this.Year = year;
        }

        public string Model { get; set; }
        public string Price { get; set; }
        public string Color { get; set; }
        public string Company { get; set; }
        public string Year { get; set; }
    }
}
