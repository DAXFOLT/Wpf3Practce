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
    /// Логика взаимодействия для Task20Page.xaml
    /// </summary>
    public partial class Task20Page : Page
    {
        public Task20Page()
        {
            InitializeComponent();
        }
        private void BtnTask20_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbY.Text) && string.IsNullOrEmpty(TbX.Text) && string.IsNullOrEmpty(TbB.Text) && string.IsNullOrEmpty(TbC.Text) && string.IsNullOrEmpty(TbA.Text))
            {
                MessageBox.Show("Нет данных!", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                //double G = Math.Exp(2 * Convert.ToDouble(TbD.Text)) + Math.Sin(Convert.ToDouble(Tbf.Text)) / Math.Log10(3.8 * Convert.ToDouble(TbY.Text) + Convert.ToDouble(Tbf.Text));
                MyTask20Class myTask20Class = new MyTask20Class(Convert.ToDouble(TbY.Text), Convert.ToDouble(TbX.Text), Convert.ToDouble(TbB),  Convert.ToDouble(TbC.Text), Convert.ToDouble(TbA.Text));

                MessageBox.Show($"K = {myTask20Class.U()}", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

                TbX.Text = string.Empty;
                TbY.Text = string.Empty;
                TbB.Text = string.Empty;
                TbC.Text = string.Empty;
                TbA.Text = string.Empty;
            }
}   }   }
