using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections;

namespace Lp_programming
{
    public class Data
    {
        public string minMax;
        public int numberVariables;
        public int functionSize;
        public int numberLimit;
        public int bearingX;
        public int bearingY;
        public Fraction division;
        public Fraction bearing;
        public List<Fraction> functionArray = new List<Fraction>();
        public List<List<Fraction>> table = new List<List<Fraction>>();
        public string stroka;

        public Data()
        {
            minMax = "min";
        }

        public void createFunctionArray(TextBox[] box)
        {
            for (int i = 0; i <= numberVariables; i++)
            {
                functionArray.Add(new Fraction(0, 1));
            }
            for (int i = 0; i <= numberVariables; i++)
            {
                functionArray.Add(new Fraction(0, 1));
                if(minMax == "max")
                    functionArray[i] = -(Fraction.ToFraction(box[i].Text.ToString()));
                else
                    functionArray[i] = Fraction.ToFraction(box[i].Text.ToString());
            }
            /*functionArray[0] = -1;
            functionArray[1] = -4;
            functionArray[2] = -1;
            functionArray[3] = 0;*/
        }

        public void print(List<List<Fraction>> list)
        {
            Console.Write("\n");
            for (int i = 0; i < numberLimit + 2; i++)
            {
                for (int j = 0; j < numberVariables + 2; j++)
                {
                    Console.Write(list[i][j].ToString() + "   ");
                }
                Console.Write("\n");
            }
        }
    }
}
