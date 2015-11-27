using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lp_programming
{
    public class Data
    {
        public string minMax;
        public int numberVariables;
        public int numberLimit;
        public double functionData;
        public ArrayList arrayBoxs = new ArrayList();
        public List<List<Fraction>> table = new List<List<Fraction>>();
        public string stroka;

        public Data()
        {
            minMax = "min";
        }
    }
}
