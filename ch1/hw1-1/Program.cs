//寫一程式，輸入a,b,c,d，計算((𝑎+𝑏))/((𝑐−𝑑))×2。
Console.WriteLine("請輸入輸入a,b,c,d，計算((𝑎+𝑏))/((𝑐−𝑑))×2：");
double a = Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());
double c = Convert.ToDouble(Console.ReadLine());
double d = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"((𝑎+𝑏))/((𝑐−𝑑))×2={((a+b))/((c-d))*2}");