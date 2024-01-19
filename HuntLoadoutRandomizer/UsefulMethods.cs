#nullable disable //  don't really know what this does tbh, is this needed? I don't know. TODO figure out if its needed
namespace HuntLoadoutRandomizer
{
    internal class UsefulMethods
    {

        public static bool DetermineIfQuartermaster()
        {
            Console.Write("Do you have the Quartermaster trait? (Please enter only \"Yes\" or \"No\"): ");
            string hasQuartermaster = "";
            try
            {
                hasQuartermaster = Console.ReadLine();
                if (hasQuartermaster != null)
                {
                    hasQuartermaster = hasQuartermaster.ToLower().Trim();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input! Please only enter \"Yes\" or \"No\". " + e.Message);
            }

            while ((hasQuartermaster.ToLower().Trim() != "no") && (hasQuartermaster.ToLower().Trim() != "yes") && (hasQuartermaster.ToLower().Trim() != "n") && (hasQuartermaster.ToLower().Trim() != "y"))
            {
                Console.Write("Invalid input! Please only enter \"Yes\" or \"No\". \nDo you have the Quartermaster trait? ");
                try
                {
                    hasQuartermaster = Console.ReadLine();

                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid input! Please only enter \"Yes\" or \"No\". " + e.Message);
                }
            }
            if ((hasQuartermaster.ToLower().Trim()) == "y" || (hasQuartermaster.ToLower().Trim() == "yes"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool DetermineIfUserWantsAnotherLoadout()
        {
            Console.Write("Do you want another loadout? Please enter only \"Yes\" or \"No\": ");
            string wantsAnotherLoadout = "";
            try
            {
                wantsAnotherLoadout = Console.ReadLine();
                if (wantsAnotherLoadout != null)
                {
                    wantsAnotherLoadout = wantsAnotherLoadout.ToLower().Trim();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input! Please only enter \"Yes\" or \"No\". " + e.Message);
            }

            while ((wantsAnotherLoadout.ToLower().Trim() != "no") && (wantsAnotherLoadout.ToLower().Trim() != "yes") && (wantsAnotherLoadout.ToLower().Trim() != "n") && (wantsAnotherLoadout.ToLower().Trim() != "y"))
            {
                Console.Write("Invalid input! Please only enter \"Yes\" or \"No\". \nDo you want to generate another random loadout? ");
                try
                {
                    wantsAnotherLoadout = Console.ReadLine();

                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid input! Please only enter \"Yes\" or \"No\". " + e.Message);
                }
            }
            if ((wantsAnotherLoadout.ToLower().Trim()) == "y" || (wantsAnotherLoadout.ToLower().Trim() == "yes"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
