using System;
using Xunit;
using FluentAssertions;
using ClashOfClangGame;

namespace ClashOfClangTests
{
    public class WarCreatorTests
    {
        [Fact]
        public void GetWinnerInWar_Returns_Barbarian_As_Winner_If_No_Cannon_In_War()
        {
            WarCreator warCreator = new WarCreator(0, 1);
            FighterType winner = warCreator.GetWinnerInWar();
            Assert.Equal(FighterType.Barbarian, winner);
        }

         [Fact]
        public void GetWinnerInWar_Returns_Cannon_As_Winner_If_No_Barbarian_In_War()
        {
            WarCreator warCreator = new WarCreator(1, 0);
            FighterType winner = warCreator.GetWinnerInWar();
            Assert.Equal(FighterType.Cannon, winner);
        }

         [Fact]
        public void GetWinnerInWar_Returns_Cannon_As_Winner_If_1_Cannon_Vs_1_Barbarian_In_War()
        {
            WarCreator warCreator = new WarCreator(1, 1);
            FighterType winner = warCreator.GetWinnerInWar();
            Assert.Equal(FighterType.Cannon, winner);
        }

        
         [Fact]
        public void GetWinnerInWar_Returns_Barbarian_As_Winner_If_1_Cannon_Vs_10_Barbarian_In_War()
        {
            WarCreator warCreator = new WarCreator(1, 10);
            FighterType winner = warCreator.GetWinnerInWar();
            Assert.Equal(FighterType.Barbarian, winner);
        }
    }
}
