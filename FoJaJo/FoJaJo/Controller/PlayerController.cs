using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoJaJo.Model;
using FoJaJo.DAL;
using FoJaJo.GUI;

namespace FoJaJo.Controller
{
    public class PlayerController
    {
        MsSqlPlayerDAO playerDAO;
        public PlayerController()
        {
            playerDAO = new MsSqlPlayerDAO();
        }
        public Player LogInPlayer(string usr, string pw)
        {
            Console.WriteLine(usr);
            Player player = GetPlayer(usr);
            if (player != null && player.Password.Equals(pw))
            {
                return player;
            }
            else
            {
                return null;
            }
        }

        public void RegisterPlayer(string username, string email, string password)
        {
            Player player = new Player(username, email, password);
            playerDAO.RegisterPlayer(player);
        }
        public Player GetPlayer(string username)
        {
            Player player = playerDAO.GetPlayer(username);
            return player;
        }




    }
}
