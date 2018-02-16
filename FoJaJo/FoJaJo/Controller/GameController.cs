using FoJaJo.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoJaJo.Controller
{
    public class GameController
    {
        MsSqlGameDAO gameDAO;

        public void CreateNewGame()
        {
            gameDAO = new MsSqlGameDAO();
            try
            {

            }
            catch
            {

            }
        }
    }
}
