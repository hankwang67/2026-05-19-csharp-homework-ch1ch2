// 2-5.寫一程式，輸入x和y，如果x>=y，令z=x^2，否則令z=y^2
Console.WriteLine("輸入x和y，如果x>=y，令z=x^2，否則令z=y^2:");
double x = Convert.ToDouble(Console.ReadLine());
double y = Convert.ToDouble(Console.ReadLine());
double z = 0;
if (x >= y)
{
    z = x * x;
    Console.WriteLine($"z={z}");
}
else
{
    z = y * y;
    Console.WriteLine($"z={z}");
}