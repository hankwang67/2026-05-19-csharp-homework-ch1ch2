// 2-7.寫一程式，輸入x和y，去判斷最終結果
Console.WriteLine("輸入x和y，去判斷最終結果:");
double x = Convert.ToDouble(Console.ReadLine());
double y = Convert.ToDouble(Console.ReadLine());

if (x > 0)
{
    if (y > 0)
    {
        Console.WriteLine("1st quadrant");
    }
    else if (y == 0)
    {
        Console.WriteLine("X-axis");
    }
    else
        Console.WriteLine("4st quadrant");
}
else if (x == 0)
{
    if (y == 0)
    {
        Console.WriteLine("Origin");
    }
    else
        Console.WriteLine("X-axis");
}
else if (y > 0)
{
    Console.WriteLine("2nd quadrant");
}
else if (y == 0)
{
    Console.WriteLine("X-axis");
}
else
    Console.WriteLine("3th quadrant");