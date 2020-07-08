using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.DataAcess
{
    public interface IDataConnection
    {
        PrizeModel CreatePrize(PrizeModel model);

        PersonModel CreatePerson(PersonModel model);

        TeamModel CreateTeam(TeamModel model);

        TournamentModel CreateTournament(TournamentModel model);

        List<TeamModel> GetTeam_All();

        List<PersonModel> GetPerson_ALL();
    }
}
