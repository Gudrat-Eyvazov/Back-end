using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Interface
{
    internal class Calculator : IDivide, IDifference, IMultiply, ISum
    {
        public double Difference(params double[] nums)
        {
            double ferq = 100;
            for (int i = 0; i < nums.Length; i++)
            {
                ferq -= nums[i];
            }
            return ferq;
        }

        public double Multiply(params double[] nums)
        {
            double hasil = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                hasil *= nums[i];
            }
            return hasil;
        }

        public double Divide(params double[] nums)
        {
            double bolme = 100;
            for (int i = 0; i < nums.Length; i++)
            {
                bolme /= nums[i];
            }
            return bolme;
        }
        
        public double sum(params double[] num)
        {
            double cem = 0;
            for (int i = 0;i<num.Length;i++)
            {
                cem += num[i];
            }
            return cem;
        }

       
    }
}
