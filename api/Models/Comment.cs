using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace api.Models
{
    public class Comment
    {
        // Modelo n to 1 para Stock
        public int Id { get; set; }
        // Colocamos string.Empty; para definirmos a string pra iniciar vazia
        public string Title {get; set;} = string.Empty;
        public string Content {get; set;} = string.Empty;
        public DateTime CreatedOn {get; set;} = DateTime.Now;
        public int? StockId {get; set;}
        // Propriedade de navegação, para acessarmos o modelo estoque
        public Stock? Stock {get; set;}
    }
}