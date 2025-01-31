using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    // Setando o link para entrarmos em qualquer endpoint do StockController.cs
    [Route("api/stock")]
    // define que é utilizado para definir rotas HTTP
    [ApiController]
    // Colocar o ControllerBase primeiro para trazer todos os dados necessários para utilizar o ApiController e o Route
    public class StockController : ControllerBase
    {
        // define para ser apenas utilizado para leitura
        private readonly ApplicationDBContext _context;
        // puxa o banco de dados
        public StockController(ApplicationDBContext context)
        {
            _context = context;
        }

        //define um endpoint para ler o banco
        [HttpGet]
        public IActionResult GetAll()
        {
            //metodo para trazer tudo do banco de dados e armazena na váriavel
            // precisa colocar o ToList() para não retornar um objeto
            var stocks = _context.Stocks.ToList();
            
            // retorna os dados
            return Ok(stocks);
        }


        // Endpoint para que seja informado o id, para buscar o id especifico
        [HttpGet("{id}")]
        // recebemos o id, e colocamos na função GetById
        public IActionResult GetById([FromRoute] int id)
        {
            // precisa colocar o Find(id) Para buscar pelo id
            var stocks = _context.Stocks.Find(id);
            
            // Verifica se o id informado existe
            if (stocks == null)
            {
                return NotFound();
            }
            // caso o id informado exista, retorna os dados
            return Ok(stocks);
        }
    }
}