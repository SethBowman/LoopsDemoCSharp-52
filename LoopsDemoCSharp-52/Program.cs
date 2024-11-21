namespace LoopsDemoCSharp_52;

class Program
{
    static void Main(string[] args)
    {
        //while loop
        Console.WriteLine("WHILE LOOP:");

        // var cont = "yes";
        //
        // while (cont == "yes")
        // {
        //     Console.WriteLine("Continue? Type 'yes' or 'no'");
        //     cont = Console.ReadLine();
        // }

        var number = 1;

        while (number <= 5)
        {
            Console.WriteLine(number);
            number++;
        }
        
        //do while loop
        Console.WriteLine("DO WHILE LOOP:");

        number = 1;
        
        do
        {
            Console.WriteLine(number);
            number++;
            
        } while (number <= 10);
        
        //for loop
        Console.WriteLine("FOR LOOP:");

        for (int i = 1; i <= 20; i++)
        {
            Console.WriteLine(i);
        }

        for (int i = 100; i >= 1; i--)
        {
            Console.WriteLine(i);
        }

        for (int i = 3; i <= 999; i+=3)
        {
            Console.WriteLine(i);
        }
        
        //foreach loop
        Console.WriteLine("FOREACH LOOP:");

        var numbers = new int[] { 23, 4, 34, 456, 656, 777, 88, 10 };

        foreach (var num in numbers)
        {
            Console.WriteLine(num);
        }

    }
}
