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
using System.Text.RegularExpressions;

namespace WpfApp1
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

        public bool Calculate(string firstT, string secondT, string thirdT)
        {
            string firstModule = firstT;
            string secondModule = secondT;
            string thirdModule = thirdT;

            string pattern = "^(0|[1-9]\\d*)$";
            Regex regex = new Regex(pattern);

            if (!(string.IsNullOrWhiteSpace(firstModule) && string.IsNullOrWhiteSpace(secondModule) && string.IsNullOrWhiteSpace(thirdModule)))
            {
                if (regex.IsMatch(firstModule) && regex.IsMatch(secondModule) && regex.IsMatch(thirdModule))
                {
                    int first = int.Parse(firstModule);
                    int second = int.Parse(secondModule);
                    int third = int.Parse(thirdModule);

                    if (first <= 22 && second <= 38 && third <= 20)
                    {
                        int res = first + second + third;
                        Summ.Text = $"{res}";

                        if (res >= 0 && res <= 15) Result.Text = "2";
                        else if (res >= 16 && res <= 31) Result.Text = "3";
                        else if (res >= 32 && res <= 55) Result.Text = "4";
                        else Result.Text = "5";
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Превышено максимальное количество баллов за модуль!");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Вводите только положительные целые числа!");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Введите баллы за все модули!");
                return false;

            }
        }

        private void CalculateResult_Click(object sender, RoutedEventArgs e)
        {
            Calculate(FirstModule.Text, SecondModule.Text, ThirdModule.Text);
        }
    }
}
