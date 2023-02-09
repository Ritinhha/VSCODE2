using System;
using System.Collections.Generic;
using System.Text;

namespace banco001
{
    class Nconta
    {
        private PConta PConta = new PConta();
        private List<Conta> contas = new List<Conta>();

        public void inserir(Conta x)
        {
            contas = PConta.Abrir();
            contas.Add(x);
            PConta.Salvar(contas);
        }

        public List<Conta> listar()
        {
            contas = PConta.Abrir();
            return contas;
        }
        public void excluir(Conta Conta)
        {
            contas = PConta.Abrir();
            contas.Remove(Checar(Conta.idConta));
            PConta.Salvar(contas);
        }
        public void Atualizar(Conta ContaNovo)
        {
            contas = PConta.Abrir();
            Conta ContaAntigo = Checar(ContaNovo.idConta);
            ContaAntigo.cliente = ContaNovo.cliente;
            ContaAntigo.banco = ContaNovo.banco;
            ContaAntigo.saldo = ContaNovo.saldo;
            PConta.Salvar(contas);
        }

        public Conta Checar(int id)
        {
            foreach (Conta g in contas)
                if (g.idConta == id) return g;
            return null;
        }
    }
}
