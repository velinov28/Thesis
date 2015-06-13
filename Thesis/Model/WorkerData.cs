using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thesis.Model
{
    class WorkerData
    {
        public static Worker IsUserLoginCorrect(string username, string password)
        {
            return WorkerData._IsUserLoginCorrect(username, password);
        }
        private static Worker _IsUserLoginCorrect(string username, string password)
        {
            WorkersDataContext dc = new WorkersDataContext();
            var queryResult = (from workers in dc.GetTable<Worker>()
                               where (workers.Username == username) &&
                               (workers.Password == password)
                               select workers).ToArray<Worker>();
            if (queryResult.Count<Worker>() > 0)
                return queryResult.ElementAt<Worker>(0);
            return null;
        }

        public static Worker GetWorkerByUsername(string username)
        {
            return WorkerData._GetWorkerByUsername(username);
        }
        private static Worker _GetWorkerByUsername(string username)
        {
            WorkersDataContext dc = new WorkersDataContext();
            var queryResult = (from workers in dc.GetTable<Worker>()
                               where (workers.Username == username)
                               select workers).ToArray<Worker>();
            if (queryResult.Count<Worker>() > 0)
                return queryResult.ElementAt<Worker>(0);
            return null;
        }

        public static int[] GetCoachIdsByRole()
        {
            WorkersDataContext dc = new WorkersDataContext();
            var queryResult = (from workers in dc.GetTable<Worker>()
                               where (workers.Role == 2)
                               select workers.Id).ToArray<int>();
            if (queryResult.Count<int>() > 0)
                return queryResult.ToArray<int>();
            return null;
        }
    }
}
