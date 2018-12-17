﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCCDS.Csharp.Dominio.Entidade
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public int CEP { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
    }
}
