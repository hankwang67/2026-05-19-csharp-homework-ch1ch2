// 輸入的西元年份轉換成民國年份後輸出

Console.WriteLine("輸入的西元年份轉換成民國年份後輸出:");
int number = Convert.ToInt32(Console.ReadLine());
if (number - 1911 > 1000)
{
    Console.WriteLine($"如果國還在的話ㄏㄏ，民國{number - 1911}年");
}
else
{
    Console.WriteLine($"民國{number - 1911}年");
}