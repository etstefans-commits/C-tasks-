Console.WriteLine("Input a number: ");
int num = int.Parse(Console.ReadLine());
int max = int.MinValue;
Console.WriteLine("Enter " + num + " numbers:");
for (int i = 0; i < num; i++)
{
    int n = int.Parse(Console.ReadLine());
    if (n > max)
    {
        max = n;
    }
}
Console.WriteLine("The biggest number is: " + max);