using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices
{
    public class discount
    {
        public int item (int item)
        {
            if(item < 5)
            {
                return 0;
            }else if(item >=5 && item <=10) {
                return 10;
            }else if(item >11)
            {
                return 20;
            }
            else
            {
                return 0;
            }

                     // No discount for buying less than 5 items.
                     // 10 % discount for buying 5 - 10 items.
                     // 20 % discount for buying 11 or more items.
        }
    }
}
