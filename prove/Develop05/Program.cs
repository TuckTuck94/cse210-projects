using System;

class Program
{
    static void Main(string[] args)
    {
        int totalPoints;
        List<Goal> goals = new List<Goal>();
        // totalPoints += goal.RecordEvent
        // create a menu
        // capture the user input
        // execute action using a swith and case statement
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.WriteLine("Please Enter a Number:");

        string option = Console.ReadLine();

        switch(option)
        {
            case "1":
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                Console.WriteLine("What Goal Would You Like?:");
                string goalNumber = Console.ReadLine();

                switch(goalNumber)
                {
                    case "1":
                        // prompt the user for all necessary information (arguments) prompt name, dscription, points
                        // name = ...
                        // desc = ...
                        // points ...
                        Console.WriteLine("What is your goal?:");
                        string name = Console.ReadLine();
                        Console.WriteLine("What is a Description of the Goal?:");
                        string description = Console.ReadLine();
                        Console.WriteLine("How Many Points Will It Award?:");
                        int points = int.Parse(Console.ReadLine());
                        SimpleGoal simple = new SimpleGoal(name, description, points); //SimpleGoal(name, desc, points)
                        goals.Add(simple);
                        break;
                    case "2":
                        Console.WriteLine("What is your goal?:");
                        name = Console.ReadLine();
                        Console.WriteLine("What is a Description of the Goal?:");
                        description = Console.ReadLine();
                        Console.WriteLine("How Many Points Will It Award?:");
                        points = int.Parse(Console.ReadLine());
                        EternalGoal eternal = new EternalGoal(name, description, points);
                        goals.Add(eternal);
                        break;
                    case "3":
                        Console.WriteLine("What is your goal?:");
                        name = Console.ReadLine();
                        Console.WriteLine("What is a Description of the Goal?:");
                        description = Console.ReadLine();
                        Console.WriteLine("How Many Points Will It Award?:");
                        points = int.Parse(Console.ReadLine());
                        Console.WriteLine("How Many Times do you want to complete this goal?");
                        int target = int.Parse(Console.ReadLine());
                        Console.WriteLine("How many bonus points will it reward?:");
                        int bonuspoints = int.Parse(Console.ReadLine()); 
                        ChecklistGoal checklist = new ChecklistGoal(name, description, points, bonuspoints, target);
                        
                       
                        goals.Add(checklist);
                        break;
                }
                break;
            case "2":
            //Display the List of Goals added.
            Console.WriteLine(goals);
            {
                
            }
            break;
            case "3":
            //prompt for filename
            //get filename
            //call save method
            break;
            case "4":
            break;
            // Load Files
            case "5":
            //Record Events
            break;
            case "6":
            break;
        }
    }
}