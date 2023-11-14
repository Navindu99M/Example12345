using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application01
{
    class Summation: GetNumbers
    {
        public Double GetSummation()
        {
            GetUserInputs();

            return Number01 + Number02;
        }
    }
}
