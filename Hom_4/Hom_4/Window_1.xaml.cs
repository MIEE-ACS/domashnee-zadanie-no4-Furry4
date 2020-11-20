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
using System.Windows.Shapes;

namespace Hom_4
{
    /// <summary>
    /// Логика взаимодействия для Input.xaml
    /// </summary>
    public partial class Window_1 : Window
    {
        
        public Window_1()
        {
            InitializeComponent();

        }

        private void bt_Win_1(object sender, RoutedEventArgs e)

        {
            int number = 1;

            bool check = int.TryParse(tb_Win_1.Text, out number);

            if (check == false || int.Parse(tb_Win_1.Text) <= 0)
            {
                MessageBox.Show("Введите целое число больше нуля!");
            }
            else if (int.Parse(tb_Win_1.Text) > 10)
            {
                MessageBox.Show("Введите число поменьше!");
            }
            else
            {
                if (tb_Win_2.Text == "")
                { MessageBox.Show("Отлично! Теперь введи - k"); }
                else
                {
                    int num = 1;
                    bool ch = int.TryParse(tb_Win_2.Text, out num);
                    if (check == false || int.Parse(tb_Win_2.Text) <= 0)
                    {
                        MessageBox.Show("Введите целое k больше нуля!");
                    }
                    else
                    {
                        if (int.Parse(tb_Win_2.Text) > int.Parse(tb_Win_1.Text))
                        {
                            MessageBox.Show("Введите k в границах массива!");
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                }
            }
        }
        private void bt_Win_2(object sender, RoutedEventArgs e)
        {
            int number = 1;

            bool check = int.TryParse(tb_Win_2.Text, out number);

            if (check == false || int.Parse(tb_Win_2.Text) <= 0)
            {
                MessageBox.Show("Введите целое число больше нуля!");
            }
            else
            {
                if (int.Parse(tb_Win_2.Text) > int.Parse(tb_Win_1.Text))
                {
                    MessageBox.Show("Введите число в границах массива!");
                }
                else
                {
                    this.Close();
                }
            }
        }

    }
}
