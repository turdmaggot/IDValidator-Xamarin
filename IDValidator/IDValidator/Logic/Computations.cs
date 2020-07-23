using System;
using System.Collections.Generic;
using System.Text;

namespace IDValidator.Logic
{
    public static class Computations
    {
        // This will validate if ID number is a valid LaSallian ID number.
        public static bool validateDlsuIdNumber(int idNum) 
        {
            try
            {
                int a, b, c, d, f, g, h, i, summed;

                a = (idNum / 10000000);
                b = (idNum / 1000000) - (a * 10);
                c = (idNum / 100000) - (a * 100 + b * 10);
                d = (idNum / 10000) - (a * 1000 + b * 100 + c * 10);
                f = (idNum / 1000) - (a * 10000 + b * 1000 + c * 100 + d * 10);
                g = (idNum / 100) - (a * 100000 + b * 10000 + c * 1000 + d * 100 + f * 10);
                h = (idNum / 10) - (a * 1000000 + b * 100000 + c * 10000 + d * 1000 + f * 100 + g * 10);
                i = idNum - (a * 10000000 + b * 1000000 + c * 100000 + d * 10000 + f * 1000 + g * 100 + h * 10);

                summed = (a * 8) + (b * 7) + (c * 6) + (d * 5) + (f * 4) + (g * 3) + (h * 2) + (i * 1);

                if (summed % 11 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
