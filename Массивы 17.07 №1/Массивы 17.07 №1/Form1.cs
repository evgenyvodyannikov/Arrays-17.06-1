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
        public int[,] arr;
        public int n;
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Columns.Clear();
                dataGridView1.Rows.Clear();
                int.TryParse(textBox1.Text, out n);
                dataGridView1.Columns.Add("Элемент массива", "");
                dataGridView1.Rows.Add(n);
                arr = new int[n, n];
                Random r = new Random();
                for (int i = 0; i < n - 1; i++)
                {
                    dataGridView1.Columns.Add("Элемент массива", "");
                }
                for (int i = 0; i < n; i++)
                {

                    for (int j = 0; j < n; j++)
                    {
                        arr[i, j] = r.Next(1, n + 1);

                        dataGridView1.Rows[i].Cells[j].Value = arr[i, j];
                    }
                }
                button1.Enabled = true;
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int flag = 0;
            int sum = 0;
            int summa;

            int i = 0;
            int j = 0;


            summa = n * (n + 1) / 2;
            int[] mass = new int[n * n];

            for (i = 0; i < n; i++)
                for (j = 0; j < n; j++)
                {
                    mass[i * n + j] = arr[i, j];
                }



            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    if (mass[i * n + j] < 1 || mass[i * n + j] > n)   // если один из элементов строки меньше 1 или больше n ,
                    {                                                 // то это не латинский квадрат,
                        i = n;                                          // приравниваем счётчики i и j к n,
                        j = n;                                          // что обеспечивает выход из циклов for
                        flag = 1;                                      // объединичиваем flag  для нелатинских квадратов
                    }
                    sum += mass[i * n + j];                         // прибавляем к sum очередной элемент строки
                }
                if (sum != summa)   // если сумма элементов в строке не равна нужной summa,
                {                      // то это не латинский квадрат (дальше делаем то же самое)
                    i = n;
                    j = n;
                    flag = 1;
                }
                sum = 0;              // обнуляем переменную sum
            }



            if (flag == 0)    // если в строках не обнаружено несоответствие, то проверяем столбцы
            {
                for (i = 0; i < n; i++)
                {
                    for (j = 0; j < n; j++)
                    {
                        if (mass[i + j * n] < 1 || mass[i + j * n] > n)   // если один из элементов столбца меньше 1 или больше n ,
                        {                                                 // то это не латинский квадрат,
                            i = n;                                          // приравниваем счётчики i и j к n,
                            j = n;                                          // что обеспечивает выход из циклов for
                            flag = 1;                                      // объединичиваем flag  для нелатинских квадратов
                        }
                        sum += mass[i + j * n];                         // прибавляем к sum очередной элемент строки
                    }
                    if (sum != summa)   // если сумма элементов в строке не равна нужной summa,
                    {                      // то это не латинский квадрат (дальше делаем то же самое)
                        i = n;
                        j = n;
                        flag = 1;
                    }
                    sum = 0;              // обнуляем переменную sum
                }
            }
            button1.Enabled = false;
            if(flag == 0)
            { MessageBox.Show("Верно. Данный квадрат является латинским!!", "Ответ", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else
            { MessageBox.Show("Неверно. Данный квадрат не является латинским!!", "Ответ", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            { MessageBox.Show("Латинский квадрат. Латинским квадратом порядка n называется квадратная таблица размером n х n ,каждая строка и каждый столбец которой содержат все числа от 1 до n. Проверить, является ли заданная целочисленная матрица латинским квадратом\nПроверка происходит путем подсчета суммы", "Задание", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                if (textBox1.Text.Length == 2 && textBox1.Text.Length <= 2)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Back)
                {
                    return;
                }
            }
            e.Handled = true;
        }
    }
}
