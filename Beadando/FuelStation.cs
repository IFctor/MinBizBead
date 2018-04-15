using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beadando
{
    public class FuelStation
    {
        /// <summary>
        /// Distance of the fuel station from the start point (0)
        /// </summary>
        public int DistanceOfTheStation { get; set; }
        /// <summary>
        /// Price of fuel in the station
        /// </summary>
        public int PriceOfFuel { get; set; }

        public override string ToString()
        {
            return DistanceOfTheStation.ToString() + " " + PriceOfFuel.ToString();
        }
        /// <summary>
        /// Constructor
        /// Set the DistanceOfTheStation
        /// Set the PriceOfFuel
        /// </summary>
        /// <param name="distance">DistanceOfTheStation</param>
        /// <param name="price">PriceOfFuel</param>
        public FuelStation(int distance, int price)
        {
            this.DistanceOfTheStation = distance;
            this.PriceOfFuel = price;
        }
    }
}
