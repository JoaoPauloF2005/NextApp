﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NextApp.Models
{
    internal class Correntista
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime Data_nasc { get; set; }
        public string Senha { get; set; }
    }
}