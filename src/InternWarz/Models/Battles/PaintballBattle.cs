using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternWarz.Models.Battles
{
    public class PaintballBattle : Battle
    {
        List<Team> teams;

        public PaintballBattle(int teamSize, TeamData[] teamData)
        {
            teams = new List<Team>(teamData.Length);
            foreach(TeamData td in teamData)
            {
                teams.Add(new Team() { Data = td });
            }
        }
    }
}
