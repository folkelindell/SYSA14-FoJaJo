using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoJaJo.Model;
using FoJaJo.Controller;
namespace FoJaJo
{
    class Program
    {
        static void Main(string[] args)
        {
            GameContext gc = new GameContext();
            /*
            Player p = new Player("adam", "@hotmale", "123");
            
            Game g = new Game();
            g.Player= p;
            g.MaxNumberOfPlayers = 2;
            g.GameID = "2";
            g.BoardDimension = "20x20";
            */

            gc.SaveChanges();
            
            
        }
    }
}
