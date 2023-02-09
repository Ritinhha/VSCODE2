using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace banco001
{
    class PConta
    {
        public void Salvar(List<Conta> contas)
        {
            XmlSerializer x = new XmlSerializer(typeof(List<Conta>));
            StreamWriter f = new StreamWriter("./contas.xml", false);
            x.Serialize(f, contas);
            f.Close();
        }

        public List<Conta> Abrir()
        {
            StreamReader f = null;
            List<Conta> contas;
            try
            {
                XmlSerializer x = new XmlSerializer(typeof(List<Conta>));
                f = new StreamReader("./contas.xml");
                contas = (List<Conta>) x.Deserialize(f);
            }
            catch
            {
                contas = new List<Conta>();
            }
            if (f != null) f.Close();

            return contas;
        }
    }
}
