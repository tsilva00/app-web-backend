using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace app_web_backend.Models
{
    [Table("Dados")]
    public class Dados
    {
        public string Id { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o Usuário!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o Nome!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o Email!")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar a Senha!")]
        public int CEP { get; set; }
     }
}
