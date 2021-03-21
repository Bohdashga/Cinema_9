using System;
using System.Collections.Generic;


namespace Cinema_8
{
    public class VipViewer : Viewer, IComparable
    {
        public string Name { get; set; }
        public int Rating { get; set; }

        public List<Movie> VisitedMovies { get; }

        public VipViewer() : base()
        {
            Name = "";
            Rating = 0;
            VisitedMovies = new List<Movie>();
        }

        public VipViewer(string Name, string Movie, Time StartTime, int Rating = 0) : base(Movie, StartTime)
        {
            this.Name = Name;
            this.Rating = Rating;
        }

        public VipViewer(VipViewer vipViewer) : base(vipViewer)
        {
            Name = vipViewer.Name;
            Rating = vipViewer.Rating;
        }

        public override string ToString()
        {
            return "Name: " + Name +
                "\nStart Time: " + StartTime +
                "\nRating: " + Rating;
        }

        public override bool Equals(object obj)
        {
            var viewer = obj as VipViewer;

            if (viewer == null)
                return false;

            if (viewer == this)
                return true;

            return Name == viewer.Name && Movie == viewer.Movie && StartTime.Equals(viewer.StartTime) &&
                Rating == viewer.Rating;
        }

        public override string objectToString()
        {
            return Name + ";" + Movie + ";" + StartTime.objectToString() + ";" + Rating;
        }
        public override void stringToObject(string str)
        {
            string[] values = str.Split(';');
            Name = values[0];
            Movie = values[1];
            StartTime.Hours = int.Parse(values[2]);
            StartTime.Minutes = int.Parse(values[3]);
            Rating = int.Parse(values[4]);
        }

        public static bool operator <(VipViewer viewer1, VipViewer viewer2)
        {
            return viewer1.Rating < viewer2.Rating;
        }

        public static bool operator >(VipViewer viewer1, VipViewer viewer2)
        {
            return viewer1.Rating < viewer2.Rating;
        }

        public int CompareTo(object obj)
        {
            var vipViewer = obj as VipViewer;

            if (obj == null) return 1;
            if (vipViewer == this) return 0;

            return Rating.CompareTo(vipViewer.Rating);
        }

        public Movie this[int key]
        {
            get => VisitedMovies[key];
        }

        public int this[string key]
        {
            get => VisitedMovies.FindAll((x) => x.Name == key).Count;
        }
    }
}
