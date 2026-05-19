// 輸入a、b和c，求：y = a-(b+c)(3a-c)
Console.WriteLine("輸入a、b和c，求：y=a-(b+c)(3a-c)");
double a = Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());
double c = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"y=a-(b+c)(3a-c)={a-(b+c)*(3*a-c)}");