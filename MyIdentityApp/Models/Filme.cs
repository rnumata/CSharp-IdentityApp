using System;
using System.ComponentModel.DataAnnotations;

namespace MyIdentityApp.Models
{
    public class Filme
    {
        public Filme()
        {
        }

        public int Id { get; set; }

        public string Nome { get; set; }

        public string Produtora { get; set; }

        [Display(Name = "Gênero")]
        public Genero? Genero { get; set; }
    }
}
