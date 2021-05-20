using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Numbers
{
    class Decimal : Integer
    {
        public Decimal(double val)
        {
            Value = val.ToString();
        }

        public override double Sum(double val)
        {
            return Convert.ToDouble(Value) + val;
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
