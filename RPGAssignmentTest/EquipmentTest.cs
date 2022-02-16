using RPGAssignment.Characters;
using RPGAssignment.Factory;
using RPGAssignment.Items;
using Xunit;

namespace RPGAssignmentTest
{
    public class EquipmentTest
    {
        [Fact]
        public void CheckEquipWeapon_ThrowInvalidWeaponExceptionErrorIfCharacterLevelIsTooLowForThisWeapon_ThrowsInvalidWeaponExceptionErrorMessage()
        {
            //Arrange
            Warrior warrior = new Warrior("warrior");
            Weapon axe = WeaponFactory.CreateAxeLvl2();
            warrior.CheckEquipWeapon(axe);

            //Act
            var actual = warrior.CheckEquipWeapon(axe);

            //Assert
            Assert.Equal("Your level is too low to equip this weapon. Required level = 2. Current level = 1", actual);
        }

        [Fact]
        public void CheckEquipArmor_ThrowInvalidArmorExceptionErrorIfCharacterLevelIsTooLowForThisArmor_ThrowsInvalidArmorExceptionErrorMessage()
        {
            //Arrange
            Warrior warrior = new Warrior("warrior");
            Armor plateArmor = ArmorFactory.CreatePlateBodyLvl2();
            warrior.CheckEquipArmor(plateArmor);

            //Act
            var actual = warrior.CheckEquipArmor(plateArmor);

            //Assert
            Assert.Equal("Your level is too low to equip this armor. Required level = 2. Current level = 1", actual);
        }

        [Fact]
        public void CheckEquipArmor_ThrowInvalidArmorExceptionErrorIfCharacterCanNotEquipThisArmorType_ThrowsInvalidArmorExceptionErrorMessage()
        {
            //Arrange
            Warrior warrior = new Warrior("warrior");
            Armor cloth = ArmorFactory.CreateClothHead();
            warrior.CheckEquipArmor(cloth);

            //Act
            var actual = warrior.CheckEquipArmor(cloth);

            //Assert
            Assert.Equal("You are the wrong class to equip this armor", actual);
        }

        [Fact]
        public void CheckEquipWeapon_ThrowInvalidWeaponExceptionErrorIfCharacterCanNotEquipThisWeaponType_ThrowsInvalidWeaponExceptionErrorMessage()
        {
            //Arrange
            Warrior warrior = new Warrior("warrior");
            Weapon bow = WeaponFactory.CreateBow();
            warrior.CheckEquipWeapon(bow);

            //Act
            var actual = warrior.CheckEquipWeapon(bow);

            //Assert
            Assert.Equal("New weapon equipped!", actual);
        }

        [Fact]
        public void CheckEquipArmor_IfEquipAValidArmor_ReturnArmorSuccessMessage()
        {
            //Arrange
            Warrior warrior = new Warrior("warrior");
            Armor plateArmor = ArmorFactory.CreatePlateBody();
            warrior.CheckEquipArmor(plateArmor);

            //Act
            var actual = warrior.CheckEquipArmor(plateArmor);

            //Assert
            Assert.Equal("New armor equipped!", actual);
        }

        [Fact]
        public void GetDamage_CalculateDamageIfNoWeaponEquipped_ReturnCalculatedDamage()
        {
            //    //Arrange
            Warrior warrior = new Warrior("Warrior");
            warrior.GetDamage();
            var expected = 1 * (1 + (5 / 100));

            //Act
            var actual = warrior.GetDamage();

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetDamage_CalculateDamageWithWeaponEquipped_ReturnCalculatedDamageWithWeapon()
        {
            //    //Arrange
            Warrior warrior = new Warrior("Warrior");
            Weapon axeLvl2 = WeaponFactory.CreateAxeLvl2();

            warrior.LevelUp();
            warrior.EquipItem(axeLvl2);
            warrior.GetDamage();
            double expected = (7 * 1.1) * (1 + (5 / 100));

            //Act
            var actual = warrior.GetDamage();

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetDamage_CalculateDamageWithWeaponAndArmorEquipped_ReturnCalculatedDamageWithWeaponAndArmor()
        {
            //    //Arrange
            Warrior warrior = new Warrior("Warrior");
            Weapon axeLvl2 = WeaponFactory.CreateAxeLvl2();
            Armor plateArmorLvl2 = ArmorFactory.CreatePlateBodyLvl2();

            warrior.LevelUp();
            warrior.EquipItem(axeLvl2);
            warrior.EquipItem(plateArmorLvl2);
            warrior.GetDamage();
            double expected = (7 * 1.1) * (1 + ((5 + 1) / 100));

            //Act
            var actual = warrior.GetDamage();

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
