using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoJaJo.Model;

namespace FoJaJo.DAL
{
    
    public class MsSqlPlayerDAO
    {
        EntityContext ec = new EntityContext();

        public void RegisterPlayer(Player newPlayer)
        {
            try
            {
                ec.Players.Add(newPlayer);
                ec.SaveChanges();
            }
            catch
            {

            }
        }
        public Player GetPlayer(string username)
        {
            try
            {
                Player player = ec.Players.Find(username);
                return player;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
