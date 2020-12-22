using Scuola;
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

namespace AcqustiLibriStudenti
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
        List<Studenti> studente = new List<Studenti>();
        List<Libri> libro = new List<Libri>();

        int matricola = 1;
        int i = 1;

        private void btnCaricaStudente_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txtNome.Text == "" || txtCognome.Text == "")
                {
                    MessageBox.Show("Inserire tutti i valori", "", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    txtNome.Text = "";
                    txtCognome.Text = "";
                    txtNome.Focus();
                }
                else
                {
                    string nome = txtNome.Text;
                    string cognome = txtCognome.Text;
                    Studenti s= new Studenti(nome, cognome,1);
                    studente.Add(s);
                    cmbStudenti.Items.Add(s.GetMatricola());
                    matricola++;
                    txtNome.Text = "";
                    txtCognome.Text = "";
                    txtNome.Focus();
                    cmbStudenti.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtNome.Text = "";
                txtCognome.Text = "";
                txtNome.Focus();
            }
        }

        private void btnCaricaLibro_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (cmbMateria.Text == "" || txtPrezzo.Text == "")
                {
                    MessageBox.Show("Inserire tutti i valori", "", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    cmbMateria.Text = "";
                    txtPrezzo.Text = "";
                    cmbMateria.Focus();
                }
                else
                {
                    string materia = cmbMateria.Text;
                    double prezzo = double.Parse(txtPrezzo.Text);
                    string isbn = "libr2020" + i.ToString();
                    i++;
                    Libri l = new Libri(materia, prezzo, isbn);
                    libro.Add(l);
                    cmbLibri.Items.Add(l.GetISBN());
                    cmbMateria.Text = "";
                    txtPrezzo.Text = "";
                    cmbMateria.Focus();
                    cmbLibri.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cmbMateria.Text = "";
                txtPrezzo.Text = "";
                cmbMateria.Focus();
            }
        }

       

        private void btnRegistraAcquisto_Click(object sender, RoutedEventArgs e)
        {
            int indexS = cmbStudenti.SelectedIndex;
            int indexL = cmbLibri.SelectedIndex;
            if (indexS == -1 || indexL == -1)
            {
                MessageBox.Show("Selezionare studente e libro!", "", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else
            {
                lsbRisultato.Items.Add($"{studente[indexS].Presentati()} acquista {libro[indexL].GetDescrizione()}.");
                cmbStudenti.SelectedIndex = -1;
                cmbLibri.SelectedIndex = -1;
            }
        }

        private void btnCancella_Click(object sender, RoutedEventArgs e)
        {
                lsbRisultato.Items.Clear();
            
        }
        private void btnEsci_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

