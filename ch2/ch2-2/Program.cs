// 2-2.寫一程式，輸入x和y，如果x和y都是正數，令z=1，如兩者均為負數，令z=-1，否則令z=0
Console.WriteLine("輸入x和y，如果x和y都是正數，令z=1，如兩者均為負數，令z=-1，否則令z=0:");
double x = Convert.ToDouble(Console.ReadLine());
double y = Convert.ToDouble(Console.ReadLine());
int z = 0;
if (y > 0 && x > 0)
{
    z+=1;
    Console.WriteLine($"z={z}");
}
else if(y < 0 && x < 0)
{
    z-=1;
    Console.WriteLine($"z=z");
}
else
{
    Console.WriteLine($"z=z");
}