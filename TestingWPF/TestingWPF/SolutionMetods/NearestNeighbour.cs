using System;
using System.Linq;

namespace TestingWPF.SolutionMetods
{
    public partial class TravellingSalesmanProblem
    {
        void NearestNeighbour(Map map)
        {
            Location pointOfDeparture = map.Keys.ToArray()[0];
            Location closestDestination = map.Keys.ToArray()[1];
            solution.Add(pointOfDeparture, pointOfDeparture);
            pointOfDeparture.IsVisited = true;
            double shortestDistance = map[pointOfDeparture][closestDestination];
            bool isLastPoint = true;
            do
            {
                foreach (Location destination in map[pointOfDeparture].Keys)
                {
                    if (map[pointOfDeparture][destination] < shortestDistance && !destination.IsVisited)
                    {
                        shortestDistance = map[pointOfDeparture][destination];
                        closestDestination = destination;
                    }
                }
                solution.Add(pointOfDeparture, closestDestination);
                closestDestination.IsVisited = true;
                pointOfDeparture = closestDestination;
                isLastPoint = true;
                foreach (Location destination in map[pointOfDeparture].Keys)
                {
                    if (!destination.IsVisited)
                    {
                        shortestDistance = map[pointOfDeparture][destination];
                        closestDestination = destination;
                        isLastPoint = false;
                        break;
                    }
                }
            } while (!isLastPoint);
            closestDestination = new Location("Возвращение в " + map.Keys.ToArray()[0].Name, 
                map.Keys.ToArray()[0].X, map.Keys.ToArray()[0].Y);
            solution.Add(pointOfDeparture, closestDestination);
            closestDestination = new Location("Общая длина маршрута", 0, 0);
            solution.Add(pointOfDeparture, closestDestination);
            foreach (Location location in map.Keys)
                if (location != closestDestination)
                    solution[closestDestination] += solution[location];
        }
    }
}
