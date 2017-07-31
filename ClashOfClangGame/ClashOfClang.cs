using System;

namespace ClashOfClangGame
{

    public class Fighter
    {
        public Fighter(int damagePerHit, int capacity, FighterType fighterType)
        {
            DamagePerHit = damagePerHit;
            Capacity = capacity;
            FighterType = fighterType;
        }
        public int DamagePerHit { get; private set; }
        public int Capacity { get; private set; }
        public FighterType FighterType { get; private set; }
    }

    public enum FighterType
    {
        None,
        Cannon,
        Barbarian
    }

    public class FighterPower
    {
        private int _numberOfFighters;
        private Fighter _fighter;

        public FighterPower(int numberOfFighters, Fighter fighter)
        {
            _numberOfFighters = numberOfFighters;
            _fighter = fighter;
        }

       //e.g. 1 cannon = 1 * 390 = 390 capacity
       //2 barbarian = 2 * 45 health = 90 capacity
       public int TotalCapacity
       {
           get{
                return _numberOfFighters * _fighter.Capacity; 
           }
       }

       //e.g. 1 cannon, can do 10 damaege per hit, 2 cannon can do enemy's 2 * 10 = 20 damages
       public int TotalDamagePerHitToEnemy
       {
            get{
                return _numberOfFighters * _fighter.DamagePerHit; 
           }
       }
      
    }

}
