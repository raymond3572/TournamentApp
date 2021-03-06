﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary;

namespace TrackerLibrary
{
    public class TournamentModel
    {
        /// <summary>
        /// The Unique identifier for the tournament.
        /// </summary>

        public int Id { get; set; }

        /// <summary>
        /// Represents the tournament name.
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// The amount of money each team needs to put up to enter.
        /// </summary>

        public decimal EntryFee { get; set; }

        /// <summary>
        /// The set of teams that have entered.
        /// </summary>

        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// The list of prizes for the various places.
        /// </summary>

        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// Represents the match up list
        /// </summary>

        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();

        internal int CheckCurrentRound()  //TODO This shouldnt be here
        {
            throw new NotImplementedException();
        }

        public void AlertUsersToNewRound()
        {
            throw new NotImplementedException();
        }
    }
}
