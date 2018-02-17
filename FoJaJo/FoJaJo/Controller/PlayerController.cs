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
        public void RegisterPlayer(string username, string email, string password)
        {
            
            playerDAO = new MsSqlPlayerDAO();
            Player player = new Player(username, email, password);
            try
            {
                //  playerDAO.
            }
            catch
            {

            }
             
        }
        
        
    }
}
