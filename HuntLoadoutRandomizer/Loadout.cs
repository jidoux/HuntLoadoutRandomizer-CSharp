namespace HuntLoadoutRandomizer
{
    internal class Loadout
    {
        public static Weapon GetWeaponData(List<string> listOfWeapons, int index)
        {
            Weapon weapon = new Weapon();
            string[] weaponData = listOfWeapons[index].Split(',');
            weapon.Name = weaponData[0];
            weapon.Size = weaponData[1];
            return weapon;
        }

        public static int GetRandomNumber(int weaponCount)
        {
            Random random = new Random();
            int randomNumber = random.Next(weaponCount);
            return randomNumber;
        }

        public static void GenerateRandomLoadout(List<string> listOfWeapons, bool hasQuartermaster, ref Weapon weapon1, ref Weapon weapon2)
        {
            int randomNumber = 0;
            bool loadoutDetermined = false;
            while (!loadoutDetermined)
            {
                randomNumber = GetRandomNumber(listOfWeapons.Count);
                weapon1 = GetWeaponData(listOfWeapons, randomNumber);

                randomNumber = GetRandomNumber(listOfWeapons.Count);
                weapon2 = GetWeaponData(listOfWeapons, randomNumber);

                if ((weapon1.Size == "large") && (weapon2.Size == "large"))
                {
                    loadoutDetermined = false;
                }
                else if ((!hasQuartermaster) && (weapon1.Size == "large") && (weapon2.Size == "medium"))
                {
                    loadoutDetermined = false;
                }
                else if ((!hasQuartermaster) && (weapon1.Size == "medium") && (weapon2.Size == "large"))
                {
                    loadoutDetermined = false;
                }
                else
                {
                    loadoutDetermined = true;
                }
            }
        }
    }
}
