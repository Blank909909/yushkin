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

        private void bak(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" Найти произведение n целых случайных чисел X., распределенных в диапазоне от 0 до n. Вывести на экран на одной строке сгенерированные числа, на другой строке результат.");
            //Что происходит в программе
        }

        private void back(object sender, RoutedEventArgs e)
        {
            Close();
            //Выход из программы
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           listBox1.Items.Clear();
            //Очистить список
        }

        private void pusk_Click(object sender, RoutedEventArgs e)
        {
            //Создаем объект рандома
            Random rnd = new Random();
            //Получаем колл. значений
            int i,n = Convert.ToInt32(max.Text);
            //Заполняем список случайными занчениями
            for (i =1; i <= n; i++)
            {
                listBox1.Items.Add(rnd.Next(1,20));
            }
        }
        //Рассчет по заданию
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int i, sum;
            sum = 1;
            //Переумножаем элемнты списка
            for (i = 0; i < listBox1.Items.Count; i++)
            {
                sum = sum * Convert.ToInt32(listBox1.Items[i]);
                //Выводим ответ
                otv.Text = sum.ToString();
            }
        }
    }
}
