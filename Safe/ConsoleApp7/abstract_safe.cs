using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safe
{
    abstract class abstract_safe
    {
        private string producer, model;
        private int money;

        public int Money { get { return money; } set { money = value; } }

        public string Producer { get { return producer; } set { producer = value; } }

        public string Model { get { return model; } set { model = value; } }

        public abstract string ShowModel();     //metody które muszą być w dziedziczących klasach

        public abstract string ShowProducer();

        public abstract int CheckMoney();

        public abstract void ChangeDeposit(int Change);

    }
}
