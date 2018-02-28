using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TestingWPF.SolutionMetods
{
    public partial class TravellingSalesmanProblem
    {
        public void Bruteforce(Map map)
        {
            double totalDistnce = 0;
            double shortestDistance = 0;
            Location[] sub = new Location[map.Keys.Count];
            Location pointOfDeparture = map.Keys.ToArray()[0];
            pointOfDeparture.IsVisited = true;
            sub[0] = pointOfDeparture;
            int index = 0;
            foreach (Location destination in map.Keys)
            {
                if (destination == pointOfDeparture) continue;
                shortestDistance += map[pointOfDeparture][destination];
                pointOfDeparture = destination;
                index++;
                sub[index] = pointOfDeparture;
            }
            pointOfDeparture = map.Keys.ToArray()[0];
            solution = new DestinationsWithDistances(sub);
            totalDistnce = BruteforceRecursion(map, pointOfDeparture, sub, totalDistnce, shortestDistance, 1);
            pointOfDeparture=new Location("Общая длина маршрута", 0, 0);
            solution.Add(pointOfDeparture, pointOfDeparture);
            solution[pointOfDeparture] = totalDistnce;
        }
        private double BruteforceRecursion(Map map, Location pointOfDeparture, Location[] sub, double totalDistance, double shortestDistance, int index)
        {
            if (index < map.Keys.Count())
            { 
                foreach (Location destination in map[pointOfDeparture].Keys)
                {
                    if (!destination.IsVisited)
                    {
                        destination.IsVisited = true;
                        totalDistance += map[pointOfDeparture][destination];
                        sub[index] = destination;
                        shortestDistance = BruteforceRecursion(map, destination, sub, totalDistance, shortestDistance, index + 1);

                        totalDistance -= map[pointOfDeparture][destination];
                        destination.IsVisited = false;
                    }
                }
            }
            else
            {
                if (totalDistance < shortestDistance)
                {
                    shortestDistance = totalDistance;
                    solution = new DestinationsWithDistances(sub);
                }
            }
            return shortestDistance;
        }
    }
}