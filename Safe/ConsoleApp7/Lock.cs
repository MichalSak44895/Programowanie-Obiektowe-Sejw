using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safe
{
    class Lock : abstract_lock
    {
        public Lock() { }

        public Lock (int NewPin, string NewPassword)    //konsturktory
        {
            Password = NewPassword;
            Pin = NewPin;
        }

        public Lock (int NewPin, string NewPassword, bool locked)
        {
            Password = NewPassword;
            Pin = NewPin;
            Locked = locked;
        }

        public Lock (int NewPin)
        {
            Pin = NewPin;
        }

        public Lock(string NewPassword)
        {
            Password = NewPassword;
        }

        public override string ShowPassword()    //wypisanie informacji
        {
            return Password;
        }

        public override int ShowPin()
        {
            return Pin;
        }

        public void GetInfo()
        {
            Console.WriteLine("Password is:{0}\nPin is:{1}", Password, Pin);
        }

        public override void CheckLock()    //operacje na zamku
        {
                View.LockStatus(Locked);
        }


        public override void Unlock(int CurrentPin)
        {
            if (CurrentPin == Pin)
            {
                Locked = false;
                View.LockStatus(Locked);
            }
            else View.WrongPin();

        }

        public override void SetLocked(int CurrentPin)
        {
            if (CurrentPin == Pin)
            {
                Locked = true;
                View.LockStatus(Locked);
            }
            else View.WrongPin();
        }


        
    }
}
