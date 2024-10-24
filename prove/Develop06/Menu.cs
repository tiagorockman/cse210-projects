public class Menu {
    private int _option;

    public Menu()
    {
        _option = -1;
    }

    public static int PresentMenu()
    {
        try
        {
            Console.Clear();
            int option = 0;
            while (option <= 0 || option > 4)
            {
                Console.WriteLine("Menu options.");
                Console.WriteLine("\t1. Create new Goal.");
                Console.WriteLine("\t2. List Goals.");
                Console.WriteLine("\t3. Save Goals.");
                Console.WriteLine("\t4. Load Goals.");
                Console.WriteLine("\t5. Record Event.");
                Console.WriteLine("\t6. Quit");
                Console.WriteLine("Select a choice from menu.");
                option = int.Parse(Console.ReadLine());
            }
            return option;
           
        }
        catch(Exception)
        {
           return PresentMenu();
        }
    }
}