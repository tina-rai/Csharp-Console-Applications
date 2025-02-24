using System;
using System.Collections.Generic;
using System.IO;

public class ToDoListManager
{
private static string filePath = "tasks.txt";
private static List<string> tasks = new List<string>();
public static void Start()
{
  
  LoadTasks(); //load tasks from file

       while(true)
       {
           Console.WriteLine("To-Do List Manager");
           Console.WriteLine("1. Add task");
           Console.WriteLine("2. View tasks");
           Console.WriteLine("3. Delete task");
           Console.WriteLine("4. Exit");
           Console.WriteLine("Choose an option:");
           string? option= Console.ReadLine();
           switch(option)
           {
               case "1":
               AddTask();
               break;
               case "2":
               ViewTasks();
               break;
               case "3":
               DeleteTask();
               break;
             //ase "4":
             //SaveTasks(); //save tasks to file
             //Environment.Exit(0);
             //break;
               default:
               Console.WriteLine("Invalid option");
               break;
           }
       }    
}
    public static void LoadTasks()
    {
        if(File.Exists(filePath))
        {
            tasks= new List<string>(File.ReadAllLines(filePath));
        }
    }
    public static void AddTask()
    {
        Console.WriteLine("Enter task:");
        string? task= Console.ReadLine();
        tasks.Add(task!);
        Console.WriteLine("Task added successfully");
    }

   public static void ViewTasks()
    {
        if(tasks.Count==0)
        {
            Console.WriteLine("No tasks");
        }
        else
        {
            for(int i=0; i<tasks.Count; i++)
            {
                Console.WriteLine($"{i+1}. {tasks[i]}");
            }
        }
    }

    public static void DeleteTask()
    {
        ViewTasks();
        Console.WriteLine("Enter task number to delete:");
        int taskNumber= Convert.ToInt32(Console.ReadLine());
        if(taskNumber>0 && taskNumber<=tasks.Count)
        {
            tasks.RemoveAt(taskNumber-1);
            Console.WriteLine("Task deleted successfully");
        }
        else
        {
            Console.WriteLine("Invalid task number");
        }
    }
}

