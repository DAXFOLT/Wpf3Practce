﻿using System;
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
    /// Логика взаимодействия для Task21Page.xaml
    /// </summary>
    public partial class Task21Page : Page
    {
        public Task21Page()
        {
            InitializeComponent();
        }
        private void BtnTask21_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbZ.Text) && string.IsNullOrEmpty(TbX.Text) && string.IsNullOrEmpty(TbA.Text))
            {
                MessageBox.Show("Нет данных!", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                //double G = Math.Exp(2 * Convert.ToDouble(TbD.Text)) + Math.Sin(Convert.ToDouble(Tbf.Text)) / Math.Log10(3.8 * Convert.ToDouble(TbY.Text) + Convert.ToDouble(Tbf.Text));
                MyTask21Class myTask21Class = new MyTask21Class(Convert.ToDouble(TbZ.Text), Convert.ToDouble(TbX.Text), Convert.ToDouble(TbA.Text));

                MessageBox.Show($"Q = {myTask21Class.N()}", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

                TbZ.Text = string.Empty;
                TbX.Text = string.Empty;
                TbA.Text = string.Empty;
               
            }
        }
    }
}