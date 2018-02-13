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
        public string GameID{get; set;}
        
        [ForeignKey("StartedPlayer")]
        public string StartedPlayerUsername { get; set; }
        public Player StartedPlayer { get; set; }

        [Required]
        public int MaxNumberOfPlayers { get; set; }

        [Required]
        public string BoardDimension { get; set; }

        [ForeignKey("Result")]
        public int ResultId { get; set; }
        public Result Result { get; set; }


    }   
}
