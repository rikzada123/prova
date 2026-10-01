using Microsoft.AspNetCore.Mvc;
using Prova.Repository;
using Prova.Models;

namespace Prova.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JogadorController : ControllerBase
    {
        private readonly IJogadorRepository _repository;

        public JogadorController(IJogadorRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        [Route("Cadastrar")]
        public IActionResult Cadastrar(JogadorDados dados)
        {
            bool sucesso = _repository.CadastrarJogador(dados);

            if(!sucesso)
                return BadRequest($"Jogador com o CPF: {dados.cpf} ja cadastrado.");

            return Ok($"Jogador cadastrado!");
        }

        public IActionResult ListarTodos()
        {
            return Ok(_repository.ListarJogadores());
        }

        
    }
}
