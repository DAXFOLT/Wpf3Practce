using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp6
{
    /// <summary>
    /// Логика взаимодействия для Task3Page.xaml
    /// </summary>
    public partial class Task3Page : Page
    {
        public Task3Page()
        {
            InitializeComponent();
        }
        private void BtnTask3_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbH.Text) && string.IsNullOrEmpty(TbY.Text))
            {
                MessageBox.Show("Нет данных!", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                //double G = Math.Exp(2 * Convert.ToDouble(TbD.Text)) + Math.Sin(Convert.ToDouble(Tbf.Text)) / Math.Log10(3.8 * Convert.ToDouble(TbY.Text) + Convert.ToDouble(Tbf.Text));
                MyTask3Class myTask3Class = new MyTask3Class(Convert.ToDouble(TbH.Text), Convert.ToDouble(TbY.Text));

                MessageBox.Show($"A = {myTask3Class.A()}", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

                TbH.Text = string.Empty;
                TbY.Text = string.Empty;
            }
        }
    }
}
