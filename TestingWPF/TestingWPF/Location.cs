using System;

namespace TestingWPF
{
    public class Location
    {
        public string Name { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public bool IsVisited { get; set; }
        public Location(string name, double x, double y)
        {
            Name = name;
            X = x;
            Y = y;
            IsVisited = false;
        }
        public Location()
        {
                Name = "";
                X = 0;
                Y = 0;
                IsVisited = false;
        }
        public Location(int id)
        {
            Random r = new Random(DateTime.Now.Millisecond + id);
            Name = id.ToString();
            X = r.Next(1000) + r.NextDouble();
            Y = r.Next(1000) + r.NextDouble();
            IsVisited = false;
        }
    }
}
