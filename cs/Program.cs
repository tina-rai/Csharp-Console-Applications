using System;
class Program
{
    static void Main()
    {
        // Create an instance of Calculator and run it
        //Calculator calc = new Calculator();
        //calc.RunCalculator(); // Calls the method in Calculator.cs
    

     
        // Create an instance of ToDoListManager and run it
           // Load tasks from file at the beginning
        //ToDoListManager.LoadTasks();

        
        
        // Start the To-Do List Manager
     // ToDoListManager.Start();

       
       
       //Guess game
        //GuessGame game = new GuessGame(); //creates an obj of GuessGame class
        //game.Start();

     
     
      //bank CLI
          //BankSystem bank = new BankSystem();
       // bank.Start();


         
        //File Organizer
         FileOrganizer organizer = new FileOrganizer();
        Console.Write("Enter directory path: ");
        string? directoryPath = Console.ReadLine();
         organizer.OrganizeFiles(directoryPath!);
    }
}
