using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices
{
    public class bmi
    {
        public string BodyMassIndex(float bMi)
        {
            if (bMi < 18.5)
            {
                return "underweight";
            }
            else if (bMi >= 18.5 && bMi <= 24.9)
            {
                return "Normal weight";
            }
            else if (bMi >= 25 && bMi <= 30)
            {
                return "Overweight";
            }
            else if (bMi > 30)
            {
                return "obese";
            }
            else
            {
                return "Invalid BMI value ";
            }
        }
    }
}


// Underweight: BMI less than 18.5
// Normal weight: BMI 18.5 - 24.9
// Overweight: BMI 25 - 29.9
// Obese: BMI 30 or greater