using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safe
{
    abstract class abstract_person
    {
        private string name, surname;
        private int id;

        public string Name { get { return name; } set { name = value; } } //właściwości

        public int ID { get { return id; } set { id = value; } }

        public string Surname { get { return surname; } set { surname = value; } }

        public abstract string ShowName();  //metody które muszą być w dziedziczących klasach

        public abstract string ShowSurname();

        public abstract int ShowID();
    }
}
