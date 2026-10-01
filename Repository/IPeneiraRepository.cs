using System.Collections.Generic;
using Prova.Models;

namespace Prova.Repository
{
    public interface IPeneiraRepository
    {
        bool RegistrarResultadoPeneira(Peneira dadosPeneira);
        List<Peneira> JogadoresRegistrados();
        List<Peneira> ListarJogadoreAprovados(); 
    }
}
