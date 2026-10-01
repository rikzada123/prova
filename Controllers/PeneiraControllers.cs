using Microsoft.AspNetCore.Mvc;
using Prova.Repository;
using Prova.Models;

namespace Prova.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PeneiraController : ControllerBase
    {
        private readonly IPeneiraRepository _repository;

        public PeneiraController(IPeneiraRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        [Route("Registrar")]
        public IActionResult Registrar(Peneira dadosPeneira)
        {
            bool sucesso = _repository.RegistrarResultadoPeneira(dadosPeneira);

            if(!sucesso)
                return BadRequest($"Jogador com o cpf {dadosPeneira.cpf} ja registrado.");

            return Ok($"Jogador registrado!");
        }

        [HttpGet]
        [Route("ListarAprovados")]
        public IActionResult ListarAprovados(JogadorDados dados)
        {
            return Ok(_repository.ListarJogadoreAprovados());  
        }

        
    }
}
