string num = Console.ReadLine();
int n = int.Parse(num);

for (int i = 0; i < n; i++)
{
    if ((i % 2) == 0)
        Console.WriteLine(i);
}