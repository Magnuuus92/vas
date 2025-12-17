using System.Net.Quic;

public class Program
{
    public static void Main()
    {
        var bathroom = new Bathroom1();
        var entry = new Entry1();
        var guestroom = new Guestroom1();
        var hallway = new Hallwaymain1();
        var kitchen = new Kitchen1();
        var livingroom = new Livingroom1();
        var masterbedroom = new Masterbedroom1();

        bathroom.Connect("West", hallway);
        entry.Connect("North", hallway);
        guestroom.Connect("West", hallway);
        hallway.Connect("South", entry);
        hallway.Connect("South-East", bathroom);
        hallway.Connect("East", guestroom);
        hallway.Connect("North-East", masterbedroom);
        hallway.Connect("North-West", livingroom);
        hallway.Connect("South-West", kitchen);
        kitchen.Connect("East", hallway);
        kitchen.Connect("North", livingroom);
        livingroom.Connect("East", hallway);
        livingroom.Connect("South", kitchen);
        masterbedroom.Connect("West", hallway);


        Room currentroom = entry;
        string? command;

        while (true)
        {
            currentroom.Describe();
            Console.WriteLine("\nWhere do you want to go?(or 'quit')");
            command = Console.ReadLine()?.ToLower();

            if (command == "quit")
                break;
            if (currentroom.Exits.ContainsKey(command))
            {
                currentroom = currentroom.Exits[command];
            }
            else
            {
                Console.WriteLine("you cant go there");
            }
        }

        Console.WriteLine("PLACEHOLDER See you later");
    }
}