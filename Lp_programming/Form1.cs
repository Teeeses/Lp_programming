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
        private SimplexMethod simplex;
        private TextBox[] functionTextBoxArray;
        private TextBox[,] allTablesTextBox;
        private Button resultButton;

        public windowForm()
        {
            InitializeComponent();
            data = new Data();
            simplex = new SimplexMethod(data);
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
            data.functionSize = data.numberVariables;
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
            basis = new BasisAlgoritm(data);
            resultButton.Enabled = false;
            data.createFunctionArray(functionTextBoxArray);
            basis.createTable(allTablesTextBox);
            basis.menu();
            simplex.menu();
        }
    }
}
