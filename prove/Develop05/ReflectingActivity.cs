public class ReflectingActivity : Activity{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity()
    {
        
    }

    public void Run(){
        _name="Reflecting Activity";
        _description = @"This activity will help you reflect on times in your life when you have shown strength an0d 
        resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        
        DisplayStartingMessage();
       
        int timeSpinner = Math.Abs(_duration / 2);
        Console.Clear();
        base.DisplayGetReady(5);
        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine("\n--- Think of time when you did something really difficult. ---");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("\nNow ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(4);
        DateTime now = DateTime.Now;
        DateTime endTime = now.AddSeconds(_duration);
        while(DateTime.Now < endTime){      
            Console.Clear();       
             Console.Write("\n\n> How did you feel it was complete? ");
             ShowSpinner(timeSpinner);
             Console.Write("\n> What is your favorite thing about this experience? \n");
             ShowSpinner(timeSpinner);
        }    
        DisplayEndingMessage();
    }
    //public string GetRamdomomPrompt(){}
    //public string GetRandomQuestion(){}
    public void DisplayPropt(){}
    public void DisplayQuestion(){}

}