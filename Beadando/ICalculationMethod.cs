using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beadando
{
    interface ICalculationMethod
    {
        /// <summary>
        /// Calculate the minimal cost from inputData
        /// </summary>
        /// <param name="inputData">Read input data from txt</param>
        /// <returns>Calculated trip's cost</returns>
        int Calculation(Input inputData);
    }
}
