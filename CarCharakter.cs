using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace MethodCollection
{
    public class CarCharakter : IComparable
    {
        public string Brand { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public int Run {  get; set; }
        public CarCharakter (string brand,string name, int year, int run)
        {
            Brand = brand;
            Name = name;
            Year = year;
            Run = run;
        }
        public CarCharakter() { }
        public int CompareTo(object obj)
        {
            var run = obj as CarCharakter;
            return Run.CompareTo(run.Run);
        }
    }
}
