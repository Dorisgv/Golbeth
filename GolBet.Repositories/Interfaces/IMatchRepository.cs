//ARCHIVO TOCADO---------------------------------------------------------------------------------------------------------------
// GolBet.Repositories/Interfaces/IMatchRepository.cs 

using GolBet.Entities;
using GolBet.Entities.Enums;

namespace GolBet.Repositories.Interfaces;

public interface IMatchRepository : IGenericRepository<Match>
{
    //Add code: 🌸 Aqui agregamos el parametro search GetAllWithTeamsAsync
    Task<IEnumerable<Match>> GetAllWithTeamsAsync(MatchStatus? status = null, string? search = null); //Cambio realizado
    Task<Match?> GetByIdWithDetailsAsync(int id);
}
