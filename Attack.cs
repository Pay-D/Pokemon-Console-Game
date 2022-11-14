using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon_Console_Game
{
    class Attack
    {
        public int damage;
        public TrainerType type;
        public string name;
        public string action;

        public Attack(int damage,TrainerType type,string name,string action) {
            this.type = type;
            this.damage = damage;
            this.name = name;
            this.action = action;
        }

        public static Attack kick()
        {
            return new Attack(20, TrainerType.NERD, "Kick", "kicks");
        }

    }
}
