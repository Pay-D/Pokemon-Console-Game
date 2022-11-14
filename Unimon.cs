using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon_Console_Game
{
    class Unimon
    {
        public string name;
        public int lp;
        public double level;
        public UnimonType unimonType;
        public int prio;
        public List<Attack> attacks;

        public Unimon(int lp,double level,int prio,List<Attack> attacks,string name,UnimonType unimonType) {
            this.lp = lp;
            this.level = level;
            this.prio = prio;
            this.attacks = attacks;
            this.name = name;
            this.unimonType = unimonType;
        }


        public static Unimon flamey()
        {
            List<Attack> attacks = new List<Attack>();
            attacks.Add(Attack.kick());
            return new Unimon(100,1,2,attacks, "Flamey", UnimonType.FIRE);
        }
        public static Unimon windey()
        {
            List<Attack> attacks = new List<Attack>();
            attacks.Add(Attack.kick());
            return new Unimon(120, 1, 1,attacks, "Windey", UnimonType.AIR);
        }
    }
}
