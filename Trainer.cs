using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon_Console_Game
{
    class Trainer
    {
        public string name;
        public List<Unimon> unimons;
        public Unimon currentUnimon;


        public Trainer(string name, List<Unimon> unimons)
        {
            this.name = name;
            this.unimons = unimons;
        }
        public static Trainer t1()
        {
            List<Unimon> unimons = new List<Unimon>();
            unimons.Add(Unimon.anika());
            unimons.Add(Unimon.dave());
            return new Trainer("test1", unimons);
        }
        public static Trainer t2()
        {
            List<Unimon> unimons = new List<Unimon>();
            unimons.Add(Unimon.fuhr());
            unimons.Add(Unimon.tessmann());

            return new Trainer("test2", unimons);
        }
    }
}
