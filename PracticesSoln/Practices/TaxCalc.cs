using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices
{
    public class TaxCalc
    {
        public int income(int income)
        {
            if (income <= 10000)
            {
                return 0;
            }
            else if (income <= 50000)
            {
                return 10;
            }
            else if (income > 50000)
            {
                return 20;
            }
            else
            {
                return 0;
            }

        }

    }
}
