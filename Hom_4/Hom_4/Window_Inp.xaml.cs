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
    public partial class Window_Inp : Window
    {
        
        public Window_Inp()
        {
            InitializeComponent();

        }

        private void bt_Inp_Click(object sender, RoutedEventArgs e)

        {
            int number = 1;

            bool check = int.TryParse(tb_Inp.Text, out number);

            if (check == false || int.Parse(tb_Inp.Text) <= 0 || int.Parse(tb_Inp.Text) > 50)
            {
                MessageBox.Show("Введите целое число больше нуля, но меньше 50!");
            }
            else
            {
                this.Close();
            }
        }

    }
}
