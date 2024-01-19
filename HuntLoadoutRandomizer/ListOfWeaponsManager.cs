namespace HuntLoadoutRandomizer
{
    internal class ListOfWeaponsManager
    {
        // This method reads the listOfWeapons file and generates a list of every weapon, in the format Weapon,Size (just like the format in the file)
        public static void ReadFile(ref List<string> listOfWeapons)
        {
            string listOfWeaponsFilePath = Directory.GetCurrentDirectory() + "/ListOfHuntShowdownWeapons.yml";
            foreach (string line in File.ReadLines(listOfWeaponsFilePath))
            {
                if (!line.StartsWith('#'))
                {
                    listOfWeapons.Add(line);
                }
            }
        }
    }
}
