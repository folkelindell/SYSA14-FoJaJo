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
        [Key]
        [ForeignKey("Player")]
        public Player PlayerUsername { get; set; }

        [Key]
        [ForeignKey("Game")]
        public Game GameId { get; set; }
        
        public int Score { get; set; }
    }
}
