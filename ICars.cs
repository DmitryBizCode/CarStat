using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodCollection
{
    internal interface ICars
    {
        void AddCar(CarCharakter Cars);
        void Remove(int q);
        void Sortt();
        void WriteFile(string fileName);
        void ReadFile(string fileName);
    }
}
