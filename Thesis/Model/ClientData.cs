using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace Thesis.Model
{
    class ClientData
    {
        private static DateTime today = DateTime.Now.Date;
        private static TimeSpan difference;
        private static int flag;

        public static Client[] GetAllClients()
        {
            return ClientData._GetAllClients();
        }

        private static Client[] _GetAllClients()
        {
            ClientsDataContext dc = new ClientsDataContext();
            var queryResult = (from clients in dc.GetTable<Client>()
                               select clients).ToArray<Client>();
            if (queryResult.Count<Client>() > 0)
                return queryResult;
            return null;
        }

        public static List<Client> GetClientsWithExpiringSubscription()
        {
            Client[] allClients = ClientData.GetAllClients();
            List<Client> expiringSubscriptions = new List<Client>();

            foreach (Client client in allClients)
            {
                difference = client.SubTo - today;
                flag = (int) difference.TotalDays;
                if (flag >= 0)
                {
                    expiringSubscriptions.Add(client);
                }
            }
            return expiringSubscriptions;
        }

        public static List<Client> GetClientsWithExpiredSubscription()
        {
            Client[] allClients = ClientData.GetAllClients();
            List<Client> expiredSubscriptions = new List<Client>();

            foreach (Client client in allClients)
            {
                difference = client.SubTo - today;
                flag = (int) difference.TotalDays;
                if (flag < 0)
                {
                    expiredSubscriptions.Add(client);
                }
            }
            return expiredSubscriptions;
        }

        public static Client GetClientById(int id)
        {
            return ClientData._GetClientById(id);
        }

        private static Client _GetClientById(int id)
        {
            ClientsDataContext dc = new ClientsDataContext();
            var queryResult = (from clients in dc.GetTable<Client>()
                               where (clients.Id == id)
                               select clients).ToArray<Client>();
            if (queryResult.Count<Client>() > 0)
                return queryResult.ElementAt<Client>(0);
            return null;
        }

        public static int[] GetIds()
        {
            ClientsDataContext dc = new ClientsDataContext();
            var queryResult = (from clients in dc.GetTable<Client>()
                               select clients.Id).ToArray<int>().Distinct<int>();
            if (queryResult.Count<int>() > 0)
                return queryResult.ToArray<int>();
            return null;
        }
    }
}