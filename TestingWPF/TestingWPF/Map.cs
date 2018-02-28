using System.Collections.Generic;

namespace TestingWPF
{
    public class Map
    {
        private IDictionary<Location, DestinationsWithDistances> map = new Dictionary<Location, DestinationsWithDistances>();

        public Map(Location[] mapPoints)
        {
            foreach (Location pointOfDeparture in mapPoints)
            {
                map.Add(pointOfDeparture, new DestinationsWithDistances());
                foreach (Location destination in mapPoints)
                {
                    if (destination != pointOfDeparture) map[pointOfDeparture].Add(pointOfDeparture, destination);
                }
            }
        }
        public ICollection<Location> Keys => map.Keys;

        public ICollection<DestinationsWithDistances> Values => map.Values;

        public int Count => map.Count;

        public bool IsReadOnly => map.IsReadOnly;

        public DestinationsWithDistances this[Location key] { get => map[key]; set => map[key] = value; }

        public bool ContainsKey(Location key)
        {
            return map.ContainsKey(key);
        }

        public void Add(Location key, DestinationsWithDistances value)
        {
            map.Add(key, value);
        }

        public bool Remove(Location key)
        {
            return map.Remove(key);
        }

        public bool TryGetValue(Location key, out DestinationsWithDistances value)
        {
            return map.TryGetValue(key, out value);
        }

        public void Add(KeyValuePair<Location, DestinationsWithDistances> item)
        {
            map.Add(item);
        }

        public void Clear()
        {
            map.Clear();
        }

        public bool Contains(KeyValuePair<Location, DestinationsWithDistances> item)
        {
            return map.Contains(item);
        }

        public void CopyTo(KeyValuePair<Location, DestinationsWithDistances>[] array, int arrayIndex)
        {
            map.CopyTo(array, arrayIndex);
        }

        public bool Remove(KeyValuePair<Location, DestinationsWithDistances> item)
        {
            return map.Remove(item);
        }

        public IEnumerator<KeyValuePair<Location, DestinationsWithDistances>> GetEnumerator()
        {
            return map.GetEnumerator();
        }
    }
}
