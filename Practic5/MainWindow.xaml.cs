using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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
using static Lib_5.Pair;

namespace Practic5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик: Мелехин Дмитрий. Задание: Создать базовый класс Саr (машина), характеризуемый торговой маркой (строка), числом цилиндров, мощностью. Создать необходимые методы и свойства. Создать перегруженные методы SetParams, для установки параметров автомобиля.");
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Car_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Авто в наличии: 1 - Audi, 2 - BMW, 3 - Ford, 4 - Mazda, 5 - Toyota, 6 - Lada");
        }


        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        //вызов класса и вывод
        Car calc = new Car();

        //новые параметры
        private void Calc1_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(Stamp.Text, out int st)
            || !int.TryParse(Cylinders.Text, out int cy)
            || !int.TryParse(Power.Text, out int po))
            {
                MessageBox.Show("Введите параметры и номер машины!");
                return;
            }
            if (st < 7)
            {
                //параметры машины
                st = Convert.ToInt32(Stamp.Text);
                cy = Convert.ToInt32(Cylinders.Text);
                po = Convert.ToInt32(Power.Text);

                calc.SetParams(st, cy, po);
                Stamp_Copy.Text = st.ToString();
                Cylinders_Copy.Text = cy.ToString();
                Power_Copy.Text = po.ToString();
            }
            else
                MessageBox.Show("Такой марки машины не существует");
        }

        //открыть 
        private void Calc2_Click(object sender, RoutedEventArgs e)
        {
            bool f1 = int.TryParse(Stamp.Text, out int st);
            bool f2 = int.TryParse(Cylinders.Text, out int cy);
            bool f3 = int.TryParse(Power.Text, out int po);

            if (f1 == true && f2 == true && f3 == true)
            {
                if (st > 0 && cy > 0 && po > 0)
                {
                        //параметры машины
                        calc.GetParams(out st, out cy, out po);
                        Stamp.Text = st.ToString();
                        Cylinders.Text = cy.ToString();
                        Power.Text = po.ToString();
                }
                else
                    MessageBox.Show("Введите число больше 0");
            }
            else
                MessageBox.Show("Я люблю числа, а не буквы");
        }
        //результат
        private void Rez_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(Stamp_Copy.Text, out int st)
            || !int.TryParse(Cylinders_Copy.Text, out int cy)
            || !int.TryParse(Power_Copy.Text, out int po))
            {
                MessageBox.Show("Заполните параметры!");
                return;
            }

        }
    }
}

