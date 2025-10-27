//Console.WriteLine("Input a number for a: ");
//string inputa = Console.ReadLine();
//double a = double.Parse(inputa);

//Console.WriteLine("Input a number for b: ");
//string inputb = Console.ReadLine();
//double b = double.Parse(inputb);

//Console.WriteLine("Sum: " + (a + b));
//Console.WriteLine("Difference: " + (a - b));
//Console.WriteLine("Product: " + (a * b));

//if (b == 0)
//{
//    Console.WriteLine("Division: Operation Impossible!");
//}
//else
//{
//    Console.WriteLine("Division: " + a / b);
//}

Console.WriteLine("Input a number for a: ");
string inputA = Console.ReadLine();
double a = double.Parse(inputA);

Console.WriteLine("Input a number for b: ");
string inputB = Console.ReadLine();
double b = double.Parse(inputB);

Console.WriteLine("Input a number for c: ");
string inputC = Console.ReadLine();
double c = double.Parse(inputC);

double D = (b * b) - (4 * a * c);

if (D > 0)
{
    double x1 = 0;
    double x2 = 0;

    x1 = (-b + D) / 2;
    x2 = (-b - D) / (2 * a);

    Console.WriteLine("x1: " + x1);
    Console.WriteLine("x2: " + x2);
}
else if (D == 0)
{
    double x1 = -b / (2 * a);
    double x2 = -b / (2 * a);

    Console.WriteLine("x1: " + x1);
    Console.WriteLine("x2: " + x2);
}
else
{
    Console.WriteLine("Operation Impossible");
}