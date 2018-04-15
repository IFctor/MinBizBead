using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beadando
{
    public class FuelConsciousness
    {
        //Instantiation of a calculate method
        //the choosed calculation method must implement ICalculationMethod
        ICalculationMethod calculator = new MyCalculation();

        /// <summary>
        /// Calculate minimal cost from the input data
        /// </summary>
        /// <param name="inputData">input data</param>
        /// <returns>Calculated minimal cost</returns>
        public int CalculateMinCost(Input inputData)
        {
            return calculator.Calculation(inputData);
        }
    }
}
