﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NextApp.Models
{
    public class Correntista
    {
        public int? Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        public string Cpf { get; set; }
        public DateTime Data_Nascimento { get; set; }
       
        public string Senha { get; set; }
    }
}
