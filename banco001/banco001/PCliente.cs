using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace banco001
{
    class PCliente
    {
        public void Salvar(List<Cliente> clientes)
        {
            XmlSerializer x = new XmlSerializer(typeof(List<Cliente>));
            StreamWriter f = new StreamWriter("./clientes.xml", false);
            x.Serialize(f, clientes);
            f.Close();
        }

        public List<Cliente> Abrir()
        {
            StreamReader f = null;
            List<Cliente> clientes;
            try
            {
                XmlSerializer x = new XmlSerializer(typeof(List<Cliente>));
                f = new StreamReader("./clientes.xml");
                clientes = (List<Cliente>) x.Deserialize(f);
            }
            catch
            {
                clientes = new List<Cliente>();
            }
            if (f != null) f.Close();

            return clientes;
        }
    }
}
