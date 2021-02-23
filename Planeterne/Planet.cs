using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planeterne
{
    public class Planet
    {
        public static List<Planet> Planets = new List<Planet>();

        public static List<Planet> PlanetsMeanTemp = new List<Planet>();

        public static List<Planet> PlanetsDiameter = new List<Planet>();

        public string Name { get; set; }
        public double Mass { get; set; }
        public double Diameter { get; set; }
        public double Density { get; set; }
        public double Gravity { get; set; }
        public double RotationPeriod { get; set; }
        public double LengthOfDays { get; set; }
        public double DistanceFromSun { get; set; }
        public double OrbitalPeriod { get; set; }
        public double OrbitalVelocity { get; set; }
        public double MeanTemprature { get; set; }
        public double NumberOfMoons { get; set; }
        public bool RingSystem { get; set; }

        public Planet(string name, double mass, double diameter, double density, double gravity, double rotationPeriod, double lengthOfDays, double distanceFromSun, double orbitalPeriod, double orbitalVelocity, double meanTemp, double numberOfMoons, bool ringSystem)
        {
            this.Name = name;
            this.Mass = mass;
            this.Diameter = diameter;
            this.Density = density;
            this.Gravity = gravity;
            this.RotationPeriod = rotationPeriod;
            this.LengthOfDays = lengthOfDays;
            this.DistanceFromSun = distanceFromSun;
            this.OrbitalPeriod = orbitalPeriod;
            this.OrbitalVelocity = orbitalVelocity;
            this.MeanTemprature = meanTemp;
            this.NumberOfMoons = numberOfMoons;
            this.RingSystem = ringSystem;
        }

        public static void RemovePluto(string name)
        {
            foreach(Planet item in Planets)
            {
                if(item.Name == name)
                {
                    Planets.Remove(item);
                    break;
                }
            }
        }

        public static void AddPluto()
        {
            Planets.Add(new Planet("Pluto", 0.0146, 2370, 2095, 0.7, -153.3, 153.3, 5906.4, 90.56, 4.7, -225, 5, true));
        }

        public static void RemovePlanets()
        {
            Planets.Clear();
            PlanetsMeanTemp.Clear();
            PlanetsDiameter.Clear();
        }
    }
}
