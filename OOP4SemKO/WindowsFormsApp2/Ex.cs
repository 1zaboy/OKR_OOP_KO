using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.Cors;

namespace WindowsFormsApp2
{
    public static class Ex
    {
        public static Vegetables GetObj(this IEnumerable<Vegetables> arr, string str)
        {
            return arr.Where(x => x.Name == str).First(); 
        }
    }
}
