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
using System.IO.Compression;
using Microsoft.Win32;
using System.IO;

namespace FreeRar
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnArchive_Click(object sender, RoutedEventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Выбор файлов";
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            ListBox listBox = new ListBox();


            if (openFileDialog.ShowDialog() == true)

            {
                foreach (string filename in openFileDialog.FileNames)
                {

                    listBox.Items.Add(System.IO.Path.GetFileName(filename));

                }    

            }


        }

        private void BtnUnArchive_Click(object sender, RoutedEventArgs e)
        {



        }

        private void MenuItemExit_Click(object sender, RoutedEventArgs e) //Shutdown the application
        {

            Application.Current.Shutdown();

        }
    }
}
