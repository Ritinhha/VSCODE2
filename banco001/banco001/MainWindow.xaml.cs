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

namespace banco001
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Nbanco nbanco = new Nbanco();
            listabanco.ItemsSource = nbanco.listar();
        }

        private void cadastraclientenobanco_Click(object sender, RoutedEventArgs e)
        {
            Window1 cliente = new Window1();
            cliente.ShowDialog();
        }

        private void inserirbanco_Click(object sender, RoutedEventArgs e)
        {
            Nbanco nbanco = new Nbanco();

            Banco bancoNovo = new Banco();

            try
            {
                bancoNovo.idbanco = nbanco.listar().Last().idbanco + 1;
            }
            catch
            {
                bancoNovo.idbanco = 1;
            }

            bancoNovo.nomebanco = nomebanco.Text;
            bancoNovo.numerobanco = numerobanco.Text;
            bancoNovo.telbanco = tellbanco.Text;

            nbanco.inserir(bancoNovo);

            listabanco.ItemsSource = nbanco.listar();
            nomebanco.Text = "";
            numerobanco.Text = "";
            tellbanco.Text = "";
        }

        private void bancos_Click(object sender, RoutedEventArgs e)
        {
            Nbanco nbanco = new Nbanco();

            List<Banco> bancos = nbanco.listar();

            listabanco.ItemsSource = bancos;
        }

        private void listabanco_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Banco bancoNovo = new Banco();
            bancoNovo = listabanco.SelectedItem as Banco;

            if(bancoNovo != null)
            {
              
                nomebanco.Text = bancoNovo.nomebanco;
                numerobanco.Text = bancoNovo.numerobanco;
                tellbanco.Text = bancoNovo.telbanco;
            }
        }

        private void atualizarbanco_Click(object sender, RoutedEventArgs e)
        {
            Nbanco nbanco = new Nbanco();

            Banco bancoAntigo = listabanco.SelectedItem as Banco;
            Banco bancoNovo = new Banco();

            bancoNovo.idbanco = bancoAntigo.idbanco;
            bancoNovo.nomebanco = nomebanco.Text;
            bancoNovo.numerobanco = numerobanco.Text;
            bancoNovo.telbanco = tellbanco.Text;

            nbanco.Atualizar(bancoNovo);

            nomebanco.Text = "";
            numerobanco.Text = "";
            tellbanco.Text = "";

            List<Banco> bancos = nbanco.listar();

            listabanco.ItemsSource = bancos;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Nbanco nbanco = new Nbanco();

            Banco bancoToRemove = listabanco.SelectedItem as Banco;

            nbanco.excluir(bancoToRemove);

            nomebanco.Text = "";
            numerobanco.Text = "";
            tellbanco.Text = "";

            List<Banco> bancos = nbanco.listar();

            listabanco.ItemsSource = bancos;
        }
    }
}
