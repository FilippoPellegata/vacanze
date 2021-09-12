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

namespace QrWebCam.Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        biglietto biglietto;
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void camSelect_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            webCam.CameraIndex = camSelect.SelectedIndex;
        }

        private void QrWebCamControl_QrDecoded(object sender, string e)
        {
            biglietto = new biglietto();

            biglietto.fromQr(e);

            nome.Text = biglietto.Nome;
            cognome.Text = biglietto.Cognome;
            data.Text = biglietto.Data;
            sesso.Text = biglietto.Sesso;
            settore.Text = biglietto.Settore;
            fila.Text = biglietto.Fila;
            posto.Text = biglietto.Posto;

            if (biglietto.Settore == "1")
            {
                gate.Text = "entrare dal gate 1";
            }
            if (biglietto.Settore == "2")
            {
                gate.Text = "entrare dal gate 2";
            }
            if (biglietto.Settore == "3")
            {
                gate.Text = "entrare dal gate 3";
            }
            if (biglietto.Settore == "4")
            {
                gate.Text = "entrare dal gate 4";
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            camSelect.ItemsSource = webCam.CameraNames;
        }

        private void gateB_Click(object sender, RoutedEventArgs e)
        {
            if (gate.Text == "")
            {
                MessageBox.Show("Non hai ancora passato il controllo del qr");
            }
            else if (biglietto.Settore == "1")
            {
                gateUno a = new gateUno();
                a.Show();
                this.Hide();
            }
            else if (biglietto.Settore == "2")
            {
                gateDue a = new gateDue();
                a.Show();
                this.Hide();
            }
            else if (biglietto.Settore == "3")
            {
                gateTre a = new gateTre();
                a.Show();
                this.Hide();
            }
            else if (biglietto.Settore == "4")
            {
                gateQuattro a = new gateQuattro();
                a.Show();
                this.Hide();
            }
            
        }
    }
}
