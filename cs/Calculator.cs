using System;

   public class Calculator{

    public void RunCalculator()
    {
        Console.WriteLine("hello world");
        Console.WriteLine("your name?");
        string? name= Console.ReadLine();
        Console.WriteLine("hello "+name);

    Console.WriteLine("Let's do some maths");
    Console.WriteLine("Enter a number:");    
    double num1= Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter another number:");
    double num2= Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Choose an operator: +, -, *, /");
    string? op= Console.ReadLine();

    switch(op)
    {
        case "+":
        Console.WriteLine($"Result of {num1}{op}{num2} is {num1+num2}");
        break;
        case "-":
        Console.WriteLine($"Result of {num1}{op}{num2} is {num1-num2}");
        break;
        case "*":
        Console.WriteLine($"Result of {num1}{op}{num2} is {num1*num2}");
        break;
        case "/":
        if(num2==0)
        {
            Console.WriteLine("Cannot divide by zero");
        }
        else
        Console.WriteLine($"Result of {num1}{op}{num2} is {num1/num2}");
        break;
        default:
        Console.WriteLine("Invalid operator");
        break;  
    
    }
    }
   }

   