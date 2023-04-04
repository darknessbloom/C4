// See https://aka.ms/new-console-template for more information

/*int a = 75;
if (a > 50)
{
    if (a < 100)
        Console.WriteLine("50보다 크고 100보다 작음");
    else
        Console.WriteLine("100보다 큼");

     
} 
else
{
    Console.WriteLine("50보다 작음");
}

if (DateTime.Now.Hour < 11)
    Console.WriteLine("아침먹을 시간입니다");
else if (DateTime.Now.Hour < 15)
    Console.WriteLine("점심먹을 시간입니다");
else
    Console.WriteLine("저녁먹을 시간입니다.");*/

//1
Console.WriteLine("202216023장선경");
Console.WriteLine("평점 점수 프로그램");
double score=double.Parse(Console.ReadLine());
if (score >= 90)
    Console.WriteLine("A");
else if (score >=80)
    Console.WriteLine("B");
else if(score >=70)
    Console.WriteLine("C");
else if(score >=60)
    Console.WriteLine("D");
else
    Console.WriteLine("F");

//2
Console.WriteLine("합격/불합격 프로그램");
double score1 = double.Parse(Console.ReadLine());
String pass = "합격";
String fail = "불합격";
if (score1 >= 55)
    Console.WriteLine("점수:{0}->{1}",score1,pass);
else
    Console.WriteLine("점수:{0}->{1}", score1, fail);




