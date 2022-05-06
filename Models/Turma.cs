using EscolaCRUDE.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaCRUD.Models
{
    public class Turma
    {
        [Key]
        public int Id { get; set; }
        
        public string Nome { get; set; }

        public List<Aluno> Alunos { get; set; } = new List<Aluno>();
        
        [ForeignKey("EscolaId")]
        public  Escola Escola { get; set; }
        
    }
}
