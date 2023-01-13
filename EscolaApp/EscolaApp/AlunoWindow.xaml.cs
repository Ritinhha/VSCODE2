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

namespace EscolaApp
{
    /// <summary>
    /// Lógica interna para AlunoWindow.xaml
    /// </summary>
    public partial class AlunoWindow : Window
    {
        public AlunoWindow()
        {
            InitializeComponent();
        }
        private void InserirClick(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(idaluno.Text);
            string nome = nomealuno.Text;
            string mat = mataluno.Text;
            string email = emailaluno.Text;
            int idTurma = int.Parse(idturma.Text);
            Aluno t = new Aluno
            {
                Id = id,
                Nome = nome,
                Matricula = mat,
                Email = email,
                IdTurma = idTurma,
            };
            NAluno.Inserir(t);
            ListarClick(sender, e);
        }
        private void ListarClick(object sender, RoutedEventArgs e)
        {
            listAlunos.ItemsSource = null;
            listAlunos.ItemsSource = NAlunos.Listar();
        }

        private void AtualizarClick(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(idaluno.Text);
            string nome = nomealuno.Text;
            string mat = mataluno.Text;
            string email = emailaluno.Text;
            int idTurma = int.Parse(idturma.Text);
            Aluno t = new Aluno
            {
                Id = id,
                Nome = nome,
                Matricula = mat,
                Email = email,
                IdTurma = idTurma,
            };
            NAlunos.Atualizar(t);
            ListarClick(sender, e);
        }

        private void ExcluirClick(object sender, RoutedEventArgs e)
        {
            if (listAlunos.SelectedItem != null)
            {
                NAlunos.Excluir((Aluno)listAlunos.SelectedItem);
                ListarClick(sender, e);
            }
            else
                MessageBox.Show("Selecione o aluno a ser excluído");
        }

        private void listTurmas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listAlunos.SelectedItem != null)
            {
                Aluno obj = (Aluno)listAlunos.SelectedItem;
                idaluno.Text = obj.Id.ToString();
                nomealuno.Text = obj.Nome;
                mataluno.Text = obj.Matricula;
                emailaluno.Text = obj.Email;
                idturma.Text = obj.IdTurma.ToString();
            }
        }
    }
}
