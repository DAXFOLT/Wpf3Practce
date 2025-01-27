using System;
using System.Windows;
using System.Windows.Controls;
using WpfApp6.TaskClasses;

namespace WpfApp6.View.Pages
{

    public partial class Task1Page : Page
    {
        public Task1Page()
        {
            InitializeComponent();
        }

        private void BtnTask1_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbX.Text) && string.IsNullOrEmpty(TbA.Text) && string.IsNullOrEmpty(TbC.Text))
            {
                MessageBox.Show("Нет данных!", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                //double G = Math.Exp(2 * Convert.ToDouble(TbY.Text)) + Math.Sin(Convert.ToDouble(Tbf.Text)) / Math.Log10(3.8 * Convert.ToDouble(TbY.Text) + Convert.ToDouble(Tbf.Text));
                MyTask1Class myTask1Class = new MyTask1Class(Convert.ToDouble(TbX.Text), Convert.ToDouble(TbA.Text), Convert.ToDouble(TbC.Text));

                MessageBox.Show($"L = {myTask1Class.L()}", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

                TbX.Text = string.Empty;
                TbA.Text = string.Empty;
                TbC.Text = string.Empty;
            }
        }
    }
}
