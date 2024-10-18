public class BreathingActivity : Activity{
    public BreathingActivity()
    {
        
    }

    public void Run(){
        
        DisplayStartingMessage();
        DateTime now = DateTime.Now;
        DateTime endTime = now.AddSeconds(_duration);
        Console.Clear();
        base.DisplayGetReady(5);
        while(DateTime.Now < endTime){             
             Console.Write("\n\nBreathe in...");
             ShowCountDown(4);
             Console.Write("\nNow you breathe out...");
             ShowCountDown(6);
        }    
        DisplayEndingMessage();
    }
}