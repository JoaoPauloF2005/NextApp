using System;
using System.Collections.Generic;
using System.Text;

namespace NextApp.Models
{
    public class Transacao
    {
        public int Id { get; set; }
        public Conta ContaOrigem { get; set; }
        public Conta ContaDestino { get; set; }
        public double Valor { get; set; }
        public DateTime Data_Transacao { get; set; }
    }

}
