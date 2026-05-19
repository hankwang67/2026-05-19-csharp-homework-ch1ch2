//補充習題1:
/* 1.Eason 是一位高中電腦老師，這學期正在教學生寫C++程式。
他的評分標準是依照每一位學生在 ZeroJudge 系統上解出的題數，去計算出對應的得分。規則如下：*/
Console.WriteLine($"輸入得分題目數去算成績:");
int correctAnswers = Convert.ToInt32(Console.ReadLine());
int score = 0;
while (correctAnswers < 0)
{
    Console.WriteLine("答對題數不得小於0");
    correctAnswers = Convert.ToInt32(Console.ReadLine());
}


score += Math.Min(correctAnswers, 10) * 6;

if (10 < correctAnswers)
{

    score += Math.Min(correctAnswers - 10, 10) * 2;
}
if (20 < correctAnswers)
{

    score += Math.Min(correctAnswers - 20, 20) * 1;
}
score = Math.Min(score, 100);
Console.WriteLine($"你的分數是{score}");
