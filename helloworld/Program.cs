using System;

class Program
{
    private static string hello_world = "Hello, World!";
    private static bool program_active = true;

    static void Main(string[] args)
    {   
        Console.WriteLine(hello_world + "\n");
        DisplayMenu();

        while ( program_active )
        {
            string user_input = Console.ReadLine();
            if ( user_input == "1" )
            {
                Console.WriteLine(hello_world + "\n");
            }
            else if ( user_input == "2" )
            {
                // Functionality here
            }
            else if ( user_input == "3" )
            {
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
        Console.WriteLine("MAIN MENU\n1 - Print text\n2 - Customize text\n3 - Exit program\n\nSelection: ");
    }
}