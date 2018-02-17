using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoJaJo.Model;

namespace FoJaJo.DAL
{
    public class MsSqlGameDAO
    {
        EntityContext ec = new EntityContext();
        public void CreateGame(Game newGame)
        {
            try
            {
                ec.Games.Add(newGame);
                ec.SaveChanges();
            }
            catch
            {
                
            }
        }
        public Game GetGame(int gameID)
        {
            try
            {
                Game game = ec.Games.Find(gameID);
                return game;
            }
            catch
            {
                return null;
            }
        }
    }
}
