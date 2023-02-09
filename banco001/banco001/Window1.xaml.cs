using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace banco001
{
    /// <summary>
    /// Lógica interna para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            Ncliente ncliente = new Ncliente();
            listaClientes.ItemsSource = ncliente.listar();
        }

        private void cadastraclientenaconta_Click(object sender, RoutedEventArgs e)
        {
            Window2 conta = new Window2();
            conta.ShowDialog();
        }

        private void inserircliente_Click(object sender, RoutedEventArgs e)
        {
            Ncliente ncliente = new Ncliente();

            Cliente clienteNovo = new Cliente();

            try
            {
                clienteNovo.idCliente = ncliente.listar().Last().idCliente + 1;
            }
            catch
            {
                clienteNovo.idCliente = 1;
            }

            clienteNovo.nomecliente = nomecliente.Text;
            clienteNovo.cpf = cpfcliente.Text;
            clienteNovo.tel = tell.Text;
            clienteNovo.datanascimento = datanascimento.Text;

            ncliente.inserir(clienteNovo);

            listaClientes.ItemsSource = ncliente.listar();

            nomecliente.Text = "";
            cpfcliente.Text = "";
            tell.Text = "";
            datanascimento.Text = "";
        }

        private void atualizarcliente_Click(object sender, RoutedEventArgs e)
        {
            Ncliente ncliente = new Ncliente();

            Cliente clienteAntigo = listaClientes.SelectedItem as Cliente;
            Cliente clienteNovo = new Cliente();

            clienteNovo.idCliente = clienteAntigo.idCliente;
            clienteNovo.nomecliente = nomecliente.Text;
            clienteNovo.cpf = cpfcliente.Text;
            clienteNovo.tel = tell.Text;
            clienteNovo.datanascimento = datanascimento.Text;

            ncliente.Atualizar(clienteNovo);

            listaClientes.ItemsSource = ncliente.listar();

            nomecliente.Text = "";
            cpfcliente.Text = "";
            tell.Text = "";
            datanascimento.Text = "";
        }

        private void listaClientes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Cliente clienteNovo = new Cliente();
            clienteNovo = listaClientes.SelectedItem as Cliente;
            if (clienteNovo != null)
            {
                nomecliente.Text = clienteNovo.nomecliente;
                cpfcliente.Text = clienteNovo.cpf;
                tell.Text = clienteNovo.tel;
                datanascimento.Text = clienteNovo.datanascimento;
            }
        }

        private void excluircliente_Click(object sender, RoutedEventArgs e)
        {
            Ncliente ncliente = new Ncliente();

            Cliente clienteToRemove = listaClientes.SelectedItem as Cliente;

            ncliente.excluir(clienteToRemove);

            nomecliente.Text = "";
            cpfcliente.Text = "";
            tell.Text = "";
            datanascimento.Text = "";

            listaClientes.ItemsSource = ncliente.listar();
        }
    }
}
