using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon_Console_Game
{
    class Attack
    {
        public int damage;
        public Type type;

        public Attack(int damage,Type type) {
            this.type = type;
            this.damage = damage;
        }
    }
}
