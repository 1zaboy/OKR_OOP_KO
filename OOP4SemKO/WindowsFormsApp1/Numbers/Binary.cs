using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Numbers
{
    class Binary : Integer
    {
        public Binary(string val)
        {
            Value = val;
        }

        public override double Sum(double val)
        {
            return ConverFromBinary(Value) + val;
        }
        public static string ConverToBinary(double wert)
        {
            int bitCount = sizeof(double) * 8;
            char[] result = new char[bitCount];

            Byte[] bytes = BitConverter.GetBytes(wert);

            long lgValue = BitConverter.ToInt64(bytes, 0);

            for (int bit = 0; bit < bitCount; ++bit)
            {
                long maskwert = lgValue & (1 << bit);
                if (maskwert > 0)
                {
                    maskwert = 1;
                }
                result[bitCount - bit - 1] = maskwert.ToString()[0];
            }
            return string.Join("", result);
        }

        public static double ConverFromBinary(string str)
        {
            long v = 0;
            for (int i = str.Length - 1; i >= 0; i--) v = (v << 1) + (str[i] - '0');
            return BitConverter.ToDouble(BitConverter.GetBytes(v), 0);
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
