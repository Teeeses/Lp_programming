using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Lp_programming
{
    public partial class windowForm : Form
    {
        private Data data;
        private BasisAlgoritm basis;
        private TextBox[] functionTextBoxArray;
        private TextBox[,] allTablesTextBox;
        private Button resultButton;

        public windowForm()
        {
            InitializeComponent();
            data = new Data();
            resultButton = new Button();
            groupBox2.Hide();
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tablePanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            minMaxBox.Text = data.minMax;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void graphicToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void basisToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void simplexToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void minMaxBox_Click(object sender, EventArgs e)
        {
            minMaxBox.Items.Clear();
            if (data.minMax == "min")
            {
                minMaxBox.Items.Add("max");
            }
            else
            {
                minMaxBox.Items.Add("min");
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            data.minMax = minMaxBox.Text.ToString();
            data.numberVariables = Convert.ToInt32(variablesBox.Text.ToString());
            data.numberLimit = Convert.ToInt32(limitBox.Text.ToString());
            groupBox2.Show();
            createFunctionPanel();
            createAllTables();
        }

        private void createFunctionPanel()
        {
            Label func = new Label();
            func.Text = " Функция:";
            func.TextAlign = ContentAlignment.MiddleRight;
            functionPanel.Controls.Add(func);
            functionTextBoxArray = new TextBox[data.numberVariables + 1];
            for (int i = 0; i < data.numberVariables + 1; i++)
            {
                functionTextBoxArray[i] = new TextBox();
                functionTextBoxArray[i].Width = functionTextBoxArray[i].Height;
                functionPanel.Controls.Add(functionTextBoxArray[i]);
            }
            Label anyway = new Label();
            anyway.Text = "-->";
            anyway.Width = 25;
            anyway.TextAlign = ContentAlignment.MiddleCenter;
            functionPanel.Controls.Add(anyway);
            Label minMax = new Label();
            minMax.TextAlign = ContentAlignment.MiddleCenter;
            minMax.Text = data.minMax;
            minMax.Width = 25;
            functionPanel.Controls.Add(minMax);
        }

        private void createAllTables()
        {
            allTablesTextBox = new TextBox[data.numberLimit, data.numberVariables + 1];
            for (int i = 0; i < data.numberLimit; i++)
            {
                FlowLayoutPanel panel = new FlowLayoutPanel();
                panel.AutoSize = true;
                panel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                Label label = new Label();
                label.Text = ("Ограничение " + (i + 1).ToString() + ":");
                label.TextAlign = ContentAlignment.MiddleRight;
                panel.Controls.Add(label);

                for (int j = 0; j < data.numberVariables; j++)
                {
                        allTablesTextBox[i, j] = new TextBox();
                        allTablesTextBox[i, j].Width = allTablesTextBox[i, j].Height;
                        panel.Controls.Add(allTablesTextBox[i, j]);
                }
                Label anyway = new Label();
                anyway.Text = "=";
                anyway.Width = 20;
                anyway.TextAlign = ContentAlignment.MiddleRight;
                panel.Controls.Add(anyway);
                allTablesTextBox[i, data.numberVariables] = new TextBox();
                allTablesTextBox[i, data.numberVariables].Width = allTablesTextBox[i, data.numberVariables].Height;
                panel.Controls.Add(allTablesTextBox[i, data.numberVariables]);
                tablePanel.Controls.Add(panel);
            }

            resultButton.Text = "Найти решение";
            tablePanel.Controls.Add(resultButton);
            resultButton.Click += new EventHandler(ResultButton_Click);
        }

        private void ResultButton_Click(object sender, EventArgs e)
        {
            resultButton.Enabled = false;
            createTable();
            basis = new BasisAlgoritm(data);
        }

        public void createTable()
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
                data.table[i][0] = data.numberVariables + i;
            }

            for (int i = 1; i <= data.numberVariables; i++)
            {
                data.table[0][i] = i;
            }

            for (int i = 1; i <= data.numberLimit; i++)
            {
                for (int j = 1; j <= data.numberVariables + 1; j++)
                {
                    data.table[i][j] = Fraction.ToFraction(allTablesTextBox[i - 1, j - 1].Text.ToString());
                }
            }

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
    }
}
