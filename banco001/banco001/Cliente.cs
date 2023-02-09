using System;
using System.Collections.Generic;
using System.Text;

namespace banco001
{
    public class Cliente
    {
        public int idCliente { get; set; }

        public string nomecliente { get; set; }

        public string datanascimento { get; set; }

        public string cpf { get; set; }

        public string tel { get; set; }


        
        public override string ToString()
        {
            return $"{idCliente}-{nomecliente}-{datanascimento}-{cpf}-{tel}";
        }
    }
}
