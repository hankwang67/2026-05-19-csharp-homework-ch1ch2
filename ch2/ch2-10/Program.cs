// 補充3.請隨意輸入三個數x,y,z，請由大到小依序印出。
Console.WriteLine("請隨意輸入三個數x,y,z，請由大到小依序印出:");
double x = Convert.ToDouble(Console.ReadLine());
double y = Convert.ToDouble(Console.ReadLine());
double z = Convert.ToDouble(Console.ReadLine());

if (x > y && x > z)
{
    if (y > z)
    {
        Console.WriteLine($"{x},{y},{z}");
    }
    else
        Console.WriteLine($"{x},{z},{y}");
}
else if (y > z && y > x)
{
    if (x > z)
    {
        Console.WriteLine($"{y},{x},{z}");
    }
    else
        Console.WriteLine($"{y},{z},{x}");
}
else 
{
    if(x>y)
    Console.WriteLine($"{z},{x},{y}");
    else
    Console.WriteLine($"{z},{y},{x}");
}