using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StatlerWaldorfCorp.TeamService.Models;

namespace StatlerWaldorfCorp.TeamService.Persistence
{
    public class InMemoryTeamRepository : ITeamRepository
    {
        protected static ICollection<Team> _teams;

        public InMemoryTeamRepository()
        {
            if (_teams == null)
                _teams = new List<Team>();
        }

        public InMemoryTeamRepository(ICollection<Team> teams)
        {
            _teams = teams;
        }
        public void AddTeam(Team team)
        {
            _teams.Add(team);
        }

        public IEnumerable<Team> GetTeams()
        => _teams;
    }
}
