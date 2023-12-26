namespace JCD1._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva dois números");
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());

            if (number1 / number2 >= number2 / number1)
            {
                Console.WriteLine($"O resultado maior é {number1 / number2}");
            }
            else if (number2 / number1 >= number1 / number2) 
            {
                Console.WriteLine($"O resultado maior é o {number2 / number1}");
            }
        }
    }
}