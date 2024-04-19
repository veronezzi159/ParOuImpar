decimal number;

Console.WriteLine("Digite um número");
number = decimal.Parse(Console.ReadLine()); 

if (number % 2 == 0) 
{
    Console.WriteLine(number + " É par");

} else
{
    Console.WriteLine(number + " É ímpar");
}
