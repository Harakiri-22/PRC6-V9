using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PRC6_V9
{
    class Triad
    {
        private int _first;
        private int _second;
        private int _third;

        public int First
        {
            get => _first;

            set
            {
                if (value % 2 == 1)
                {
                    _first = value;
                }
                else
                {
                    MessageBox.Show("Ошибка, введено четное число");
                }
            }
        }

        public int Second
        {
            get => _second;

            set
            {
                if (value % 2 == 1)
                {
                    _second = value;
                }
                else
                {
                    MessageBox.Show("Ошибка, введено четное число");
                }
            }
        }

        public int Third
        {
            get => _third;

            set
            {
                if (value % 2 == 1)
                {
                    _third = value;
                }
                else
                {
                    MessageBox.Show("Ошибка, введено четное число");
                }
            }
        }

        public static bool Compare(int one, int two, int three, int first, int second, int third)
        {
            bool result = one == first && two == second && three == third;
            return result;
        }

        public static void Compare(int one, int two, int three, int first, int second, int third, int oneFirst, int twoSecond, int threeThird, out bool resultOne, out bool resultTwo)
        {
            resultOne = one == first && two == second && three == third;

            resultTwo = first == oneFirst && second == twoSecond && third == threeThird;
        }
    }
}
