using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoJaJo.Model;

namespace FoJaJo.Controller
{
    public class PlayerController
    {
        public void RegisterPlayer(string username, string email, string password)
        {
            Player newPlayer = new Player(username, email, password);
            GameContext gameContext = new GameContext();
            gameContext.Players.Add(newPlayer);
        }
        
    }
}
