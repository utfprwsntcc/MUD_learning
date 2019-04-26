using System;
using System.Collections.Generic;
using System.Text;

namespace Learning
{
    public class Actor
    {
        private int id;
        private int healthPoints;
        private int attackPoints;
        private int armorPoints;

        public Actor(int healthPoints, int attackPoints, int armorPoints)
        {
            //auto increment #id
            this.healthPoints = healthPoints;
            this.attackPoints = attackPoints;
            this.armorPoints = armorPoints;
        }

        public int Id { get => id; set => id = value; }
        public int HealthPoints { get => healthPoints; set => healthPoints = value; }
        public int AttackPoints { get => attackPoints; set => attackPoints = value; }
        public int ArmorPoints { get => armorPoints; set => armorPoints = value; }
    }

    public class Player : Actor
    {
        object[] playerEquips = new object[1];

        public Player(int healthPoints, int attackPoints, int armorPoints) : base(healthPoints, attackPoints, armorPoints)
        {
            player
        }


    }

