using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lp_programming
{
    public class BasisAlgoritm
    {
        private Data data;
        public int bearingX;
        public int bearingY;
        private int numberLimit;
        private int numberVariables;
        public Fraction bearing;
        private Fraction division;
        public List<List<Fraction>> pastTable = new List<List<Fraction>>();

        public BasisAlgoritm(Data d)
        {
            data = d;
            numberVariables = data.numberVariables;
            numberLimit = data.numberLimit;
            copyInPastTable();
            print(data.table);
            while (checkEnd())
            {
                findMemberInAllTable();
                conversionRowCol();
                skipLines();    
                exchange();
                goOnColumn();
                copyInPastTable();
                print(data.table);
            }
        }

        public void findMemberInAllTable()
        {
            division = int.MaxValue;
            for (int i = 1; i <= numberVariables; i++)
            {
                if (data.table[numberLimit + 1][i] < 0)
                {
                    searchSupportMember(i);
                }
            }
        }

        private void searchSupportMember(int i) 
        {
            for (int j = 1; j <= numberLimit; j++)
            {
                Fraction temp = data.table[j][numberVariables + 1] / data.table[j][i];
                if (data.table[j][i] > 0 && temp < division)
                {
                    division = data.table[j][numberVariables + 1] / data.table[j][i];
                    bearing = data.table[j][i];
                    bearingX = j;
                    bearingY = i;
                }
            }
        }

        private void exchange()
        {
            Fraction temp = data.table[bearingX][0];
            data.table[bearingX][0] = data.table[0][bearingY];
            data.table[0][bearingY] = temp;
        }

        private bool checkEnd() 
        {
            for (int i = 1; i <= numberVariables; i++)
            {
                if (data.table[numberLimit + 1][i] < 0)
                    return true;
            }
            return false;
        }

        private void goOnColumn()
        {
            bool temp = true;
            int i = 0;
            while (temp && i <= numberVariables)
            {
                if (data.table[0][i] > numberVariables && data.table[numberLimit + 1][i] >= 0)
                {
                    deleteColumn(i);
                    temp = false;
                }
                i++;
            }
            if(!temp)
                numberVariables--;
        }

        private void deleteColumn(int del)
        {
            for (int i = 0; i <= numberLimit + 1; i++)
            {
                data.table[i].RemoveAt(del);
            }
        }

        public void conversionRowCol()
        {
            data.table[bearingX][bearingY] = 1 / data.table[bearingX][bearingY];
            for(int i = 1; i <= numberVariables + 1; i++)
            {
                if(i != bearingY)
                {
                    data.table[bearingX][i] = data.table[bearingX][i] / bearing;
                }
            }

            for (int i = 1; i <= numberLimit+ 1; i++)
            {
                if (i != bearingX)
                {
                    data.table[i][bearingY] = -(data.table[i][bearingY] / bearing);
                }
            }
        }

        private void skipLines()
        {
            for (int i = 1; i <= numberLimit + 1; i++)
            {
                if (i != bearingX)
                {
                    sumVectorTable(i);
                }
            }
        }

        private void sumVectorTable(int x)
        {
            for (int i = 1; i <= numberVariables + 1; i++)
            {
                if (i != bearingY)
                {
                    data.table[x][i] = data.table[x][i] - (pastTable[x][bearingY] * data.table[bearingX][i]);
                 }
            }
        }



        private void print(List<List<Fraction>> list)
        {
            Console.Write("\n");
            for (int i = 0; i < numberLimit + 2; i++)
            {
                for (int j = 0; j < numberVariables + 2; j++)
                {
                    Console.Write(data.table[i][j].ToString() + "   ");
                }
                Console.Write("\n");
            }
        }

        private void copyInPastTable()
        {
            pastTable.Clear();
            for (var i = 0; i < data.table.Count; i++)
            {
                pastTable.Add(data.table[i].ToList());
            }
        }
    }
}