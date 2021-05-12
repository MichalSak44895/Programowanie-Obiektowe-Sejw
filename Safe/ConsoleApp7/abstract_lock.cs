using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safe
{
    abstract class abstract_lock
    {
        private int pin;
        private string password;
        private bool locked;

        public bool Locked { get { return locked; } set { locked = value; } }   //Właściwości

        public int Pin { get { return pin; } set { pin = value; } }     

        public string Password { get { return password; } set { password = value; } }

        public abstract string ShowPassword();     //metody które muszą być w dziedziczących klasach

        public abstract int ShowPin();

        public abstract void CheckLock();

        public abstract void Unlock(int Pin);

        public abstract void SetLocked(int Pin);
    }
}
