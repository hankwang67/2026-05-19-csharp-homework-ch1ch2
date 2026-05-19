// 寫一程式，輸入一組二元一次方程式之係數，輸出方程式的解。
Console.WriteLine("輸入一組二元一次方程式之係數，輸出方程式的解：");
double a1 = Convert.ToDouble(Console.ReadLine());
double b1 = Convert.ToDouble(Console.ReadLine());
double c1 = Convert.ToDouble(Console.ReadLine());
double a2 = Convert.ToDouble(Console.ReadLine());
double b2 = Convert.ToDouble(Console.ReadLine());
double c2 = Convert.ToDouble(Console.ReadLine());
double delta = a1*b2-a2*b1;
double deltaX = c1*b2-c2*b1;
double deltaY = a1*c2-a2*c1;
if(delta!=0)
{
Console.WriteLine($"X={deltaX/delta},Y={deltaY/delta}");
}
else
{
    if(deltaX==0 && deltaY ==0)
    {
        Console.WriteLine("無限多組解");
    }
    else
    {
        Console.WriteLine("無解");
    }
}