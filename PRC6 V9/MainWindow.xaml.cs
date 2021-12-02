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

namespace PRC6_V9
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Information_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Выполнил Мишин Д.А. ИСП-34", "О программе", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void ComparisonTwo_Click(object sender, RoutedEventArgs e)
        {
            Triad triadOne = new Triad
            {
                First = Convert.ToInt32(a1.Text),
                Second = Convert.ToInt32(a2.Text),
                Third = Convert.ToInt32(a3.Text)
            };

            Triad triadTwo = new Triad
            {
                First = Convert.ToInt32(aa1.Text),
                Second = Convert.ToInt32(aa2.Text),
                Third = Convert.ToInt32(aa3.Text)
            };

            bool result;
            result = Triad.Compare(triadOne.First, triadOne.Second, triadOne.Third, triadTwo.First, triadTwo.Second, triadTwo.Third);

            if (result == true)
            {
                MessageBox.Show("Триады равны");
            }
            else
            {
                MessageBox.Show("Триады неравны");
            }
        }

        private void ComparisonThree_Click(object sender, RoutedEventArgs e)
        {
            Triad triadOne = new Triad
            {
                First = Convert.ToInt32(a1.Text),
                Second = Convert.ToInt32(a2.Text),
                Third = Convert.ToInt32(a3.Text)
            };

            Triad triadTwo = new Triad
            {
                First = Convert.ToInt32(aa1.Text),
                Second = Convert.ToInt32(aa2.Text),
                Third = Convert.ToInt32(aa3.Text)
            };

            Triad triadThree = new Triad
            {
                First = Convert.ToInt32(aaa1.Text),
                Second = Convert.ToInt32(aaa2.Text),
                Third = Convert.ToInt32(aaa3.Text)
            };

            Triad.Compare(triadOne.First, triadOne.Second, triadOne.Third, triadTwo.First, triadTwo.Second, triadTwo.Third, triadThree.First, triadThree.Second, triadThree.Third, out bool resultOne, out bool resultThree);

            if (resultOne == true && resultThree == true)
            {
                MessageBox.Show("Все триады равны");
            }

            if (resultOne == true && resultThree == false)
            {
                MessageBox.Show("Триада №2 и Триада №3 не равны");
            }

            if (resultOne == false && resultThree == true)
            {
                MessageBox.Show("Триада №1 и Триада №3 не равны");
            }

            if (resultOne == false && resultThree == false)
            {
                MessageBox.Show("Все триады не равны");
            }
        }
    }
}
