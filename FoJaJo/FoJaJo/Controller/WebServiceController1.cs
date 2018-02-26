using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoJaJo.DAL;
using FoJaJo.FoJaJoWebService;

namespace FoJaJo.Controller
{
    class WebServiceController1
    {

        FoJaJoWebServiceSoapClient client = new FoJaJoWebServiceSoapClient();

        public string OpenFile(string filePath)
        {
            string str = client.FindFile(filePath);
            return str;
        }

        public List<Player> GetAllPlayers()
        {
            EntityContext ec = new EntityContext();
            List<Player> list = new List<Player>(client.GetAllPlayers());
            return list;
        }


    }
}
