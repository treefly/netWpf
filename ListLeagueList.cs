using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netWpfStudy
{
    public class ListLeagueList : List<League>
    {
        public ListLeagueList()
        {
            League l;
            Division d;

            this.Add(l = new League("League A"));
            l.Divisions.Add((d = new Division("Division A")));
            d.Teams.Add(new Team("Team I"));
            d.Teams.Add(new Team("Team II"));
            d.Teams.Add(new Team("Team III"));
            d.Teams.Add(new Team("Team IV"));
            d.Teams.Add(new Team("Team V"));
            l.Divisions.Add((d = new Division("Division B")));
            d.Teams.Add(new Team("Team Blue"));
        }
    }

    public class League
    {
        public League(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
        public List<Division> Divisions { get; set; } = new List<Division>();
    }

    public class Division
    {
        public Division(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
        public  List<Team> Teams { get; set; } = new List<Team>();
    }

    public class Team
    {
        public Team(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
    }
}
