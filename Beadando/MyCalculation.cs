using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beadando
{
    public class MyCalculation : ICalculationMethod
    {
        /// <summary>
        /// Calculate the minimal cost of the trip from the input data
        /// </summary>
        /// <param name="inputData">Input data</param>
        /// <returns>Minimal cost of the trip</returns>
        public int Calculation(Input inputData)
        {
            if (inputData != null)
            {
                List<FuelStation> orderedList = inputData.fuelStationList.OrderBy(o => o.DistanceOfTheStation).ToList();
                int sum = 0;
                int actualDistance = 0;
                int actualFuelCapacity = inputData.fuelCapacityOfTheCar;
                int finish = inputData.lenghtOfTheTrip;
                while (actualDistance < (finish - actualFuelCapacity))
                {
                    // Fillter the input data what the car reach from orderedList to fillteredStationList
                    List<FuelStation> fillteredStationList = new List<FuelStation>();
                    foreach (var item in orderedList)
                    {
                        if ((item.DistanceOfTheStation - actualDistance > 0) && (item.DistanceOfTheStation - actualDistance - actualFuelCapacity <= 0))
                        {
                            fillteredStationList.Add(item);
                        }
                    }
                    //Order te filtered list as price of fuel
                    List<FuelStation> orderedAndFillteredStationList = fillteredStationList.OrderBy(o => o.PriceOfFuel).ToList();
                    sum += orderedAndFillteredStationList[0].PriceOfFuel * (orderedAndFillteredStationList[0].DistanceOfTheStation - actualDistance);
                    actualDistance = orderedAndFillteredStationList[0].DistanceOfTheStation;
                }
                return sum;
            }
            else
            {
                return -1;
            }
        }
    }
}
