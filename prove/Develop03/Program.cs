using System;

class Program
{
    static void Main(string[] args)
    {
    //string scriptureText = @"If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not and it shall be given him.";
    string scriptureText = @"If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him. But let him ask in faith, nothing wavering. For he that wavereth is like a wave of the sea driven with the wind and tossed.";

    //reference
     // Reference reference = new Reference("James", 1, 5);
      Reference reference = new Reference("James", 1, 5,6);
      Scripture jamesScripture = new Scripture(reference, scriptureText);
      
      string option = "";
      while(option != "quit"){
        Console.Clear();
        Console.WriteLine(jamesScripture.GetDisplayText());
        Console.WriteLine($"{Environment.NewLine} Press enter to continue or 'quit' to finish:");
        option = Console.ReadLine();

        if(jamesScripture.IsCompletelyHidden())
            option = "quit";

        jamesScripture.HideRandomWords(3);       
        
    }
      
    }
}