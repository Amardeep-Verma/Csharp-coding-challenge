using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_22
{
    internal class Day2
    {
        public void Conversion()
        {
            string age = "25aa";
            bool result = int.TryParse(age, out int newAge);

            if (result)
            {
                var isConverted = newAge;
            }
            else
            {
                var isNotConverted = newAge;
            }

        }

    }
}
