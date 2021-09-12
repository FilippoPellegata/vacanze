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
using System.Windows.Shapes;

namespace QrWebCam.Demo
{
    /// <summary>
    /// Logica di interazione per gateQuattro.xaml
    /// </summary>
    public partial class gateQuattro : Window
    {
        public gateQuattro()
        {
            InitializeComponent();
        }

        private void home_Click(object sender, RoutedEventArgs e)
        {
            MainWindow a = new MainWindow();
            a.Show();
            this.Hide();
        }
    }
}
