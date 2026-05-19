//寫一程式，輸入a,b，求y=(𝑎2+𝑏2)/(𝑎2−𝑏2) 
Console.WriteLine("輸入兩數a,b，求y=(a^2+b^2)/(a^2-b^2):");
double a = Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"a＾2 + b＾2={(Math.Pow(a, 2) + Math.Pow(b, 2)) / (Math.Pow(a, 2) - Math.Pow(b, 2))}");