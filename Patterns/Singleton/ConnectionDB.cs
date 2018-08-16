using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Singleton
{
    public class ConnectionDB
    {
        private static ConnectionDB ourInstance;

        public static ConnectionDB getInstance()
        {
            if (ourInstance == null)
            {
                Console.WriteLine("Singleton new");
                ourInstance = new ConnectionDB();
                return ourInstance;
            }

            Console.WriteLine("Singleton returned");
            return ourInstance;
        }

        private ConnectionDB()
        {
        }
    }
}