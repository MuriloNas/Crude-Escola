using EscolaCRUD.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaCRUDE.Models
{
    public class Escola
    {
        [Key]

        public int Id { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Registro")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Nome { get; set; }
        
        [Column(TypeName = "varchar(250)")]
        [DisplayName("Nome")]
        public String Registro { get; set; }
        
        [Column(TypeName = "varchar(50)")]
        [DisplayName("Endereço")]
        public string Endereço { get; set; }

        public List<Turma> Turmas { get; set; } = new List<Turma>();


    }

}
