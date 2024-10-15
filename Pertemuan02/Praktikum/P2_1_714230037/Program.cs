Console.Write("a: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("b: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"""
a + b = {a + b}
a - b = {a - b}
a x b = {a * b}
a / b = {a / b}
""");
