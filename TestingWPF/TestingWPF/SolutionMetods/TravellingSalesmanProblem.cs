using System.Collections.Generic;

namespace TestingWPF.SolutionMetods
{
    public partial class TravellingSalesmanProblem
    {
        private DestinationsWithDistances solution = new DestinationsWithDistances();
        public TravellingSalesmanProblem(List<Location> locationsList, string methodName)
        {
            foreach (Location location in locationsList) location.IsVisited = false;
            Map map = new Map(locationsList.ToArray());
            switch (methodName)
            {
                case "Bruteforce":
                    Bruteforce(map);
                    break;
                default:
                    NearestNeighbour(map);
                    break;
            }
        }
        public class Solution : Location
        {
            public double Distance { get; set; }
            public Solution(Location location, double distance)
            {
                Name = location.Name;
                X = location.X;
                Y = location.Y;
                Distance = distance;
            }
        }
        public List<Solution> ToList()
        {
            List<Solution> result = new List<Solution>();
            foreach (Location location in solution.Keys)
            {
                result.Add(new Solution(location, solution[location]));
            }
            return result;
        }
    }
}
