using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Introducao.Models
{
    public class Usuario
    {
        public string nome { get; set; }
        public int idade { get; set; }
        public string email { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public string confirmarSenha { get; set; }
        public string observacoes { get; set; }
    }
}