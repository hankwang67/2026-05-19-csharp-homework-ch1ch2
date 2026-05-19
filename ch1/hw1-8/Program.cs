// 請輸入身高體重，輸出BMI
Console.WriteLine("請先後輸入身高體重，輸出BMI:");
double h = Convert.ToDouble(Console.ReadLine());
double w = Convert.ToDouble(Console.ReadLine());

double bmi = w / Math.Pow(h / 100, 2);
Console.WriteLine($"你的BMI是{bmi}");

if (bmi < 18.5)
    Console.WriteLine("你過輕了");
else if (bmi < 24)
    Console.WriteLine("你很棒");
else if (bmi < 27)
    Console.WriteLine("你過重囉");
else if (bmi < 30)
    Console.WriteLine("你輕度肥胖");
else if (bmi < 35)
    Console.WriteLine("你中度肥胖");
else
    Console.WriteLine("你超胖");