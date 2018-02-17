using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace FoJaJo.Model
{
    public class Player
    {

        [MaxLength(30)]
        [Required]
        [Key]
        public string Username { get; set; }

        [Required]
        [MaxLength(255)]
        public string Email { get; set; }

        [Required]
        [MaxLength(255)]
        public string Password { get; set; }

        [Required]
        public int Rating { get; set; }

        [Required]
        public int TotalWins { get; set; }

        public Player(){}

        public Player(string username, string email, string password)
        {
            Username = username;
            Email = email;
            Password = password;
            Rating = 0;
            TotalWins = 0;
        }
       
    }
}
