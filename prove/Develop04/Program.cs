using System;

class Program
{
    static void Main(string[] args)
    {
        
        Menu menu = new Menu();
        BreathingActivity breathing = new BreathingActivity();
        ReflectingActivity reflecting = new ReflectingActivity();
        ListingActivity listing = new ListingActivity();
        

        int userInputMenuInt;
        
        int numberOfActivities = 0;

        do
        {
            menu.DisplayMenu();
            string userInputMenu = Console.ReadLine();
            userInputMenuInt = int.Parse(userInputMenu);

            if (userInputMenuInt == 1)
            {
                breathing.StartingMessage();

                breathing.RunBreathingActivity();

                breathing.EndingMessage();
            }
            else if (userInputMenuInt == 2)
            {
                reflecting.StartingMessage();

                reflecting.DisplayReflectionPrompt();
                reflecting.DisplayReflectionQuestion();
                
                reflecting.EndingMessage();
                   
            }
            else if (userInputMenuInt == 3)
            {
                listing.StartingMessage();

                listing.DisplayListingQuestionAndCounter();
                listing.WritingListing();
                
                listing.EndingMessage();
            }

            if (userInputMenuInt != 4)
            {
                numberOfActivities++;
            }

        } while (userInputMenuInt != 4);


        if (numberOfActivities == 0)
        {
            Console.WriteLine($"\nYou didn't do any activity. Whenever you want, come and relax. :)");
        }
        else if (numberOfActivities == 1)
        {
            Console.WriteLine($"\nYou just did {numberOfActivities} activity. Whenever you want, come and relax more. :)");
        }
        else
        {
            Console.WriteLine($"\nGreat! You did {numberOfActivities} activities. Whenever you want, come and relax more. :)");
        }
    }
}