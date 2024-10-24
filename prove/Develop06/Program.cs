using System;

class Program
{
    static void Main(string[] args)
    {
       int option = Menu.PresentMenu();

        switch (option)
            {
                case 1:
                    ExecuteBreathingActivity();
                    break;
                case 2:
                    ExecuteReflectingActivity();
                    break;
                case 3:
                    ExecuteListingActivity();
                    break;
                case 4:
                    return;
            }
    }

 

}