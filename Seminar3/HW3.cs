using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Seminar3
{
    public class HW3
    {
        int n {  get; set; }
        public HW3() { }
        public bool EvenOddNumber(int n)
        {
            if (n % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool NumberInInterval(int n)
        {
            if(n > 25 && n < 100)
                return true;
            return false;
        }

    }
}
