using System;
using  System.Collections.Generic;

namespace ClashOfClangGame
{
    public class WarCreator
    {     
        FighterPower _cannonsPower;
        FighterPower _barbariansPower;

        public WarCreator(int numOfCannons, int numOfbarbarians)
        {
             Fighter cannon = new Fighter(10, 390, FighterType.Cannon); 
             Fighter barbarian  = new Fighter(8, 45, FighterType.Barbarian); 

             _cannonsPower = new FighterPower(numOfCannons, cannon);
             _barbariansPower = new FighterPower(numOfbarbarians, barbarian);             
       }

        public FighterType GetWinnerInWar()
        {

            var barabarianRemainingPoints = _cannonsPower.TotalDamagePerHitToEnemy == 0 ? 
                      _barbariansPower.TotalCapacity : _barbariansPower.TotalCapacity/_cannonsPower.TotalDamagePerHitToEnemy;
            var cannonRemainingPoints =  _barbariansPower.TotalDamagePerHitToEnemy == 0 ? 
                      _cannonsPower.TotalCapacity : _cannonsPower.TotalCapacity/_barbariansPower.TotalDamagePerHitToEnemy;
            
            if(barabarianRemainingPoints > cannonRemainingPoints)
                 return FighterType.Barbarian;
            else if(cannonRemainingPoints > barabarianRemainingPoints)
                return FighterType.Cannon;
            else
                return FighterType.None;
        }


    }

}