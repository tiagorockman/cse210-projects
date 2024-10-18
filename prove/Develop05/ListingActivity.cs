public class ListingActivity : Activity{
    private int _count;
    private List<String> _prompts;

    public ListingActivity()
    {
        _prompts = new List<string>();
    }
    public void Run(){
        _name=$"Listing Activity";
        _description = @"This activity will help you reflect on the good things in your life by having you list as many things
        as you can in a certain area";

        DisplayStartingMessage();
       
        Console.Clear();
        base.DisplayGetReady(5);
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine(" --- When have you felt the Holy Ghost this month? ---");
        Console.Write("You may begin in: ");
        ShowCountDown(4);
        DateTime now = DateTime.Now;
        DateTime endTime = now.AddSeconds(_duration);
        _count = 0;
        while(DateTime.Now < endTime){             
            Console.WriteLine("> ");
           string text =  Console.ReadLine();
           _prompts.Add(text);
            _count++;
        }    
        Console.WriteLine($"You listed {_count} items!");
        DisplayEndingMessage();
    }
    public void GetRandomPrompt(){}
   // public List<String> GetListFromUser(){};

}