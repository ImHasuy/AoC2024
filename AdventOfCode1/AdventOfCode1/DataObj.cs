using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode1
{
    internal class DataObj
    {
        public int LeftInt { get; set; }
        public int RightInt { get; set; }

        public int DiffBetTwo{ get { return Math.Abs(LeftInt - RightInt); }}

        public DataObj(int leftInt, int rightInt)
        {
            LeftInt = leftInt;
            RightInt = rightInt;
        }
    }
}
