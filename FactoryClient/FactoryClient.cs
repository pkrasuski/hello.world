using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HWApi;

namespace FactoryClient
{
    public static class Factory
    {
        private static Dictionary<string, ClientBase> clients = new Dictionary<string, ClientBase>();

        static Factory()
        {
            clients.Add("Console", new Cons());
            // add new client types here
        }

        public static ClientBase Create(string TypeClient)
        {
            return clients[TypeClient];
        }

    }
}
