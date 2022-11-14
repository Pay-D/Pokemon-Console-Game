using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon_Console_Game
{
    class Fight
    {
        public List<Trainer> trainers = new List<Trainer>();
        public int hasTurn;

        public Fight()
        {
            this.trainers.Add(Trainer.konsti());
            this.trainers.Add(Trainer.paddy());
        }

        public void startGame()
        {
            Console.WriteLine("Starting Fight between " + trainers[0].name + " and " + trainers[1].name + "!");
            selectUnimon(0);
            selectUnimon(1);
            comparePrio();
            while(checkUnimonCountAndHealth(0) && checkUnimonCountAndHealth(1))
            {
                checkHealth(0);
                checkHealth(1);
                Console.WriteLine(trainers[hasTurn].name + " it´s your turn!");
                showAttacks(trainers[hasTurn].currentUnimon);
                int selectedAttack = Convert.ToInt32(Console.ReadLine());
                if (hasTurn == 0)
                {
                    attack(hasTurn,selectedAttack,1);
                    hasTurn = 1;
                }
                else
                {
                    attack(hasTurn, selectedAttack, 0);
                    hasTurn = 0;
                }

            }
            
        }

        public bool checkUnimonCountAndHealth(int trainerIndex)
        {
            if (trainers[trainerIndex].currentUnimon.lp <= 0)
            {
                Console.WriteLine(trainers[trainerIndex].currentUnimon.name + " fainted!");
                trainers[trainerIndex].unimons.Remove(trainers[trainerIndex].currentUnimon);
                if (trainers[trainerIndex].unimons.Count > 0)
                {
                    selectUnimon(trainerIndex);
                    comparePrio();
                    return true;
                }
                else
                {
                    Console.WriteLine(trainers[trainerIndex].name + " loses!");
                    Console.WriteLine("Fucking Loser XD");
                    return false;
                }
            }else
            {
                return true;
            }
        }

        public void checkHealth(int trainerIndex)
        {
            
        }

        public void attack(int attacker, int attackIndex, int enemy)
        {
            int damage = trainers[attacker].currentUnimon.attacks[attackIndex].damage;
            trainers[enemy].currentUnimon.lp -= damage;
            Console.WriteLine(trainers[enemy].name + " lost " + damage + " LP");
            Console.WriteLine(trainers[enemy].name + " now has " + trainers[enemy].currentUnimon.lp + "LP");
        }

        private void showAttacks(Unimon unimon)
        {
            Console.WriteLine("Available Attacks of " + trainers[hasTurn].currentUnimon.name + ":");
            for(int i =0;i < trainers[hasTurn].currentUnimon.attacks.Count ; i++)
            {
                Console.WriteLine("("+ i + ") " + trainers[hasTurn].currentUnimon.attacks[i].name);
            }
        }

        private void comparePrio()
        {
            Console.WriteLine("Prio of " + trainers[0].currentUnimon.name + ":" + trainers[0].currentUnimon.prio);
            Console.WriteLine("Prio of " + trainers[1].currentUnimon.name + ":" + trainers[1].currentUnimon.prio);
            if (trainers[0].currentUnimon.prio > trainers[1].currentUnimon.prio)
            {
                hasTurn = 0;
            }
            else if(trainers[1].currentUnimon.prio > trainers[0].currentUnimon.prio)
            {
                hasTurn = 1;
            }
            else
            {
                if(new Random().Next(0, 2) == 1)
                {
                    hasTurn = 0;
                }else
                {
                    hasTurn = 1;
                }
            }
            Console.WriteLine(trainers[hasTurn].name + " starts!");
        }

        private void selectUnimon(int trainerIndex)
        {

            Console.WriteLine(trainers[trainerIndex].name + " choose a Unimon!");
            Console.WriteLine("Available Unimons:");
            for (int i = 0; i < trainers[trainerIndex].unimons.Count; i++)
            {
                Console.WriteLine("(" + i + "): " + trainers[trainerIndex].unimons[i].name);
            }
            int selected = Convert.ToInt32(Console.ReadLine());
            trainers[trainerIndex].currentUnimon = trainers[trainerIndex].unimons[selected];
            Console.WriteLine(trainers[trainerIndex].name + " selectes " + trainers[trainerIndex].currentUnimon.name + "!");
        }

    }
}
