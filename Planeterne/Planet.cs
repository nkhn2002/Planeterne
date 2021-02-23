using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planeterne
{
    class Planet
    {
        private List<string> Planets;
        private List<string> PlanetsMeanTemp;
        private List<string> PlanetsDiameter;

        public Planet()
        {
            Planets = new List<string>();

            // Add planets to list
            this.Planets.Add("Merkur");
            this.Planets.Add("Jorden");
            this.Planets.Add("Mars");
            this.Planets.Add("Jupiter");
            this.Planets.Add("Saturn");
            this.Planets.Add("Uranus");
            this.Planets.Add("Neptun");
            this.Planets.Add("Pluto");

            // Add venus after Mekur and before Earth
            this.Planets.Insert(1, "Venus");

            // Remove Pluto since it's not a planet
            this.Planets.Remove("Pluto");

            // Add pluto again
            this.Planets.Add("Pluto");

            // Planets with mean temp
            PlanetsMeanTemp = new List<string>();

            this.PlanetsMeanTemp.Add("Mars");
            this.PlanetsMeanTemp.Add("Jupiter");
            this.PlanetsMeanTemp.Add("Saturn");
            this.PlanetsMeanTemp.Add("Uranus");
            this.PlanetsMeanTemp.Add("Neptun");
            this.PlanetsMeanTemp.Add("Pluto");

            // Planets with diameter over 10000KM and under 50000KM
            PlanetsDiameter = new List<string>();

            this.PlanetsDiameter.Add("Venus");
            this.PlanetsDiameter.Add("Earth");
            this.PlanetsDiameter.Add("Neptune");
        }

        public List<string> GetPlanetNames()
        {
            return Planets;
        }

        public List<string> MeanTemp()
        {
            return PlanetsMeanTemp;
        }

        public List<string> PlanetDiameter()
        {
            return PlanetsDiameter;
        }

        public void RemovePlanets()
        {
            Planets = new List<string>();
            // Remove planets
            for (int i = 0; i < Planets.Count; i++)
            {
                this.Planets.Remove(Planets[i]);
            }
        }
    }
}
