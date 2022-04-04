using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace app_web_backend.Models
{
    [Table("Dados")]
    public class Dados
    {
        [Key]
        [Required(ErrorMessage = "Obrigatório Informar o Usuário!")]
        public string Id { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o Nome!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o Email!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar a Senha!")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o CEP!")]
        public int CEP { get; set; }
        public bool Done { get; set; }
    }
    }
