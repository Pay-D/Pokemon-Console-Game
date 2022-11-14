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
        public Type type;
        public int prio;
        public List<Attack> attacks;

        public Unimon(int lp,double level,Type type,int prio,List<Attack> attacks,string name) {
            this.lp = lp;
            this.level = level;
            this.type = type;
            this.prio = prio;
            this.attacks = attacks;
            this.name = name;
        }


        public static Unimon fuhr()
        {
            List<Attack> attacks = new List<Attack>();
            return new Unimon(100,1,Type.PROF,2,attacks,"Fuhr");
        }
        public static Unimon tessmann()
        {
            List<Attack> attacks = new List<Attack>();
            return new Unimon(120, 1, Type.PROF, 1,attacks,"Tessmann");
        }

        public static Unimon konsti()
        {
            List<Attack> attacks = new List<Attack>();
            return new Unimon(80, 1, Type.SMOKER, 6,attacks,"Konsti");
        }

        public static Unimon paddy()
        {
            List<Attack> attacks = new List<Attack>();
            return new Unimon(80, 1, Type.SMOKER, 5,attacks,"Paddy");
        }
        public static Unimon dave()
        {
            List<Attack> attacks = new List<Attack>();
            return new Unimon(60, 1, Type.KRÜPPL, 7,attacks,"Dave");
        }
        public static Unimon anika()
        {
            List<Attack> attacks = new List<Attack>();
            return new Unimon(100, 1, Type.PROF, 3,attacks,"Anika");
        }
    }
}
