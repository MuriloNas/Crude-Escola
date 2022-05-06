using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaCRUD.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public int Matricula { get; set; }
        public string Nome { get; set; }

        [ForeignKey("TurmaId")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public Turma Turma { get; set; }

    }
}
