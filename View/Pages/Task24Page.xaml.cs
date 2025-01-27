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

namespace WpfApp6
{
    /// <summary>
    /// Логика взаимодействия для Task24Page.xaml
    /// </summary>
    public partial class Task24Page : Page
    {
        public Task24Page()
        {
            InitializeComponent();
        }
        private void BtnTask24_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbZ.Text) && string.IsNullOrEmpty(TbB.Text) && string.IsNullOrEmpty(TbA.Text) && string.IsNullOrEmpty(TbX.Text))
            {
                MessageBox.Show("Нет данных!", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                //double G = Math.Exp(2 * Convert.ToDouble(TbD.Text)) + Math.Sin(Convert.ToDouble(Tbf.Text)) / Math.Log10(3.8 * Convert.ToDouble(TbY.Text) + Convert.ToDouble(Tbf.Text));
                MyTask24Class myTask24Class = new MyTask24Class(Convert.ToDouble(TbZ.Text), Convert.ToDouble(TbB.Text), Convert.ToDouble(TbA.Text), Convert.ToDouble(TbX.Text));

                MessageBox.Show($"F = {myTask24Class.F()}", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

                TbZ.Text = string.Empty;
                TbB.Text = string.Empty;
                TbA.Text = string.Empty;
                TbX.Text = string.Empty;
            }
        }
    }
}
