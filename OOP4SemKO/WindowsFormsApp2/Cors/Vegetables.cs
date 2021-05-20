using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Cors
{
    public class Vegetables
    {
        public string Name { get; set; }

        public VegetablesType Type { get; set; }
        public string Sort { get; set; }
        public double Price { get; set; }
        public DateTime DateCreate { get; set; }

        public void Save(string folder, string name)
        {
            using (FileStream sw = new FileStream(folder + name, FileMode.OpenOrCreate))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(sw, this);
            }
        }
    }
}
