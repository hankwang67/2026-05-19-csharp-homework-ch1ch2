// 2-6輸入所得去算所得稅
Console.WriteLine("輸入所得去算所得稅:");
double income = Convert.ToDouble(Console.ReadLine());
double rate = 0;
double difference = 0;
double tax = 0;
if (income > 4090000)
{
    rate = 0.4;
    difference = 721100;
}
else if (income > 2180000)
{
    rate = 0.3;
    difference = 312100;
}
else if (income > 1090000)
{
    rate = 0.21;
    difference = 115900;
}
else if (income > 410000)
{
    rate = 0.13;
    difference = 28700;
}
else
{
    rate = 0.6;
}
tax = (income * rate) - difference;
Console.WriteLine($"您的所得稅是:{tax}$");