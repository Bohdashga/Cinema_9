
namespace Cinema_8
{
    public class Time : ISerializable
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }

        public Time(int Hours = 0, int Minutes = 0)
        {
            this.Hours = Hours;
            this.Minutes = Minutes;
        }

        public Time(Time time)
        {
            Hours = time.Hours;
            Minutes = time.Minutes;
        }

        public static Time operator +(Time obj1, Time obj2)
        {
            Time result = new Time(obj1.Hours + obj2.Hours, obj1.Minutes + obj2.Minutes);
            return result;
        }

        public override bool Equals(object obj)
        {
            var time = obj as Time;

            if (time == null) return false;
            if (time == this) return true;

            return time.Hours == Hours && time.Minutes == Minutes;
        }

        public override string ToString()
        {
            return Hours + ":" + Minutes;
        }

        public string objectToString()
        {
            return Hours + ";" + Minutes;
        }
        public void stringToObject(string str)
        {
            string[] values = str.Split(';');
            Hours = int.Parse(values[0]);
            Minutes = int.Parse(values[1]);
        }
    }
}
