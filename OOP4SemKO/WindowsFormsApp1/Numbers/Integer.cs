using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Numbers
{
    public class Integer
    {
        public string Value;

        public virtual double Sum(double val)
        {
            return Convert.ToInt32(Value) + val;
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
