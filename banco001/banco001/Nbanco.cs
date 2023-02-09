using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace banco001
{
    class Nbanco
    {
        private PBanco pbanco = new PBanco();
        private List<Banco> bancos = new List<Banco>();

        public void inserir(Banco x)
        {
            bancos = pbanco.Abrir();
            bancos.Add(x);
            pbanco.Salvar(bancos);
        }

        public List<Banco> listar()
        {
            List<Banco> bancos = pbanco.Abrir();
            return bancos;
        }
        public void excluir(Banco g)
        {
            bancos = pbanco.Abrir();
            bancos.Remove(Checar(g.idbanco));
            pbanco.Salvar(bancos);
        }
        public void Atualizar(Banco g)
            {
                bancos = pbanco.Abrir();
                Banco n = Checar(g.idbanco);
                n.telbanco = g.telbanco;
                n.nomebanco = g.nomebanco;
                n.numerobanco = g.numerobanco;
                pbanco.Salvar(bancos);
            }

        public Banco Checar(int id)
            {
                foreach (Banco g in bancos)
                    if (g.idbanco == id) return g;
                return null;
            }
    }
}
