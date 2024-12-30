using SportsTeamsFuntionApp.Abstractions;
using SportsTeamsFuntionApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsTeamsFuntionApp.Services
{
    public class SportsTeamsService : ISportsTeamsService
    {
        private readonly ISportsTeamsRepositoryService _repositoryService;

        public SportsTeamsService(ISportsTeamsRepositoryService sportsTeamsRepositoryService) 
        {
            _repositoryService = sportsTeamsRepositoryService;
        }

        public bool Create(SportsTeam team)
        {
            return true;
        }

        public bool Delete(int id)
        {
            return true;
        }

        public List<SportsTeam> Read(string city)
        {
            return _repositoryService.Read(city);
        }

        public bool Update(SportsTeam team)
        {
            throw new NotImplementedException();
        }
    }
}
