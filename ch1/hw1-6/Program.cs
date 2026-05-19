// 請隨意輸入正負數，取絕對值輸出
Console.WriteLine("請隨意輸入正負數，取絕對值輸出:");
double number = Convert.ToDouble(Console.ReadLine());
if (number < 0)
{
    number=number*-1;
    Console.WriteLine(number);
}
else
{
    Console.WriteLine(number);
}