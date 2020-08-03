using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents one match in the tournament.
    /// </summary>
    
    public class MatchupModel
    {
        /// <summary>
        /// The Unique identifier for the matchup.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The set of teams that were involved in this match.
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// The set of teams that were involved in this match.
        /// </summary>
        public int WinnerId { get; set; }

        /// <summary>
        /// The ID from the datase that will be used to  winner of the match.
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// Which round this match is a part of.
        /// </summary>
        public int MatchupRound { get; set; }

        /// <summary>
        /// Which round this match is a part of.
        /// </summary>
        public int DisplayName
        { //TODO Error
          //Error CS0161	'MatchupModel.DisplayName.get': not all code paths return a value TrackerLibrary 
          //C:\StarttoFinish\TournamentTracker\TrackerLibrary\Models\MatchupModel.cs	45	Active
            get
            {
                string output = "";

                foreach (MatchupEntryModel me in Entries)
                {
                    if (me.TeamCompeting != null)
                    {
                        if (output.Length == 0)
                        {
                            output = me.TeamCompeting.TeamName;
                        }
                        else
                        {
                            output += $" vs. { me.TeamCompeting.TeamName } ";
                            break;
                        } 
                    }
                    else
                    {
                        output = "Matchup Not Yet Determined";
                    }
                }
            }
        }
    }
}
