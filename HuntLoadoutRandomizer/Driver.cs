// This program is a hunt showdown loadout randomizer. It reads a file of a list of weapons and outputs 2 guns/weapons, which CAN be the same gun by the way.
// It will have a loadout object with 3 attributes, a bool hasQuartermaster, and 2 strings weapon1 and weapon2.

namespace HuntLoadoutRandomizer
{
    class Driver
    {
        public static void Main(string[] args)
        {

            List<string> listOfWeapons = []; //Its basically initialized the same way as an array, with new keyword, but this is a built-in easier way to do it
            ListOfWeaponsManager.ReadFile(ref listOfWeapons);

            Console.WriteLine("Welcome to the Hunt Showdown loadout randomizer!");
            bool hasQuartermaster = UsefulMethods.DetermineIfQuartermaster();

            bool giveLoadouts = true;

            Weapon weapon1 = new Weapon();
            Weapon weapon2 = new Weapon();
            while (giveLoadouts)
            {
                Loadout.GenerateRandomLoadout(listOfWeapons, hasQuartermaster, ref weapon1, ref weapon2);

                Console.WriteLine(String.Format("\nYour loadout is {0} and {1}!", weapon1.Name, weapon2.Name));
                giveLoadouts = UsefulMethods.DetermineIfUserWantsAnotherLoadout();

            }
        }
    }
}
