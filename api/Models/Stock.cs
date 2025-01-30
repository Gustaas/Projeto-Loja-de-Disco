using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    // Modelo Padrão da empresa
    public class Stock
    {
        // Modelo 1 to N para Comment
        public int Id { get; set; }
        public string Symbol {get; set;} = string.Empty;
        public string CompanyName {get; set;} = string.Empty;
        // define que usaremos valor decimal no banco
        [Column(TypeName = "decimal(18,2)")]
        public decimal Purchase {get; set;}
        [Column(TypeName = "decimal(18,2)")]
        public decimal LastDiv {get; set;}
        public string Industry {get; set;} = string.Empty;
        //valor de mercado
        public long MarketCap {get; set;}
        //relacionamento
        public List<Comment> Comments {get; set;} = new List<Comment>();
    }
}