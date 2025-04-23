using System;

class Program
{
    private static string hello_world = "Hello World!";
    private static bool program_active = true;

    static void Main(string[] args)
    {   
        Console.Clear();
        Console.WriteLine(hello_world + "\n");
        DisplayMenu();

        while ( program_active )
        {   
            Console.Write("Selection: ");
            string user_input = Console.ReadLine();
            if ( user_input == "1" )
            {
                Console.WriteLine($"\n{hello_world}\n");
            }
            else if ( user_input == "2" )
            {
                Console.Write("Please type the new message: ");
                hello_world = Console.ReadLine();
                Console.WriteLine("Message updated to '" + hello_world + "'\n");
            }
            else if ( user_input == "3" )
            {
                Console.WriteLine("Thank you for using Hello World Outline!\n");
                program_active = false;
            }
            else
            {
                Console.WriteLine("This input is invalid; please choose an acceptable option.");
            }
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("MAIN MENU\n1 - Print message\n2 - Update message\n3 - Exit program");
    }
}