using System.ComponentModel.DataAnnotations.Schema;

namespace Agenda.models
{
    public class Contato
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        [Column("email_principal")]
        public string EmailPrincipal { get; set; }

        public string? Apelido { get; set; }

        [Column("data_nascimento")]
        public DateTime DataNascimento { get; set; }

        public char Sexo { get; set; }

        /* public int Id { get; set; }
         public string Nome { get; set; }
         public string Email { get; set; }

         public DateTime DataNascimento { get; set; }*/
    }
}
