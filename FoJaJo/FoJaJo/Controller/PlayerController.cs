using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoJaJo.Model;
using FoJaJo.DAL;

namespace FoJaJo.Controller
{
    public class PlayerController
    {
        MsSqlPlayerDAO playerDAO;
        public PlayerController()
        {
            playerDAO = new MsSqlPlayerDAO();
        }

        public void RegisterPlayer(string username, string email, string password)
        {
            Player player = new Player(username, email, password);
            try
            {
                playerDAO.RegisterPlayer(player);
            }
            catch
            {

            }    
        }
        public Player GetPlayer(string username)
        {
            try
            {
                Player player = playerDAO.GetPlayer(username);
                return player;
            }
            catch (Exception)
            {

                throw;
            }

        }
        
         
        
        
    }
}
