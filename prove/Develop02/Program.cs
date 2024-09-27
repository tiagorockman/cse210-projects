using System;
using System.Reflection;
//Exceed Requirements
//On the Load method I added an option to see files names already saved before, to choose which of them do you want to open.
class Program
{
    protected static List<Journal> _journalContent = [];
    static void Main(string[] args)
    {
       
        var questionList = new Question();
       

        int option =-1;
        Console.WriteLine("Please Select One of the following:");
        
        while(option !=5){
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            option = int.Parse(Console.ReadLine());

            switch(option)
            {
                 case 1: 
                    ActionWrite(questionList);
                    break;
                case 2:
                    ActionDisplay();
                    break;
                case 3:
                    ActionLoad();
                    break;
                case 4:
                    ActionSave();
                    break;
                default:
                    break;
            }
        }
    }

    private static void ActionSave()
    {
        Console.WriteLine("What is the filename");
        string filename = Console.ReadLine();

        using (var writer = new StreamWriter(filename)){
            foreach(var journal in _journalContent){
                    writer.WriteLine($"{journal.Date}|{journal.Prompt}|{journal.Answer}");
            }
       }
    }

    private static void ActionLoad()
    {
        try{
         Console.WriteLine("What is the filename, type 0 if you want to see the files name already saved before. Only .csv or .txt files.");
         string filename = Console.ReadLine();

         if(filename == "0")
            {
                var files = Directory.GetFiles(Directory.GetCurrentDirectory());
                foreach(var selectedFile in files) //select only files with txt in the name
                {
                    string fileName = Path.GetFileName(selectedFile);
                    if(selectedFile.Contains(".txt") || selectedFile.Contains(".csv"))
                        Console.Write($" {fileName} |");
                }
                 Console.WriteLine("\nWhat is the filename do you choose?");
                 filename = Console.ReadLine();
            }
        
         _journalContent.Clear();

         string [] lines = System.IO.File.ReadAllLines(filename);
         foreach(var line in lines){
            Journal journal = new Journal();
            string[] pos = line.Split("|");
            journal.Date = pos[0];
            journal.Prompt = pos[1];
            journal.Answer = pos[2];
            _journalContent.Add(journal);
         }

         }catch(Exception ex){
            Console.WriteLine($"Error: {ex.Message}");
         }
    }

    private static void ActionDisplay()
    {
        foreach(var ans in _journalContent){
            Console.WriteLine($"Date: {ans.Date} - Prompt: {ans.Prompt}");
            Console.WriteLine(ans.Answer + Environment.NewLine);
        }
    }

    private static void ActionWrite(Question questionList)
    {
       
        var journalContent = new Journal();
         string question = GetQuestion(questionList);
         Console.WriteLine(question);
         journalContent.Date = DateTime.Now.ToString("dd/MM/yyyy");
         journalContent.Prompt = question;
         journalContent.Answer = Console.ReadLine();

         _journalContent.Add(journalContent);

    }

    private static string GetQuestion(Question questionList){
         var rand = new Random();
        int indexQuestion = rand.Next(0, questionList.journalQuestions.Count());
       return questionList.journalQuestions[indexQuestion];

    }
}