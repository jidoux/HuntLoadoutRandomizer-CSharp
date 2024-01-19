namespace HuntLoadoutRandomizer
{
    internal class Weapon
    {
        private string name;
        private string size;

        public Weapon()
        {
            name = "Unknown";
            size = "Unknown";
        }
        public Weapon(string name, string size)
        {
            Name = name;
            Size = size;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Size
        {
            get { return size; }
            set
            {
                value = value.ToLower();
                if ((value == "small") || (value == "medium") || (value == "large"))
                {
                    size = value;
                }
            }
        }

        // This method is purely for testing purposes, as it prints the weapon data of any Weapon object.
        public void PrintWeaponData()
        {
            Console.WriteLine("Weapon name is: " + Name);
            Console.WriteLine("Weapon size is: " + Size);
        }
    }
}
