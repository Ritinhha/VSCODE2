using System;
using System.Collections.Generic;
using System.Text;

namespace banco001
{
    public class Banco
    {
        public int idbanco { get; set; }

        public string nomebanco { get; set; }

        public string numerobanco{ get; set; }

        public string telbanco { get; set; }
        public override string ToString()
        {
            return $"{idbanco}-{nomebanco}-{numerobanco}-{telbanco}";
        }
    }
}
