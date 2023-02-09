using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace banco001
{
    class PBanco
    {
        public void Salvar(List<Banco> bancos)
        {
            XmlSerializer x = new XmlSerializer(typeof(List<Banco>));
            StreamWriter f = new StreamWriter("./banc.xml", false);
            x.Serialize(f, bancos);
            f.Close();
        }

        public List<Banco> Abrir()
        {
            StreamReader f = null;
            List<Banco> bancos;
            try
            {
                XmlSerializer x = new XmlSerializer(typeof(List<Banco>));
                f = new StreamReader("./banc.xml");
                bancos = (List<Banco>) x.Deserialize(f);
            }
            catch
            {
                bancos = new List<Banco>();
            }
            if (f != null) f.Close();

            return bancos;
        }
    }
}
