using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices
{
    public class Ticket
    {
        public int CalculatePrice(int age , int movieTime)
        {
            if (age <=12 || age >= 65)
            {
                return 5;
            }
            else if (age >=13 && age <= 64)
            {
                if (movieTime < 5)
                {
                    return 8;
                }
                else
                {
                    return 10;
                }
            }
            else { 
                
                return 0; }

        }
    }
}
