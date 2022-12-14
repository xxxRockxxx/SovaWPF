using Microsoft.Win32;
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

namespace SovovaWPF
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = @"C:\Users\MSI\Desktop";
            sfd.RestoreDirectory = true;
            sfd.FileName = "База данных";
            sfd.DefaultExt = "txt";
            sfd.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (sfd.ShowDialog()==DialogResult.HasValue)
            {
                return;
            }

            //saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            ////string Data = "";

            //if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
            //{
            //    return;
            //}

            //string path = saveFileDialog1.FileName;
            //string text = "";
            //File.WriteAllText(path, text);
            //saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            //if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
            //    return;
            //string filename= saveFileDialog1.FileName;
        }
    }
}
