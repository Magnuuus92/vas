using System.Net.Quic;
using System.Runtime.InteropServices;
using Characters;
namespace MyProgram
{
    public class Program
    {
        public static void Main()
        {


            List<Player> party = new List<Player>
            {
                new Player("Magnus"),
                new Player("Magnus2")
            };
            List<Enemy> encounter1 = new List<Enemy>
            {
  new Enemy("goblin", 20, 5, 2, 50),
                new Enemy("big goblin", 28, 6, 5, 55)
            };
            //House1
            var bathroom = new Bathroom1();
            var entry = new Entry1();
            var guestroom = new Guestroom1();
            var hallway = new Hallwaymain1();
            var kitchen = new Kitchen1();
            var livingroom = new Livingroom1();
            var masterbedroom = new Masterbedroom1();
            //House2
            var bathroom2 = new Bathroom2();
            var entry2 = new Entry2();
            var guestroom2 = new Guestroom2();
            var hallway2 = new Hallwaymain2();
            var kitchen2 = new Kitchen2();
            var laundry2 = new Laundry2();
            var livingroom2 = new Livingroom2();
            var masterbedroom2 = new Masterbedroom2();
            //Outside1
            var backyard1 = new Backyard1();
            var porch1 = new Porch1();
            var shed1 = new Shed1();
            var street1 = new Street1();
            //Outside2
            var backyard2 = new Backyard2();
            var poolarea2 = new PoolArea2();
            var porch2 = new Porch2();
            var street2 = new Street2();


            //Connect House1
            bathroom.Connect("West", hallway);
            entry.Connect("North", hallway);
            entry.Connect("South", porch1);
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
            //Connect House2
            entry2.Connect("North", hallway2);
            entry2.Connect("South", porch2);
            hallway2.Connect("North-West", laundry2);
            hallway2.Connect("West", bathroom2);
            hallway2.Connect("South-West", livingroom2);
            hallway2.Connect("North-East", masterbedroom2);
            hallway2.Connect("East", guestroom2);
            hallway2.Connect("South-East", kitchen2);
            hallway2.Connect("South", entry2);
            livingroom2.Connect("East", hallway2);
            livingroom2.Connect("North", bathroom2);
            bathroom2.Connect("South", livingroom2);
            bathroom2.Connect("East", hallway2);
            laundry2.Connect("East", hallway2);
            masterbedroom2.Connect("West", hallway2);
            guestroom2.Connect("East", hallway2);
            kitchen2.Connect("East", hallway2);
            //Connect Outside1
            porch1.Connect("North", entry);
            porch1.Connect("South", street1);
            street1.Connect("North", porch1);
            street1.Connect("North-East", backyard1);
            street1.Connect("West", street2);
            backyard1.Connect("North", shed1);
            backyard1.Connect("South", street1);
            shed1.Connect("South", backyard1);
            //Connect Outside2
            porch2.Connect("North", entry2);
            porch2.Connect("South", street2);
            street2.Connect("North-East", backyard2);
            street2.Connect("North", porch2);
            //street2.Connect("West", street3)
            backyard2.Connect("North", poolarea2);
            backyard2.Connect("South", street2);
            poolarea2.Connect("South", backyard2);










            Room currentroom = entry;
            Player activePlayer = party[0];
            currentroom.OnEnter(activePlayer);
            string? command;

            while (true)
            {
                currentroom.Describe();
                Console.WriteLine("\nWhere do you want to go?(or 'quit')");
                command = Console.ReadLine()?.ToLower();

                if (command == "quit")
                    break;
                if (currentroom.Exits.TryGetValue(command, out Room? nextroom))
                {
                    currentroom = nextroom;
                    currentroom.OnEnter(activePlayer);
                }
                else
                {
                    Console.WriteLine("you cant go there");
                }
            }

            Console.WriteLine("PLACEHOLDER See you later");
        }
    }
}