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
    public partial class Task19Page : Page
    {
        public Task19Page()
        {
            InitializeComponent();
        }
        private void BtnTask19_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbK.Text) && string.IsNullOrEmpty(TbY.Text) && string.IsNullOrEmpty(TbA.Text) && string.IsNullOrEmpty(TbB.Text) && string.IsNullOrEmpty(TbR.Text) && string.IsNullOrEmpty(TbX.Text))
            {
                MessageBox.Show("Нет данных!", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                //double G = Math.Exp(2 * Convert.ToDouble(TbD.Text)) + Math.Sin(Convert.ToDouble(Tbf.Text)) / Math.Log10(3.8 * Convert.ToDouble(TbY.Text) + Convert.ToDouble(Tbf.Text));
                MyTask19Class myTask19Class = new MyTask19Class(Convert.ToDouble(TbK.Text), Convert.ToDouble(TbY.Text), Convert.ToDouble(TbA.Text), Convert.ToDouble(TbB.Text), Convert.ToDouble(TbR.Text), Convert.ToDouble(TbX.Text));

                MessageBox.Show($"D = {myTask19Class.D()}", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

                TbK.Text = string.Empty;
                TbY.Text = string.Empty;
                TbA.Text = string.Empty;
                TbB.Text = string.Empty;
                TbR.Text = string.Empty;

            }
        }
    }
}