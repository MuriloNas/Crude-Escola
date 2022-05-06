using EscolaCRUD.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaCRUDE.Models
{
    public class EscolaContext: DbContext
    {
        public EscolaContext(DbContextOptions<EscolaContext> options) : base(options)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Escola>().HasMany(escola => escola.Turmas).WithOne(turma => turma.Escola);
            builder.Entity<Turma>().HasOne(turma => turma.Escola).WithMany(escola => escola.Turmas);
        }

        public DbSet<Escola> Escola { get; set; }
        public DbSet<Turma> Turmas { get; set; }
        public DbSet<Aluno> Alunos { get; set; }
    }
}
