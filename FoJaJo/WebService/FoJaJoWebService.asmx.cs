using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using FoJaJo.Model;
using FoJaJo.DAL;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace WebService
{
    /// <summary>
    /// Summary description for FoJaJoWebservice
    /// </summary>
    [WebService(Namespace = "http://tempuri.org")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]

    public class FoJaJoWebService : System.Web.Services.WebService
    {
        
        DataSet ds = new DataSet();
        SqlConnection connection = new SqlConnection("data source=laptop-7hibdffa;initial catalog=FoJaJoDB;integrated security=True;");
        SqlDataAdapter da = new SqlDataAdapter();
        
        [WebMethod]
        public Player GetPlayer(string username)
        {
            using (EntityContext ec = new EntityContext()) {
                Player player = ec.Players.Find(username);
                return player;
            }
        }
        [WebMethod]
        public List<Player> GetAllPlayers()
        {
            using (EntityContext ec = new EntityContext())
            {
                List<Player> list = new List<Player>();
                foreach (var player in ec.Players)
                {
                    list.Add(player);
                }
                return list;
            }
        }
        [WebMethod]
        public List<Game> GetAllGames()
        {
            using (EntityContext ec = new EntityContext())
            {
                List<Game> list = new List<Game>();
                foreach (var game in ec.Games)
                {
                    list.Add(game);
                }
                return list;
            }
        }
        
        
        [WebMethod]
        public string FindFile(string filePath)
        {
            return File.ReadAllText(filePath);
        }
        
        [WebMethod]
        public List<Player> GetPlayers()
        {
            List<Player> players = new List<Player>();
            connection.Open();
            using (SqlCommand command = new SqlCommand("SELECT * FROM Player", connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Player p = new Player();
                        p.Username = reader.GetValue(0) as string;
                        p.Email = reader.GetValue(1) as string;
                        p.Password = reader.GetValue(2) as string;
                        p.Rating = reader.GetInt32(3);
                        p.TotalWins = reader.GetInt32(4);
                        players.Add(p);
                    }
                }
            }
            return players;
        }
    }
}
