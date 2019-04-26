using System;
using System.Collections.Generic;
using System.Text;

namespace Learning
{
    //Use a class/define/struct to define item strength?
     static class ItemConfig
    {
        public const int EquipMultiplier = 10;
        public const int HPMultiplier = EquipMultiplier*5 ;
        public const int ATKMultiplier = EquipMultiplier*2;
        public const int ArmorMultiplier = EquipMultiplier * 1;
    }
    public enum ItemType
    {
        Consumable,
        Equipment,
        
    }

    public enum EquipmentType
    {
        Helmet,
        Chest,
        Boots,
        Weapon,
        Shield
    }
    class Items
    {
        public float Weight { get => Weight; set => Weight = value; }
        public string Type { get => Type; set => Type = value; }
        public int ID { get => ID; set => ID = value; }

        public Items()
        {
        }
 
    }

    public class Equipment : Items , IiTemConfig
    {
        Random random = new Random();


        //constructor for random equipment values
        public Equipment(EquipmentType equipType, int itemLevel)
        {
            EquipType = equipType;
            HealthPoints = random.Next(itemLevel * ItemConfig.HPMultiplier);
            ArmorPoints = random.Next(itemLevel * ItemConfig.rmorMultiplier);
            HealthPoints = random.Next(itemLevel * ItemConfig.HPMultiplier);

        }

        public Equipment(EquipmentType equipType, int healthPoints, int attackPoints, int armorPoints)
        {
            EquipType = equipType;
            HealthPoints = healthPoints;
            AttackPoints = attackPoints;
            ArmorPoints = armorPoints;
        }


        public EquipmentType EquipType { get => EquipType; set => EquipType = value; }
        public int HealthPoints { get => HealthPoints; set => HealthPoints = value; }
        public int AttackPoints { get => attackPoints; set => attackPoints = value; }
        public int ArmorPoints { get => armorPoints; set => armorPoints = value; }
        public int ItemLevel { get => ItemLevel; set => ItemLevel = value; }
    }
}
