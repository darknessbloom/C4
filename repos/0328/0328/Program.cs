// See https://aka.ms/new-console-template for more information
using Microsoft.Win32.SafeHandles;

/*Console.WriteLine("이름={0},나이={1}", "둘리", 10);
Console.WriteLine(DateTime.Now);
String inn = Console.ReadLine();
Console.WriteLine("입력값"+ inn);*/


/*int a, b;
int result;
string str;
Console.WriteLine("첫번째 값을 입력하시오");
string str;
a = Convert.ToInt32(str);//정수로 변환이됨.
Console.WriteLine("두번째 값을 입력하시오");
str = Console.ReadLine();
 b = Convert.ToInt32(str);

result = a + b;
Console.WriteLine("결과값은?");
Console.WriteLine(a + "+" + b + '='+result);*/

double a,b;
double result;
string str;
Console.WriteLine("202216023장선경");
Console.WriteLine("첫번째 값을 입력하시오");
str = Console.ReadLine();
a = Convert.ToDouble(str);
Console.WriteLine("두번째 값을 입력하시오");
str = Console.ReadLine();
b = Convert.ToDouble(str);
Console.WriteLine("결과 입니다");

Console.WriteLine(a+"+"+b+"="+(a + b));
Console.WriteLine(a + "-" + b + "=" + (a - b));
Console.WriteLine(a + "*" + b + "=" + (a * b));
Console.WriteLine(a + "/" + b + "=" + (a / b));
Console.WriteLine(a + "%" + b + "=" + (a % b));
Console.WriteLine(a + "^" + b + "=" + Math.Pow(a, b));


