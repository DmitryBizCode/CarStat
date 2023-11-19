using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodCollection
{
    internal class Sort : IComparer<CarCharakter>
    {
        public int Compare(CarCharakter car1, CarCharakter car2)
        {
            if (car1.Run < car2.Run)
                return -1;
            if (car1.Run > car2.Run)
                return 1;
            else 
                return 0;
        }
    }
}
