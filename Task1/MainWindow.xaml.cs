﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckedOutButton_Click(object sender, RoutedEventArgs e)
        {
            string checkedItems = "";
            foreach (CheckBox item in CheckedListBox.Items)
            {
                if (item.IsChecked == true)
                    checkedItems += $"{item.Content}, ";
            }

            MessageBox.Show("Выбранные элементы: " + checkedItems);
        }
    }
}