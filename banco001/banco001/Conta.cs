using System;
using System.Collections.Generic;
using System.Text;

namespace banco001
{
   public class Conta
    {
        public int idConta { get; set; }

        public Cliente cliente { get; set; }

        public Banco banco { get; set; }

        public double saldo { get; set; }
        public override string ToString()
        {
            return $"{idConta}-{cliente.nomecliente}-{banco.nomebanco}-{saldo}R$";
        }
    }
}
