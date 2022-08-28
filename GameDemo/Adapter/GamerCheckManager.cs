using GameDemo.Abstract;
using GameDemo.Entity;
using ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ServiceReference.KPSPublicSoapClient;

namespace GameDemo.Adapter
{
    class GamerCheckManager : IGamerCheckService
    {
        public bool CheckGamer(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(Convert.ToInt64(gamer.TcNo), gamer.FirstName, gamer.LastName, Convert.ToInt32(gamer.Birthday.Year)).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
