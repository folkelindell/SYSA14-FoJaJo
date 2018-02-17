using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoJaJo.Model
{
    public class Game
    {
        [Key, Required]
        public string GameID { get; set; }

        [ForeignKey("StartedPlayer"), Required]
        public string StartedPlayerUsername { get; set; }
        public Player StartedPlayer { get; set; }

        [Required]
        public int MaxNumberOfPlayers { get; set; }

        [Required]
        public string BoardDimension { get; set; }

        [ForeignKey("Result")]
        public int ResultID { get; set; }
        public Result Result { get; set; }

        public Game(string gameID, Player player, int maxNumberOfPlayers, string boardDimension, Result result)
        {
            GameID = gameID;
            StartedPlayerUsername = player.Username;
            MaxNumberOfPlayers = maxNumberOfPlayers;
            BoardDimension = boardDimension;
            ResultID = result.ResultId;
        }
    }
}
