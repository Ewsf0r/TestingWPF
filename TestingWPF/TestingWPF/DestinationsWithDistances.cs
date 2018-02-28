using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingWPF
{
    public class DestinationsWithDistances
    {
        private IDictionary<Location, double> distance = new Dictionary<Location, double>();
        public double this[Location destination]
        {
            get { return distance[destination]; }
            set { distance[destination] = value; }
        }
        public void Add(Location pointOfDeparture, Location destination)
        {
            distance.Add(destination, Math.Pow(Math.Pow(destination.X - pointOfDeparture.X, 2)
                + Math.Pow(destination.Y - pointOfDeparture.Y, 2), 0.5));
        }
        public ICollection<Location> Keys => distance.Keys;
        public DestinationsWithDistances(Location[] location)
        {
            Add(location[0], location[0]);
            for (int i = 1; i < location.Length; i++)
            {
                Add(location[i - 1], location[i]);
            }
            Add(location[location.Length - 1], new Location("Возвращене в " + location[0].Name, location[0].X, location[0].Y));
        }
        public DestinationsWithDistances(){}
    }
}
