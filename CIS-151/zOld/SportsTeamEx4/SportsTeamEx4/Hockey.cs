﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsTeams
{
    class Hockey : Team
    {
        private string rinkLocation;
        private int numOfPlayers;

        public Hockey(string name, string coach, string team,
            string location, int players)
            : base(name, coach, team)
        {
            rinkLocation = location;
            numOfPlayers = players;
        }

        public override int NumOfPlayers()
        {
            return numOfPlayers;
        }

        //string override
        public override string ToString()
        {
            return "The " + base.SportName +
                " team, " + base.TeamName +
                ", is coached by " +
                base.CoachName + "." + 
                "\nRink location: " + rinkLocation +
                "\nNumber of players: " + numOfPlayers
                ;
        }
    }
}
