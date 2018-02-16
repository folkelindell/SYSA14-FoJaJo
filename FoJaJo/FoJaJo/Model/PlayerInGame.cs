using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoJaJo.Model
{
    public class PlayerInGame
    {
        [Key, ForeignKey("Player"), Column(Order = 0)]
        public string Username { get; set; }
        public Player Player { get; set; }

        [Key, ForeignKey("Game"), Column(Order = 1)]
        public int GameId { get; set; }
        public Game Game { get; set; }
        
        public int Score { get; set; }

        public PlayerInGame(Player player, Game game, int score)
        {
            Username = Player.Username;
            GameId = Game.GameID;
            Score = score;
        }
    }
}
