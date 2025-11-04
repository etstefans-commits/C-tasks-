//int num = int.Parse(Console.ReadLine());
//while (num >= 10)
//{
//    Console.WriteLine(num % 10);
//    num = num / 10;
//}
//Console.WriteLine(num);

int primeNumber = int.Parse(Console.ReadLine());
for (int i = 2;  i < primeNumber; i++)
{
    if (primeNumber % i == 0)
    {
        Console.WriteLine(i + " is not a prime number");
        break;
    }
}