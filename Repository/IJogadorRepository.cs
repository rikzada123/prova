using System.Collections.Generic;
using Prova.Models;

namespace Prova.Repository
{
    public interface IJogadorRepository
    {
        bool CadastrarJogador(JogadorDados dados);
        List<JogadorDados> ListarJogadores(); 
    }
}
