
namespace Cinema_8
{
    public class CinemaHall : ISerializable
    {
        public string Name { get; set; }
        public Movie Movie { get; set; }
        public bool[,] Seats { get; }

        public CinemaHall()
        {
            Name = "";
            Movie = new Movie();
            Seats = new bool[10, 10];
        }

        public CinemaHall(string Name, Movie Movie)
        {
            this.Name = Name;
            this.Movie = new Movie(Movie);
            Seats = new bool[10, 10];
        }

        public override string ToString()
        {
            string res = "Hall name: " + Name + "\n";
            res += "Movie:\n" + Movie + "\n\nSeats:\n\n";

            res += ("X----------------------------------------------------------X") + "\n";
            res += ("| Row |                                        |   Price   |") + "\n";
            res += ("X----------------------------------------------------------X") + "\n";
            for (int i=0;i<10;i++)
            {
                res += $"| {i + 1,3} |";
                for (int j = 0; j < 10; j++)
                {
                    if(Seats[i,j])
                    {
                        res += (" XX ");
                    }
                    else
                    {
                        res += ($" {i*10+j,2} ");
                    }
                }
                res += ($"| {Movie.Price * (1.0 + i/10.0),9} |") + "\n";
            }
            res += ("X----------------------------------------------------------X") + "\n";

            return res;
        }

        public string objectToString()
        {
            return Name + ";" + Movie.objectToString();
        }
        public void stringToObject(string str)
        {
            string[] values = str.Split(';');
            Name = values[0];
            Movie = new Movie();
            Movie.stringToObject(str.Substring(values[0].Length + 1));
        }
    }
}
