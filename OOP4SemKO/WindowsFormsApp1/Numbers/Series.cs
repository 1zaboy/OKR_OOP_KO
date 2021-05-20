using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Numbers
{
    class Series<T> where T : Integer
    {
        public List<T> Methods = new List<T>();

        public void Clear()
        {
            Methods = new List<T>();
        }

        public double SumAllItem()
        {
            double a = 0;
            
            foreach(var item in Methods)
            {
                a = item.Sum(a);
            }

            return a;
        }

        public void Save()
        {
            using (FileStream sw = new FileStream("Series.json", FileMode.OpenOrCreate))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(sw, Methods);
            }
        }

        public void Load()
        {
            using (FileStream sr = new FileStream("Series.json", FileMode.OpenOrCreate))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                Methods = (List<T>)formatter.Deserialize(sr);
            }
        }
    }
}
