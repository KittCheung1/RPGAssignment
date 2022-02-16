using RPGAssignment.Characters;
using Xunit;

namespace RPGAssignmentTest
{
    public class CharacterTest
    {
        [Fact]
        public void Constructor_InitializeCharactersDefaultLevel_ReturnCharacterDefaultLevel()
        {
            //Arrange
            Warrior warrior = new Warrior("Sven");
            int expected = 1;

            //Act
            int actual = warrior.Level;

            // Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void LevelUp_LevelIncreaseWithOneUnit_ReturnNewIncreasedLevelValue()
        {
            //Arrange
            Warrior warrior = new Warrior("Warrior");
            int expected = 2;

            //Act
            warrior.LevelUp();
            int actual = warrior.Level;

            //Assert
            Assert.Equal((int)expected, actual);
        }

        [Fact]
        public void ConstructorClassTypeRouge_InitializeClassTypeRougeWithDefaultBaseStats_ReturnDefaultRougeBaseStats()
        {
            //Arrange
            Rouge rouge = new Rouge("Rouge");
            Stats expected = new Stats(2, 6, 1);

            //Act
            Stats actual = rouge.BaseStats;

            //Assert
            Assert.Equal(expected.Strength, actual.Strength);
            Assert.Equal(expected.Dexterity, actual.Dexterity);
            Assert.Equal(expected.Intelligence, actual.Intelligence);
        }

        [Fact]
        public void ConstructorClassTypeMage_InitializeClassTypeMageWithDefaultBaseStats_ReturnDefaultMageBaseStats()
        {
            //Arrange
            Mage mage = new Mage("Mage");
            Stats expected = new Stats(1, 1, 8);

            //Act
            Stats actual = mage.BaseStats;

            //Assert
            Assert.Equal(expected.Strength, actual.Strength);
            Assert.Equal(expected.Dexterity, actual.Dexterity);
            Assert.Equal(expected.Intelligence, actual.Intelligence);
        }

        [Fact]
        public void ConstructorClassTypeWarrior_InitializeClassTypeWarriorWithDefaultBaseStats_ReturnDefaultWarriorBaseStats()
        {
            //Arrange
            Warrior warrior = new Warrior("Warrior");
            Stats expected = new Stats(5, 2, 1);

            //Act
            Stats actual = warrior.BaseStats;

            //Assert
            Assert.Equal(expected.Strength, actual.Strength);
            Assert.Equal(expected.Dexterity, actual.Dexterity);
            Assert.Equal(expected.Intelligence, actual.Intelligence);
        }

        [Fact]
        public void ConstructorClassTypeRanger_InitializeClassTypeRangerWithDefaultBaseStats_ReturnDefaultRangerBaseStats()
        {
            //Arrange
            Ranger ranger = new Ranger("Ranger");
            Stats expected = new Stats(1, 7, 1);

            //Act
            Stats actual = ranger.BaseStats;

            //Assert
            Assert.Equal(expected.Strength, actual.Strength);
            Assert.Equal(expected.Dexterity, actual.Dexterity);
            Assert.Equal(expected.Intelligence, actual.Intelligence);
        }

        [Fact]
        public void OnLevelUp_RougeBaseStatsIncreaseWithNewStats_ReturnNewRougeBaseStats()
        {
            //Arrange
            Rouge rouge = new Rouge("Rouge");
            rouge.LevelUp();
            Stats expected = new Stats(3, 10, 2);

            //Act
            Stats actual = rouge.BaseStats;

            //Assert
            Assert.Equal(expected.Strength, actual.Strength);
            Assert.Equal(expected.Dexterity, actual.Dexterity);
            Assert.Equal(expected.Intelligence, actual.Intelligence);
        }

        [Fact]
        public void OnLevelUp_MageBaseStatsIncreaseWithNewStats_ReturnNewMageBaseStats()
        {
            //Arrange
            Mage mage = new Mage("Mage");
            Stats expected = new Stats(1, 1, 8);

            //Act
            Stats actual = mage.BaseStats;

            //Assert
            Assert.Equal(expected.Strength, actual.Strength);
            Assert.Equal(expected.Dexterity, actual.Dexterity);
            Assert.Equal(expected.Intelligence, actual.Intelligence);
        }

        [Fact]
        public void OnLevelUp_WarriorBaseStatsIncreaseWithNewStats_ReturnNewWarriorBaseStats()
        {
            //Arrange
            Warrior warrior = new Warrior("Warrior");
            Stats expected = new Stats(5, 2, 1);

            //Act
            Stats actual = warrior.BaseStats;

            //Assert
            Assert.Equal(expected.Strength, actual.Strength);
            Assert.Equal(expected.Dexterity, actual.Dexterity);
            Assert.Equal(expected.Intelligence, actual.Intelligence);
        }

        [Fact]
        public void OnLevelUp_RangerBaseStatsIncreaseWithNewStats_ReturnNewRangerBaseStats()
        {
            //Arrange
            Ranger ranger = new Ranger("Ranger");
            Stats expected = new Stats(1, 7, 1);

            //Act
            Stats actual = ranger.BaseStats;

            //Assert
            Assert.Equal(expected.Strength, actual.Strength);
            Assert.Equal(expected.Dexterity, actual.Dexterity);
            Assert.Equal(expected.Intelligence, actual.Intelligence);
        }
    }
}

