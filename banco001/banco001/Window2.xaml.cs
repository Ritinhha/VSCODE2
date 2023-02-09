using System;
using System.Linq;
using System.Windows;

namespace banco001
{
    /// <summary>
    /// Lógica interna para Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();

            Nconta nconta = new Nconta();
            Nbanco nbanco = new Nbanco();
            Ncliente ncliente = new Ncliente();

            bancoLista.ItemsSource = nbanco.listar();
            clienteLista.ItemsSource = ncliente.listar();
            contasLista.ItemsSource = nconta.listar();
        }

        private void inserirconta_Click(object sender, RoutedEventArgs e)
        {
            Nconta nconta = new Nconta();
            Conta contaNovo = new Conta();

            try
            {
                contaNovo.idConta = nconta.listar().Last().idConta + 1;
            }
            catch
            {
                contaNovo.idConta = 1;
            }
            Banco bancoSelecionado = bancoLista.SelectedItem as Banco;
            Cliente clienteSelecionado = clienteLista.SelectedItem as Cliente;

            if (bancoSelecionado == null)
            {
                MessageBox.Show("Banco Inválido");
            }
            else if (clienteSelecionado == null)
            {
                MessageBox.Show("Cliente Inválido");
            }
            else
            {
                contaNovo.banco = bancoSelecionado;
                contaNovo.cliente = clienteSelecionado;
                contaNovo.saldo = Convert.ToDouble(saldo.Text);

                nconta.inserir(contaNovo);

                contasLista.ItemsSource = nconta.listar();

                bancoLista.SelectedItem = null;
                clienteLista.SelectedItem = null;
                saldo.Text = "";
            }
        }

        private void excluirconta_Click(object sender, RoutedEventArgs e)
        {
            Nconta nconta = new Nconta();

            Conta contaToRemove = contasLista.SelectedItem as Conta;

            nconta.excluir(contaToRemove);

            bancoLista.SelectedItem = null;
            clienteLista.SelectedItem = null;
            saldo.Text = "";

            contasLista.ItemsSource = nconta.listar();
        }

        private void atualizarconta_Click(object sender, RoutedEventArgs e)
        {
            Nconta nconta = new Nconta();

            Conta contaAntiga = contasLista.SelectedItem as Conta;
            Conta contaNova = new Conta();

            Banco bancoSelecionado = bancoLista.SelectedItem as Banco;
            Cliente clienteSelecionado = clienteLista.SelectedItem as Cliente;

            contaNova.idConta = contaAntiga.idConta;
            contaNova.cliente = clienteSelecionado;
            contaNova.banco = bancoSelecionado;
            contaNova.saldo = Convert.ToDouble(saldo.Text);

            nconta.Atualizar(contaNova);

            contasLista.ItemsSource = nconta.listar();

            bancoLista.SelectedItem = null;
            clienteLista.SelectedItem = null;
            saldo.Text = "";
        }

        private void contasLista_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            Conta contaNova = new Conta();
            contaNova = contasLista.SelectedItem as Conta;
            if (contaNova != null)
            {
                clienteLista.SelectedItem = contaNova.cliente;
                foreach(Cliente clienteDaConta in clienteLista.Items)
                {
                    if(clienteDaConta.idCliente == contaNova.cliente.idCliente)
                    {
                        clienteLista.SelectedItem = clienteDaConta;
                        break;
                    }
                }

                bancoLista.SelectedItem = contaNova.banco;
                foreach (Banco bancoDaConta in bancoLista.Items)
                {
                    if (bancoDaConta.idbanco == contaNova.banco.idbanco)
                    {
                        bancoLista.SelectedItem = bancoDaConta;
                        break;
                    }
                }

                saldo.Text = Convert.ToString(contaNova.saldo);
            }
        }
    }
}
