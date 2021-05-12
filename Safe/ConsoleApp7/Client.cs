using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safe
{
    class Client : Person
    {
        public Client() { }

        public Client (string NewName, int NewID)   //konstruktory
        {
            Name = NewName;
            ID = NewID;
        }

        public Client (string NewName, string NewSurname, int NewID)
        {
            Name = NewName;
            ID = NewID;
            Surname = NewSurname;
        }
        public Client (Client client1)
        {
            Name = client1.Name;
            Surname = client1.Surname;
            ID = client1.ID;
        }

        public List<Safe> Clients_listofsafes = new List<Safe>();

        public void AddSafe(string producer_1, string model_1, int money_1)
        {
            Clients_listofsafes.Add(new Safe(producer_1, model_1, money_1));
        }

        public void AddSafeWithClient(string producer_1, string model_1, int money_1, Client client_1, Lock lock_1)
        {
            Clients_listofsafes.Add(new Safe(producer_1, model_1, money_1, client_1, lock_1));
        }

        
    }
}
