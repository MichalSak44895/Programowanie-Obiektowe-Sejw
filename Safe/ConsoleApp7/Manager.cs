using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safe
{
    class Manager : Person, IShowInfo
    {
        public Manager() { }

        private int permissionlevel;
        public int Permissionlevel { get { return permissionlevel; } set { permissionlevel = value; } }     //właściwość

        public Manager (string NewName, int NewID, int NewPermission)   //konstrukory
        {
            ID = NewID;
            Name = NewName;
            permissionlevel = NewPermission;
        }

        public Manager (string NewName,string NewSurname, int NewID, int NewPermission)
        {
            ID = NewID;
            Name = NewName;
            permissionlevel = NewPermission;
            Surname = NewSurname;
        }

        new public string ShowInfo()    //wypisanie informacji
        {
            return "Name: " + Name + "\nSurname: " + Surname + "\nID: " + ID + "\nPermission Level: " + Permissionlevel;
        }

        public int ShowPermission()
        {
            return permissionlevel;
        }

        public List<Client> List_of_clients = new List<Client>();

        public void ManagerAddClient(Client client1)
        {
            List_of_clients.Add(new Client(client1));
        }

        public Client this[int number]
        {
            get => List_of_clients[number];
        }
    }

}
