using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application01
{
    class GetNumbers
    {

        public double Number01;
        public double Number02;
        public void GetUserInputs()
        {
            Console.WriteLine("Enter Number 01 :");
            double Number01 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Number 02 :");
            double Number02 = double.Parse(Console.ReadLine());
        }
    }
}
