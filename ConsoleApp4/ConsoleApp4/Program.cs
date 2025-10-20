//int counter = 0;
//while (counter < 10)
//{
//    Console.WriteLine("text");
//    counter++;
//}

//for (int interator = 0; interator < 10; interator++)
//{
//    Console.WriteLine(interator);
//}

string input = Console.ReadLine();
int n = int.Parse(input);
int sum = 0;
int product = 1;
for (int i = 0; i < n; ++i)
{
    sum += i;
    product *= i;
    Console.WriteLine("Sum: " + i.ToString() + " " + sum.ToString());
    Console.WriteLine("Product: " + i.ToString() + " " + sum.ToString());
}
Console.WriteLine(sum);
Console.WriteLine(product);

for (int i = 1; i <= n; ++i)
{
    Console.WriteLine(i);
}