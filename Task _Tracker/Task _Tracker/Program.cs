using System;


namespace Task_Tracker
{
    internal class Program
    {

        static string[] Tasks = new string[100];
       static  short TaskIndex = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TaskTracker");
            Console.WriteLine("----------------------");
            while (true)
            {
                Console.WriteLine("You have 5 options");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. View Tasks");
                Console.WriteLine("3. Mark Complete");
                Console.WriteLine("4. Delete Task");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Your Choice??");
                string choice=Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        // Add
                        Add();
                        break;
                    case "2":
                        // View 
                        ViewTasks();

                        break;
                    case "3":
                        // Mark Complate
                        MarkComplate();
                        break;
                    case "4":
                        // Delete
                        Delete();
                        break;
                    case "5":
                        // Exit
                        Environment.Exit(0);

                        break;
                    default:
                        Console.WriteLine("Must be choice from 1 to 5");
                        Console.WriteLine("--------------------------");
                        break;

                }

            }

        }
        static void Add()
        {
            Console.WriteLine("Enter a name of Task do you went to Add");
            string name=Console.ReadLine();
            Tasks[TaskIndex] = name;
            TaskIndex++;
            Console.WriteLine("Task Add");
        }
        static void ViewTasks()
        {
            short counter = 1;
            Console.WriteLine("Task List");
            for (int i = 0; i < TaskIndex; i++)
            {
                if (Tasks[i] != "")
                {
                    
                    Console.WriteLine($"Task info: {counter}.{Tasks[i]}");
                    counter++;
                }
            }
        }
        static void MarkComplate()
        {
            Console.WriteLine("Enter a number of task do you went to complate");
            int number;
            if(int.TryParse(Console.ReadLine(), out number))
            {
                Tasks[number - 1] = Tasks[number - 1] + "--Complate";
                Console.WriteLine("Mark Complate Done");

            }
            else
            {
                Console.WriteLine("Fail to done");
            }
           

        }
        static void Delete()
        {
            Console.WriteLine("Enter a number of task do you went to Delete");
            int number;
           if( int.TryParse(Console.ReadLine(), out number))
            {
                //Tasks[number - 1] = "";
                for (int i = number - 1; i < TaskIndex - 1; i++)
                {
                    Tasks[i] = Tasks[i + 1];
                }
                Tasks[TaskIndex - 1] = null;
                TaskIndex--;
                Console.WriteLine("Delete Done");
            }

          
            else
            {
                Console.WriteLine("Fail to done");

            }
          
          
        }
    }
}
