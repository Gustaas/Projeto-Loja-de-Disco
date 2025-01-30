using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    //Objeto gigante para definirmos qual tabela queremos que seja usada
    public class ApplicationDBContext : DbContext
    {
        // Construtor
        // precisamos usar a Base para passar os dados (dbcontext) para a classe ApplicationDBContext
        public ApplicationDBContext(DbContextOptions dbContextOptions) 
        : base(dbContextOptions)
        
        {
            
        }

        // utilizamos o DbSet para manipular o banco de dados, onde procura as tabelas e cria elas
        public DbSet<Stock> Stocks {get; set;}
        public DbSet<Comment> Comments {get; set;}


    }
}