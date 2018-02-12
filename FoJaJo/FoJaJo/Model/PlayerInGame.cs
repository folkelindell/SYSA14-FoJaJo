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
        public string PlayerUsername { get; set; }
        public virtual Player Player { get; set; }

        [Key]
        [ForeignKey("Game")]
        public string GameId { get; set; }
        public virtual Game Game { get; set; }
        
        public int Score { get; set; }
    }
}
