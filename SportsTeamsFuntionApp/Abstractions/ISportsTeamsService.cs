using SportsTeamsFuntionApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsTeamsFuntionApp.Abstractions
{
    public interface ISportsTeamsService
    {
        bool Create(SportsTeam team);
        List<SportsTeam> Read(string? city);
        bool Update(SportsTeam team);
        bool Delete(int id);
    }
}
