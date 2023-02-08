using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace banco001
{
    static class Nbanco
    {
       static private List<Banco> bancos = new List<Banco>();

        public static void inserir(Banco x)
        {
            Abrir();
            bancos.Add(x);
        }

        public static List<Banco> listar()
        {
            Abrir();
            return bancos;
        }
        public static void excluir(Banco g)
        {
            Abrir();
            bancos.Remove(Checar(g.idbanco));
            Salvar();
        }
        public static void Atualizar(Banco g)
            {
                Abrir();
                Banco n = Checar(g.idbanco);
                n.telbanco = g.telbanco;
                n.nomebanco = g.nomebanco;
                n.numerobanco = g.numerobanco;
                Salvar();
            }

        public static Banco Checar(int id)
            {
                foreach (Banco g in bancos)
                    if (g.idbanco == id) return g;
                return null;
            }
        public static void Salvar()
        {
            XmlSerializer x = new XmlSerializer(typeof(List<Banco>));
            StreamWriter f = new StreamWriter("./banc.xml", false);
            x.Serialize(f, bancos);
            f.Close();

        }

        public static void Abrir()
        {
            StreamReader f = null;
            try
            {
                XmlSerializer x = new XmlSerializer(typeof(List<Banco>));
                f = new StreamReader("./banc.xml");
                bancos = (List<Banco>)x.Deserialize(f);
            }
            catch
            {
                bancos = new List<Banco>();
            }
            if (f != null) f.Close();
        }
    }
}
