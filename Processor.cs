using System;
using System.Text.RegularExpressions;

namespace UnitCalculator
{
    public class Processor
    {
        public double Calculate(double firstCalculateUnitValue, double secondCalculateUnitValue, double number)
        {
            return number / firstCalculateUnitValue * secondCalculateUnitValue;
        }
        public int GetNumberFormString(string inputString)
        {


            return Int32.Parse(Regex.Replace(inputString, @"\D", ""));
        }

    }
}
