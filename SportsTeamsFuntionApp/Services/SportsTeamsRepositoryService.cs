using SportsTeamsFuntionApp.Abstractions;
using SportsTeamsFuntionApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsTeamsFuntionApp.Services
{
    public class SportsTeamsRepositoryService:ISportsTeamsRepositoryService
    {
        private readonly IMylogger _mylogger;

        public SportsTeamsRepositoryService(IMylogger mylogger) 
        {
            _mylogger = mylogger;
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
            try
            {
                _mylogger.LogInfo($"Running SportsTeamsRepository.Read for city: {city}");
                List<SportsTeam> sportsTeams = new List<SportsTeam>();

                var team = new SportsTeam
                {
                    Id = 1,
                    City = "Atlanta",
                    Name = "Braves"
                };
                sportsTeams.Add(team);

                team = new SportsTeam
                {
                    Id = 2,
                    City = "Atlanta",
                    Name = "Falcons"
                };
                sportsTeams.Add(team);

                team = new SportsTeam
                {
                    Id = 3,
                    City = "Los Angeles",
                    Name = "Rams"
                };
                sportsTeams.Add(team);

                if (string.IsNullOrEmpty(city))
                {
                    return sportsTeams;
                }

                var cityTeams = sportsTeams.Where(x => x.City.Equals(city, StringComparison.OrdinalIgnoreCase)).ToList();
                return cityTeams;
            }
            catch (Exception ex)
            {
                _mylogger.LogError(ex, "error");
                throw;
            }
        }

        public bool Update(SportsTeam team)
        {
            return true;
        }
    }
}
