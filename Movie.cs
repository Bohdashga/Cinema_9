

namespace Cinema_8
{
    public class Movie : ISerializable
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
        public double Price { get; set; }

        public Movie()
        {
            Name = "";
            Description = "";
            Duration = 0;
            Price = 0;
        }

        public Movie(string Name,string Description,int Duration,double Price)
        {
            this.Name = Name;
            this.Description = Description;
            this.Duration = Duration;
            this.Price = Price;
        }

        public Movie(Movie movie)
        {
            Name = movie.Name;
            Description = movie.Description;
            Duration = movie.Duration;
            Price = movie.Price;
        }

        public override string ToString()
        {
            return "Name: " + Name +
                "\nDescription: " + Description +
                "\nDuration: " + Duration +
                "\nPrice: " + Price;
        }

        public string objectToString()
        {
            return Name + ";" + Description + ";" + Duration + ";" + Price;
        }
        public void stringToObject(string str)
        {
            string[] values = str.Split(';');
            Name = values[0];
            Description = values[1];
            Duration = int.Parse(values[2]);
            Price = double.Parse(values[3]);
        }
    }
}
