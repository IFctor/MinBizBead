using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beadando
{
    public class ReadInput
    {
        /// <summary>
        /// Read txt input file,
        /// and put this data in inputData
        /// </summary>
        /// <param name="fileName">Input file name from the 'C:\temp\ch24_2008' directory </param>
        /// <param name="error">Throwed error</param>
        /// <param name="inputData">inputData </param>
        /// <returns>True - it is perfect read; False - error when process the data, see the error </returns>
        public bool ReadTxt(string fileName, ref string error, ref Input inputData)
        {
            try
            {
                if (inputData == null)
                {
                    error = "The inputData parameter is null";
                    return false;
                }
                string folderName = @"C:\temp\ch24_2008";
                string pathString = System.IO.Path.Combine(folderName, fileName);
                if (!File.Exists(pathString))
                {
                    error = "The file does not exist in this filepath: " + pathString.ToString();
                    return false;
                }
                string[] lines = System.IO.File.ReadAllLines(pathString);
                int helperLenghtOfTheTrip;
                if (int.TryParse(lines[0], out helperLenghtOfTheTrip))
                {
                    inputData.lenghtOfTheTrip = helperLenghtOfTheTrip;
                }
                else
                {
                    error = "Convertation error: " + lines[0] + ")";
                    return false;
                }
                //Read fuel capacity of the car
                int helperFuelCapacityOfTheCar;
                if (int.TryParse(lines[1], out helperFuelCapacityOfTheCar))
                {
                    inputData.fuelCapacityOfTheCar = helperFuelCapacityOfTheCar;
                }
                else
                {
                    error = "Convertation error: " + lines[1] + ")";
                    return false;
                }
                //Read number of gas station
                int helperNumberOfGasStation;
                if (int.TryParse(lines[2], out helperNumberOfGasStation))
                {
                    inputData.numberOfGasStation = helperNumberOfGasStation;
                }
                else
                {
                    error = "Convertation error: (" + lines[2] + ")";
                    return false;
                }
                //Read Gas Station(s) data
                for (int i = 0; i < inputData.numberOfGasStation; i++)
                {
                    int helperDistanceOfTheStation;
                    int helperPriceOfFuel;
                    string[] subLine = lines[i + 3].Split(' ');
                    if (int.TryParse(subLine[0], out helperDistanceOfTheStation)
                        && int.TryParse(subLine[1], out helperPriceOfFuel))
                    {
                        inputData.fuelStationList.Add(
                            new FuelStation(helperDistanceOfTheStation, helperPriceOfFuel));
                    }
                    else
                    {
                        error = "Convertation error: (" + subLine[0] + ")-(" + subLine[1] + ")";
                        return false;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                error = "Exception: " + ex.Message;
                return false;
            }
        }
    }
}
