using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoJaJo.Model;

namespace FoJaJo.DAL
{
    public class MsSqlPlayerInGame
    {
        EntityContext ec = new EntityContext();
        public void CreatePlayerInGame(Player player, Game game, int score)
        {
            try
            {
                PlayerInGame playerInGame = new PlayerInGame(player, game, score);
                ec.PlayersInGame.Add(playerInGame);
                ec.SaveChanges();
            }
            catch
            {

            }
        }
        public PlayerInGame GetPlayerInGame(Player player, Game game)
        {
            try
            {
                PlayerInGame pig = ec.PlayersInGame.Find(player, game);
                return pig;
            }
            catch
            {
                return null;
            }
        }
    }
}
