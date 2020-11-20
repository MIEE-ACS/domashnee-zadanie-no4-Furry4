using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Hom_4
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void func_1(int value)
        {
            int zeros = 0;

            double[] mass = new double[value];
            Random rand = new Random();

            for (int i = 0; i < value; i++)
            {
                double rand_1 = rand.NextDouble();

                mass[i] = Math.Round((double)rand.Next(-100, 100) / 10, 1);
                Out.Text = Out.Text + mass[i] + "   ";

                if (mass[i] == 0)
                {
                    zeros++;
                }
            }

            double min = mass[0];
            int index = 0;
            double sum = 0;
            for (int i = 0; i < value; i++)
            {
                if (mass[i] < min)
                {
                    min = mass[i];
                    index = i;
                }
            }
            for (int i = 0; i < value; i++)
            {
                if (i > index)
                {
                    sum += mass[i];
                }
            }

            Array.Sort(mass);

            Out_Ans_1.Text = "Отсортированный массив: " + "\r\n";

            for (int i = 0; i < value; i++)
            {
                Out_Ans_1.Text = Out_Ans_1.Text + mass[i] + "    ";
            }

            Out_Ans_2.Text = "Сумма элементов массива, расположенных после минимального элемента: " + sum + "\r\n" + "Количество нулей в массиве: " + zeros;

        }

        private void func_2(int value, int value_k)
        {
            int M, MM, shift_1, shift_2, shift_3;

            
            Random rand = new Random();
            int[,] mass = new int[value, value];
            for (int i = 0; i < value; i++)
            {
                for (M = 0; M < value; M++)
                {
                    int rand_2 = rand.Next(10);
                    mass[i, M] += rand_2;
                    Out.Text = Out.Text + mass[i, M] + "    ";
                }
                Out.Text = Out.Text + "\r\n";
            }
            
            for (int i = 0; i < value / 2; i++)
            {
                for (int z = value_k; z > 0; z--)
                {
                    for (M = i, shift_1 = mass[i, M]; M < value - 1 - i; M++)
                    {
                        shift_2 = mass[i, M + 1];
                        mass[i, M + 1] = shift_1;
                        shift_1 = shift_2;
                    }
                    for (MM = i + 1; MM < value - i; MM++)
                    {
                        shift_3 = shift_1;
                        shift_1 = mass[MM, M];
                        mass[MM, M] = shift_3;
                    }
                    for (M--, MM--; M >= i; M--)
                    {
                        shift_3 = shift_1;
                        shift_1 = mass[MM, M];
                        mass[MM, M] = shift_3;
                    }

                    for (M++, MM--; MM >= i; MM--)
                    {
                        shift_3 = shift_1;
                        shift_1 = mass[MM, M];
                        mass[MM, M] = shift_3;
                    }
                }
            }
            for (int i = 0; i < value; i++)
            {
                for (M = 0; M < value; M++)
                    Out_Ans_1.Text = Out_Ans_1.Text + mass[i, M] + "    ";
                    Out_Ans_1.Text = Out_Ans_1.Text + "\r\n";
            }
            
        }
        

        private void bt_1_Click(object sender, RoutedEventArgs e)
        {
            Window_Inp Win_1 = new Window_Inp();
            Window_1 Win_2 = new Window_1();

            if (tb_1.Text == "1")
            {

                Win_1.ShowDialog();

                int value = int.Parse(Win_1.tb_Inp.Text);

                Out.Text = "";
                Out_Ans_1.Text = "";
                Out_Ans_2.Text = "";

                func_1(value);

            }
            else if (tb_1.Text == "2")
            {
                Win_2.ShowDialog();

                int value = int.Parse(Win_2.tb_Win_1.Text);
                int value_k = int.Parse(Win_2.tb_Win_2.Text);

                Out.Text = "";
                Out_Ans_1.Text = "";
                Out_Ans_2.Text = "";

                func_2(value, value_k);
                Out_Ans_2.Text = "Спасибо за то, что использовали мою программу!\nВы можете меня поддержать, если поставите автомат)";
            }
            else
            {
                MessageBox.Show("Введите число для составления массивов!");
            }

        }
    }
    
}
