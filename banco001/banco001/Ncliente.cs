using System;
using System.Collections.Generic;
using System.Text;

namespace banco001
{
    class Ncliente
    {
        private PCliente pcliente = new PCliente();
        private List<Cliente> clientes = new List<Cliente>();

        public void inserir(Cliente x)
        {
            clientes = pcliente.Abrir();
            clientes.Add(x);
            pcliente.Salvar(clientes);
        }

        public List<Cliente> listar()
        {
            clientes = pcliente.Abrir();
            return clientes;
        }
        public void excluir(Cliente cliente)
        {
            clientes = pcliente.Abrir();
            clientes.Remove(Checar(cliente.idCliente));
            pcliente.Salvar(clientes);
        }
        public void Atualizar(Cliente clienteNovo)
        {
            clientes = pcliente.Abrir();
            Cliente clienteAntigo = Checar(clienteNovo.idCliente);
            clienteAntigo.nomecliente = clienteNovo.nomecliente;
            clienteAntigo.cpf = clienteNovo.cpf;
            clienteAntigo.tel = clienteNovo.tel;
            clienteAntigo.datanascimento = clienteNovo.datanascimento;
            pcliente.Salvar(clientes);
        }

        public Cliente Checar(int id)
        {
            foreach (Cliente g in clientes)
                if (g.idCliente == id) return g;
            return null;
        }
    }
}
