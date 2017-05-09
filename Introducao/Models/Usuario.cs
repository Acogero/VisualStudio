using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Introducao.Models
{
    public class Usuario
    {
        [Required(ErrorMessage = "O nome é obrigatório.")]
        public string nome { get; set; }

        [Range(18, 70, ErrorMessage = "A idade tem que está entre 18 e 70 anos.")]
        public int idade { get; set; }

        [RegularExpression(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Digite um email valido.")]
        public string email { get; set; }

        [RegularExpression(@"[a-zA-Z]{5,15}", ErrorMessage = "Somente letras e de 5 a 15 caracteres.")]
        [Required(ErrorMessage = "O login é obrigatório.")]
        [Remote("LoginUnico", "Usuario", ErrorMessage = "Este login já existe.")]
        public string login { get; set; }

        [Required(ErrorMessage = "A senha é obrigatório.")]
        public string senha { get; set; }
        [System.ComponentModel.DataAnnotations.Compare("senha", ErrorMessage = "As senhas são diferentes")]
        public string confirmarSenha { get; set; }

        [StringLength(50, MinimumLength = 5, ErrorMessage = "Insira uma informação de 5 a 50 caracteres.")]
        public string observacoes { get; set; }
    }
}