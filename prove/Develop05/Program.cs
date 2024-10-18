using System;

class Program
{
    static void Main(string[] args)
    {
       PresentMenu();
    }

    private static void ExecuteReflectingActivity()
    {
        var activity = new ReflectingActivity();
        activity.Run();
        PresentMenu();
    }

    private static void ExecuteBreathingActivity()
    {
        var activity = new BreathingActivity();
        activity.Run();
        PresentMenu();
    }

     private static void ExecuteListingActivity()
    {
         var activity = new ListingActivity();
        activity.Run();
        PresentMenu();
    }

    private static void PresentMenu()
    {
        Console.Clear();
        int option = 0;
        while(option <=0 || option>4){
            Console.WriteLine("Menu options.");
            Console.WriteLine("\t1. Start breathing activity.");
            Console.WriteLine("\t2. Start reflecting activity.");
            Console.WriteLine("\t3. Start listening activity.");
            Console.WriteLine("\t4. Quit");
            Console.WriteLine("Select a choice from menu.");
            option = int.Parse(Console.ReadLine());
        }
        
        switch(option){
            case 1:
                ExecuteBreathingActivity();
                break;
            case 2:
                ExecuteReflectingActivity();
                break;
            case 3:
                ExecuteListingActivity();
                break;
        }

    }

   
}