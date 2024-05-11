using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tela_de_cadastro.Models

{
    [Table("cadastros")]
    public class Cadastro
    {
        private object ModelState;

        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "campo Obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "campo obrigatório")]
        public string CPF { get; set; }
        [Required(ErrorMessage = "campo obrigatório")]
        public string Email { get; set; }
        [Required(ErrorMessage = "campo obrigatório")]
        public string Senha1 { get; set; }
        [Required(ErrorMessage = "campo obrigatório")]
        public string Senha2 { get; set; }


    }
}
