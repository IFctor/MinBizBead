using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beadando
{
    public class Input
    {
        /// <summary>
        /// Lenght of the trip
        /// </summary>
        public int lenghtOfTheTrip { get; set; }
        /// <summary>
        /// Fuel capacity of the car
        /// </summary>
        public int fuelCapacityOfTheCar { get; set; }
        public int numberOfGasStation { get; set; }
        /// <summary>
        /// List of fuel stations' data
        /// </summary>
        public List<FuelStation> fuelStationList { get; set; }
        /// <summary>
        /// Constructor
        /// Set the lenghtOfTheTrip 0;
        /// Set the fuelCapacityOfTheCar 0;
        /// Set the numberOfGasStation 0;
        /// Set the fuelStationList new list of FuelStation;
        /// </summary>
        public Input()
        {
            lenghtOfTheTrip = 0;
            fuelCapacityOfTheCar = 0;
            numberOfGasStation = 0;
            fuelStationList = new List<FuelStation>();
        }
        public override string ToString()
        {
            StringBuilder helperToString = new StringBuilder();
            helperToString.AppendLine(lenghtOfTheTrip.ToString());
            helperToString.AppendLine(fuelCapacityOfTheCar.ToString());
            helperToString.AppendLine(numberOfGasStation.ToString());
            foreach (var item in fuelStationList)
            {
                helperToString.AppendLine(item.ToString());
            }
            return helperToString.ToString();
        }
    }
}
