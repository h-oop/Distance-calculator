// distance calculator
#nullable disable

//welcome
Console.Clear();
Console.WriteLine("Welcome to distance calc hee hoo.");

//input
Console.Write("enter x1: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("enter y1: ");
double y = Convert.ToDouble(Console.ReadLine());
Console.Write("enter x2: ");
double xx = Convert.ToDouble(Console.ReadLine());
Console.Write("enter y2: ");
double yy = Convert.ToDouble(Console.ReadLine());

//process
double distance = Math.Sqrt(Math.Pow((xx-x), 2) + Math.Pow((yy-y), 2));

//output
Console.WriteLine($"Distance is {distance}");