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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       //List<ToDo> strList { get; set; }

        
        public MainWindow()
        {
            InitializeComponent();
            List<ToDo> strList = new List<ToDo>();
            strList.Add(new ToDo("Приготовить покушать", "Нет описания", new DateTime (2024, 01, 15)));
            strList.Add(new ToDo("Поработать", "Съездить на совещание в Москву", new DateTime(2024, 01, 20)));
            strList.Add(new ToDo("Отдохнуть", "Съездить в отпуск в Сочи", new DateTime(2024, 02, 01)));
            DataGridProduct.ItemsSource = strList;
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        { }

            /** private void Button_Click(object sender, RoutedEventArgs e)
             {
                 if (DataGridProduct.SelectedItem != null)
                 {
                     var selecteditem = DataGridProduct.SelectedItem as ToDo;

                     if (selecteditem != null)
                     {
                         strList.Remove(selecteditem);

                         DataGridProduct.ItemsSource = null;
                         DataGridProduct.ItemsSource = strList;

                     }
                 }
             }**/

        }
}
