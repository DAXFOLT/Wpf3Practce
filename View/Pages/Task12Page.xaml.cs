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
    /// Логика взаимодействия для Task12Page.xaml
    /// </summary>
    public partial class Task12Page : Page
    {
        public Task12Page()
        {
            InitializeComponent();
        }
        private void BtnTask12_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbY.Text) && string.IsNullOrEmpty(TbX.Text) && string.IsNullOrEmpty(TbA.Text))
            {
                MessageBox.Show("Нет данных!", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                //double G = Math.Exp(2 * Convert.ToDouble(TbD.Text)) + Math.Sin(Convert.ToDouble(Tbf.Text)) / Math.Log10(3.8 * Convert.ToDouble(TbY.Text) + Convert.ToDouble(Tbf.Text));
                MyTask12Class myTask12Class = new MyTask12Class(Convert.ToDouble(TbY.Text), Convert.ToDouble(TbX.Text), Convert.ToDouble(TbA.Text));

                MessageBox.Show($"G = {myTask12Class.G()}", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

                TbY.Text = string.Empty;
                TbX.Text = string.Empty;
                TbA.Text = string.Empty;
            }
        }
    }
}
