using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Массивы_17._07__1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out int n);
            dataGridView1.Columns.Add("Элемент массива", "");
            dataGridView1.Rows.Add(n);
            int[,] arr = new int[n, n];
            Random r = new Random();
            for (int i = 0; i < n - 1; i++)
            {
                dataGridView1.Columns.Add("Элемент массива", "");
            }
            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = r.Next(1, n);

                    dataGridView1.Rows[i].Cells[j].Value = arr[i, j];
                }
            }
        }
    }
}
