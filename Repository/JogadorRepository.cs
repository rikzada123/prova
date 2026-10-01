using Prova.Models;

namespace Prova.Repository
{
    public class JogadorRepository : IJogadorRepository
    {
        private readonly static List<JogadorDados> jogadores = new List<JogadorDados>();

        public bool CadastrarJogador(JogadorDados dados)
        {
            var existe = jogadores.Where(a => a.cpf == dados.cpf).FirstOrDefault();

            if (existe is not null)
                return false;

            jogadores.Add(dados);
            return true;
        }

        public List<JogadorDados> ListarJogadores()
        {
            return jogadores;
        }
    }
}
