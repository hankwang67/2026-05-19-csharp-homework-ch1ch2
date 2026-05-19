// 2-4.寫一程式，輸入x、y、u、v，如果((𝑥+𝑦))/((𝑢+𝑣))>=2，令z=x+y，否則令z=u+v。
Console.WriteLine("寫一程式，輸入x、y、u、v，如果((𝑥+𝑦))/((𝑢+𝑣))>=2，令z=x+y，否則令z=u+v");
double x = Convert.ToDouble(Console.ReadLine());
double y = Convert.ToDouble(Console.ReadLine());
double u = Convert.ToDouble(Console.ReadLine());
double v = Convert.ToDouble(Console.ReadLine());
double z = 0;
if ((x + y) > (u + v))
{
    z = x + y;
}
else
{
    z = u + v;
}