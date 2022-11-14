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
        public TrainerType type;

        public Trainer(string name, List<Unimon> unimons, TrainerType type)
        {
            this.name = name;
            this.type = type;
            this.unimons = unimons;
        }
        public static Trainer fuhr()
        {
            List<Unimon> unimons = new List<Unimon>();
            unimons.Add(Unimon.flamey());
            unimons.Add(Unimon.windey());
            return new Trainer("Fuhr", unimons,TrainerType.PROF);
        }
        public static Trainer tessmann()
        {
            List<Unimon> unimons = new List<Unimon>();
            unimons.Add(Unimon.flamey());
            unimons.Add(Unimon.windey());
            return new Trainer("Tessmann", unimons, TrainerType.PROF);
        }

        public static Trainer konsti()
        {
            List<Unimon> unimons = new List<Unimon>();
            unimons.Add(Unimon.flamey());
            unimons.Add(Unimon.windey());
            return new Trainer("Konsti", unimons, TrainerType.SMOKER);
        }

        public static Trainer paddy()
        {
            List<Unimon> unimons = new List<Unimon>();
            unimons.Add(Unimon.flamey());
            unimons.Add(Unimon.windey());
            return new Trainer("Paddy", unimons, TrainerType.SMOKER);
        }
        public static Trainer dave()
        {
            List<Unimon> unimons = new List<Unimon>();
            unimons.Add(Unimon.flamey());
            unimons.Add(Unimon.windey());
            return new Trainer("Dave", unimons, TrainerType.SMOKER);
        }
        public static Trainer anika()
        {
            List<Unimon> unimons = new List<Unimon>();
            unimons.Add(Unimon.flamey());
            unimons.Add(Unimon.windey());
            return new Trainer("Anika", unimons, TrainerType.SMOKER);
        }

        
    }
}
