// 補充4.企業發放的獎金根據利潤提成。
Console.WriteLine("輸入利潤，企業發放的獎金根據利潤提成:");
double profit = Convert.ToDouble(Console.ReadLine());
double bonus = 0;
int tenthousand = 10000;
bonus += Math.Min(profit ,10*tenthousand)*0.1;
if (10 * tenthousand < profit)
{
    bonus += Math.Min(profit - 10 * tenthousand, 10 * tenthousand) * 0.075;
}
if (20 * tenthousand < profit)
{
    bonus += Math.Min(profit - 20 * tenthousand, 20 * tenthousand) * 0.05;
}
if (40 * tenthousand < profit)
{
    bonus += Math.Min(profit - 40 * tenthousand, 20 * tenthousand) * 0.03;
}
if (60 * tenthousand < profit)
{
    bonus += Math.Min(profit - 60 * tenthousand, 40 * tenthousand) * 0.015;
}
if (100 * tenthousand < profit)
{
    bonus +=(profit - 100 * tenthousand) * 0.015;
}
Console.WriteLine($"提成是:{bonus}$");