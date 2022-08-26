using System.ComponentModel.DataAnnotations;

namespace AgendaContatos.Mvc.Models
{
    public class AccountRegisterModel
    {
        [MinLength(6,ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        [MaxLength(150, ErrorMessage = "Por favor, informe no máximo {1} caracteres." )]
        [Required(ErrorMessage = "Pro favor, informe seu nome.")]
        public string Nome { get; set; }

        [EmailAddress(ErrorMessage = "Por favor, informe um endereço de email válido.")]
        [Required(ErrorMessage = "Pro favor, informe seu email.")]
        public String Email { get; set; }

        [MinLength(8, ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        [MaxLength(20, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Pro favor, informe seu senha.")]
        public string Senha { get; set; }

        [Compare("Senha",ErrorMessage = "Senhas não confere, por favor verifique.")]
        [Required(ErrorMessage = "Pro favor, informe seu senha.")]
        public string SenhaConfirmacao { get; set; }
    }
}
