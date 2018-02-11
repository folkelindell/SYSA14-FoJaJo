using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoJaJo.Model;
namespace FoJaJo
{
    class Program
    {
        static void Main(string[] args)
        {
            GameContext gc = new GameContext();
            Player p = new Player();
            p.Username = "adsd";
            p.Email = "adsd";
            p.Password = "adsad";
            p.Rating = 2;
            gc.Players.Add(p);
            gc.SaveChanges();
        }
    }
}
