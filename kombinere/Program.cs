namespace kombinere;

class Program
{
       static double getuserinput(string input)
       {Console.WriteLine(input);
       return Convert.ToDouble(Console.ReadLine());
       }
       static double addition(double in1, double in2){
        Console.WriteLine("addition");
    return in1 + in2;
    }
    static double addition(double in1, double in2, double in3){
        return in1 + in2 + in3;
    }
    static double addition(double in1, double in2, double in3, double in4){
        return in1 + in2 + in3 + in4;
    }
    static void Main(string[] args)
    {
 double a1 = getuserinput("give me a 1");
 double a2 = getuserinput("give me a 2");
 double a3 = getuserinput("give me a 3");
 double a4 = getuserinput("give me a 4");
      /*  Console.WriteLine("Give me a number:");
        double in1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("give me another number");
        double in2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("gimme a third");
        double in3 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Give me the fourth and final number");
        double in4 = Convert.ToDouble(Console.ReadLine());*/

    Console.WriteLine("Sum = " + addition(a1,a2));
    Console.WriteLine("Sum = " + addition(a1,a2,a3));
   Console.WriteLine("Sum = " + addition(a1,a2,a3,a4));
    //Console.WriteLine(in1);
    }

}
