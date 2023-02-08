using System;
using System.Collections.Generic;
using System.Text;

namespace banco001
{
   public class Conta
    {
        public int idconta { get; set; }

        public int idcliente { get; set; }

        public double saldo { get; set; }
        public override string ToString()
        {
            return $"{idconta}-{idcliente}-{saldo}R$";
        }
    }
}
