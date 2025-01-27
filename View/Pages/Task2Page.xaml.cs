using System;
using System.Windows;
using System.Windows.Controls;
using WpfApp6.TaskClasses;

namespace WpfApp6.View.Pages
{
    
    public partial class Task2Page : Page
    {
        public Task2Page()
        {
            InitializeComponent();
        }

        private void BtnTask2_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbC.Text) && string.IsNullOrEmpty(TbX.Text) && string.IsNullOrEmpty(TbT.Text))
            {
                MessageBox.Show("Нет данных!", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                //double F = 3.5 * Math.Pow(TbD,2) + 1) / Math.Cos(2 * TbY);
                MyTask2Class myTask2Class = new MyTask2Class(Convert.ToDouble(TbC.Text), Convert.ToDouble(TbX.Text), Convert.ToDouble(TbT.Text));

                MessageBox.Show($"L = {myTask2Class.L()}", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

                TbT.Text = string.Empty;
                TbX.Text = string.Empty;
                TbC.Text = string.Empty;
            }
        }
    }
}
