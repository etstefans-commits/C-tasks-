Console.WriteLine("Enter a name");
string name = Console.ReadLine();

Console.WriteLine("Enter age");
string Age = Console.ReadLine();
int age = int.Parse(Age);

Console.WriteLine("Enter sum of the purchase");
string Bill = Console.ReadLine();
double bill = double.Parse(Bill);

double discount = 0;

if ((bill >= 50) && (bill <= 100))
{
    discount += bill * 0.05;
}
else if (bill > 100)
{
    discount += bill * 0.1;
}

if (age < 18)
{
    discount += bill * 0.02;
}

Console.WriteLine((name) + "'s purchase cost: " + (bill - discount));