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
using System.Windows.Threading;

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
        DispatcherTimer timer;
        Rectangle coordinates = new Rectangle();
        File sizeFile = new File();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            timer = new DispatcherTimer();
            timer.Tick += Timer_Tick;
            timer.Interval = new TimeSpan(0, 0, 0, 1, 0);
            timer.IsEnabled = true;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            time.Text = d.ToString("HH:mm:ss");
            data.Text = d.ToString("dd:MM:yyyy");
        }

        private void Square_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                coordinates.X1 = Convert.ToInt32(x1.Text);
                coordinates.X2 = Convert.ToInt32(x2.Text);
                coordinates.Y1 = Convert.ToInt32(y1.Text);
                coordinates.Y2 = Convert.ToInt32(y2.Text);
                resultSquare.Text = coordinates.Square().ToString();
            }
            catch
            {
                MessageBox.Show("Неверные данные", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Perimetr_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                coordinates.X1 = Convert.ToInt32(x1.Text);
                coordinates.X2 = Convert.ToInt32(x2.Text);
                coordinates.Y1 = Convert.ToInt32(y1.Text);
                coordinates.Y2 = Convert.ToInt32(y2.Text);
                resultPerimetr.Text = coordinates.Perimetr().ToString();
            }
            catch
            {
                MessageBox.Show("Неверные данные", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void CalculateSizeKilobytes_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                sizeFile.SizeBytes = Convert.ToInt32(size.Text);
                result.Text = sizeFile.CalculateSizeKilobytes().ToString();
            }
            catch
            {
                MessageBox.Show("Неверные данные", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            x1.Focus();
            Square_Click(sender, e);
            Perimetr_Click(sender, e);
            CalculateSizeKilobytes_Click(sender, e);
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            x1.Clear();
            x2.Clear();
            y1.Clear();
            y2.Clear();
            resultSquare.Clear();
            resultPerimetr.Clear();
            size.Clear();
            result.Clear();
        }

        private void Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Практическая работа №12 Вариант 11\nВыполнил студент группы ИСП-31 Обухов Сергей\nЗадание\n•Даны координаты двух противоположных вершин прямоугольника: (x1, y1), (x2, y2).Стороны прямоугольника параллельны осям координат. Найти периметр и площадь данного прямоугольника.\n• Дан размер файла в байтах.Используя операцию деления нацело, найти количество полных килобайтов, которые занимает данный файл(1 килобайт = 1024 байта).", "Доп.Информация", MessageBoxButton.OK, MessageBoxImage.Question);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void size_TextChanged(object sender, TextChangedEventArgs e)
        {
            result.Clear();
        }

        private void x1_TextChanged(object sender, TextChangedEventArgs e)
        {
            resultSquare.Clear();
            resultPerimetr.Clear();
        }

        private void y1_TextChanged(object sender, TextChangedEventArgs e)
        {
            resultSquare.Clear();
            resultPerimetr.Clear();
        }

        private void x2_TextChanged(object sender, TextChangedEventArgs e)
        {
            resultSquare.Clear();
            resultPerimetr.Clear();
        }

        private void y2_TextChanged(object sender, TextChangedEventArgs e)
        {
            resultSquare.Clear();
            resultPerimetr.Clear();
        }
        private void InfoFirstData_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Здесь необходимо ввести координаты противоположных вершин прямоугольника", "Сведения о данных первого блока", MessageBoxButton.OK, MessageBoxImage.Asterisk);
        }

        private void InfoFirstResult_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("При нажатии на кнопку 'Рассчитать площадь' производится расчет площади прямоугольника и ответ выводится в соответствующее поле\nПри нажатии на кнопку 'Рассчитать периметр' производится расчет периметра прямоугольника и ответ выводится в соответствующее поле", "Сведения о результате первого блока", MessageBoxButton.OK, MessageBoxImage.Asterisk);
        }

        private void InfoSecondData_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Здесь необходимо ввести размер файла в байтах", "Сведения о данных второго блока", MessageBoxButton.OK, MessageBoxImage.Asterisk);
        }
        private void InfoSecondResult_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("При нажатии на кнопку 'Выделить Килобайты' производится деление размера файла в байтах на 1024 и ответ выводится в соответствующее поле", "Сведения о результате второго блока", MessageBoxButton.OK, MessageBoxImage.Asterisk);
        }
    }
}
