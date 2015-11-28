using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Lp_programming
{
    public class BasisAlgoritm
    {
        private Data data;
        private int numberLimit;
        private int numberVariables;
        private List<List<Fraction>> pastTable = new List<List<Fraction>>();

        public BasisAlgoritm(Data d)
        {
            data = d;
            numberVariables = data.numberVariables;
            numberLimit = data.numberLimit;
        }

        public void menu()
        {
            copyInPastTable();
            data.print(data.table);
            while (checkEnd())
            {
                findMemberInAllTable();
                conversionRowCol();
                skipLines();
                exchange();
                goOnColumn();
                copyInPastTable();
                data.print(data.table);
            }
        }

        public void createTable(TextBox[,] box)
        {
            for (int i = 0; i < data.numberLimit + 2; i++)
            {
                List<Fraction> list = new List<Fraction>();
                for (int j = 0; j < data.numberVariables + 2; j++)
                {
                    list.Add(new Fraction(0, 1));
                }
                data.table.Add(list);
            }

            for (int i = 1; i <= data.numberLimit; i++)
            {
                data.table[i][0] = new Fraction(data.numberVariables + i, 1);
            }

            for (int i = 1; i <= data.numberVariables; i++)
            {
                data.table[0][i] = new Fraction(i, 1); ;
            }
            
            for (int i = 1; i <= data.numberLimit; i++)
            {
                for (int j = 1; j <= data.numberVariables + 1; j++)
                {
                    data.table[i][j] = Fraction.ToFraction(box[i - 1, j - 1].Text.ToString());
                }
            }

            /*data.table[1][1] = new Fraction(1, 1);
            data.table[1][2] = new Fraction(-1, 1);
            data.table[1][3] = new Fraction(1, 1);
            data.table[1][4] = new Fraction(3, 1);
            data.table[2][1] = new Fraction(2, 1);
            data.table[2][2] = new Fraction(-5, 1);
            data.table[2][3] = new Fraction(-1, 1);
            data.table[2][4] = new Fraction(0, 1);*/

            for (int i = 1; i <= data.numberVariables + 1; i++)
            {
                Fraction temp = new Fraction(0, 1);
                for (int j = 1; j <= data.numberLimit; j++)
                {
                    temp = temp + data.table[j][i];
                }
                data.table[data.numberLimit + 1][i] = -temp;
            }
        }

        private void findMemberInAllTable()
        {
            data.division = int.MaxValue;
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
                if (data.table[j][i] > 0 && temp < data.division)
                {
                    data.division = data.table[j][numberVariables + 1] / data.table[j][i];
                    data.bearing = data.table[j][i];
                    data.bearingX = j;
                    data.bearingY = i;
                }
            }
        }

        private void exchange()
        {
            int bearingX = data.bearingX;
            int bearingY = data.bearingY;
            Fraction temp = data.table[bearingX][0];
            data.table[data.bearingX][0] = data.table[0][bearingY];
            data.table[0][data.bearingY] = temp;
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
            if (!temp)
            {
                numberVariables--;
                data.numberVariables--;
            }
        }

        private void deleteColumn(int del)
        {
            for (int i = 0; i <= numberLimit + 1; i++)
            {
                data.table[i].RemoveAt(del);
            }
        }

        private void conversionRowCol()
        {
            int bearingX = data.bearingX;
            int bearingY = data.bearingY;
            data.table[bearingX][bearingY] = 1 / data.table[bearingX][bearingY];
            for(int i = 1; i <= numberVariables + 1; i++)
            {
                if(i != bearingY)
                {
                    data.table[bearingX][i] = data.table[bearingX][i] / data.bearing;
                }
            }

            for (int i = 1; i <= numberLimit+ 1; i++)
            {
                if (i != bearingX)
                {
                    data.table[i][bearingY] = -(data.table[i][bearingY] / data.bearing);
                }
            }
        }

        private void skipLines()
        {
            int bearingX = data.bearingX;
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
            int bearingX = data.bearingX;
            int bearingY = data.bearingY;
            for (int i = 1; i <= numberVariables + 1; i++)
            {
                if (i != bearingY)
                {
                    data.table[x][i] = data.table[x][i] - (pastTable[x][bearingY] * data.table[bearingX][i]);
                 }
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