using Prova.Models;
using System.Linq;
using System.Collections.Generic;

namespace Prova.Repository
{
    public class PeneiraRepository : IPeneiraRepository
    {
        private readonly static List<Peneira> aprovados = new List<Peneira>();
        private readonly static List<Peneira> registrados = new List<Peneira>();

        public bool RegistrarResultadoPeneira(Peneira dadosPeneira)
        {
            var existe = aprovados.Where(a => a.cpf == dadosPeneira.cpf).FirstOrDefault(); ;

            if (existe is not null)
                return false;

            registrados.Add(dadosPeneira);

            

            if (dadosPeneira.aprovado == true)
                aprovados.Add(dadosPeneira);

            return true;
        }

        public List<Peneira> ListarJogadoreAprovados()
        {
            return aprovados;
        }

        public List<Peneira> JogadoresRegistrados()
        {
            return registrados;
        }
    }
}