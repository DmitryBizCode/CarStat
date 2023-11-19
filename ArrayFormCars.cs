using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MethodCollection
{
    internal class ArrayFormCars : ICars
    {
        public List<CarCharakter> Cars;

        public ArrayFormCars() => Cars = new List<CarCharakter>();
        
        public void AddCar(CarCharakter Cars) => this.Cars.Add(Cars);

        public void Remove(int a) => Cars.RemoveAt(a);
        
        public void Sortt()
        {
            Sort sm = new Sort();
            Cars.Sort(sm);
        }
        public void WriteFile(string fileName)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<CarCharakter>));
                FileStream fstream = new FileStream(fileName, FileMode.Create,FileAccess.Write, FileShare.None);
                serializer.Serialize(fstream, Cars);
                fstream.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error writing to file: " + ex.Message);
            }
        }

        public void ReadFile(string fileName)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<CarCharakter>));
                FileStream fstream = new FileStream(fileName, FileMode.Open,FileAccess.Read, FileShare.None);
                Cars = serializer.Deserialize(fstream) as List<CarCharakter>;
                fstream.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading from file: " + ex.Message);
            }
        }
    }
}
