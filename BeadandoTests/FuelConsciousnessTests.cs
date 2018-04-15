using Microsoft.VisualStudio.TestTools.UnitTesting;
using Beadando;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beadando.Tests
{
    [TestClass()]
    public class FuelConsciousnessTests
    {
        /// <summary>
        /// Test CalculateMinCost method with null input
        /// </summary>
        [TestMethod()]
        public void CalculateMinCostTest_nullInput()
        {
            FuelConsciousness fC = new FuelConsciousness();
            int sum = fC.CalculateMinCost(null);
            Assert.AreEqual(-1, sum);
        }
        /// <summary>
        /// Test CalculateMinCost method with empty input (constructor make the data value 0)
        /// </summary>
        [TestMethod()]
        public void CalculateMinCostTest_emptyInput()
        {
            Input inputData = new Input();
            FuelConsciousness fC = new FuelConsciousness();
            int sum = fC.CalculateMinCost(inputData);
            Assert.AreEqual(0, sum);
        }
        /// <summary>
        /// Test CalculateMinCost method with example 0
        /// </summary>
        [TestMethod()]
        public void CalculateMinCostTest_example0()
        {
            Input inputData = new Input();
            inputData.lenghtOfTheTrip = 100;
            inputData.fuelCapacityOfTheCar = 50;
            inputData.numberOfGasStation = 4;
            List<FuelStation> fuelStationList = new List<FuelStation>();
            fuelStationList.Add(new FuelStation(20, 100));
            fuelStationList.Add(new FuelStation(30, 10));
            fuelStationList.Add(new FuelStation(50, 60));
            fuelStationList.Add(new FuelStation(70, 70));
            inputData.fuelStationList = fuelStationList;
            FuelConsciousness fC = new FuelConsciousness();
            int sum = fC.CalculateMinCost(inputData);
            Assert.AreEqual(1500, sum);
        }
        /// <summary>
        /// Test CalculateMinCost method with one station in halfway
        /// </summary>
        [TestMethod()]
        public void CalculateMinCostTest_OneHalfWayStation()
        {
            Input inputData = new Input();
            inputData.lenghtOfTheTrip = 100;
            inputData.fuelCapacityOfTheCar = 50;
            inputData.numberOfGasStation = 1;
            List<FuelStation> fuelStationList = new List<FuelStation>();
            fuelStationList.Add(new FuelStation(50, 100));
            inputData.fuelStationList = fuelStationList;
            FuelConsciousness fC = new FuelConsciousness();
            int sum = fC.CalculateMinCost(inputData);
            Assert.AreEqual(5000, sum);
        }
        /// <summary>
        /// Test CalculateMinCost method with we musn't fill the tank of car
        /// </summary>
        [TestMethod()]
        public void CalculateMinCostTest_notMustFill()
        {
            Input inputData = new Input();
            inputData.lenghtOfTheTrip = 100;
            inputData.fuelCapacityOfTheCar = 100;
            inputData.numberOfGasStation = 1;
            List<FuelStation> fuelStationList = new List<FuelStation>();
            fuelStationList.Add(new FuelStation(50, 100));
            inputData.fuelStationList = fuelStationList;
            FuelConsciousness fC = new FuelConsciousness();
            int sum = fC.CalculateMinCost(inputData);
            Assert.AreEqual(0, sum);
        }

    }
}