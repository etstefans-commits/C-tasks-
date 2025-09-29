
string input = Console.ReadLine();
int year = int.Parse(input);

bool condition1 = (year % 4) == 0;
bool condition2 = (year % 100) != 0;
bool condition3 = (year % 400) == 0;
if ((condition1 && condition2) || condition3)
    Console.WriteLine("Leap year");
else
    Console.WriteLine("Normal year");