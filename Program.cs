using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Hello, World!");

//1

//int Pairsum =0;
//int Oddsum=0;

//for (int i = 10; i < 100; i++)
//{
//    if (i % 2 == 0)
//    {
//        Pairsum = Pairsum + i;
//    }
//    else
//    {
//        Oddsum=Oddsum + i;
//    }
//}
//Console.WriteLine("Sum of pair numbers:"+Pairsum);
//Console.WriteLine("Sum of individual numbers:"+Oddsum);

//2

//int number = 0;

//Console.Write("Enter your number:");
//number=int.Parse(Console.ReadLine());
//for (int i = 1; i <= number; i++)
//{
//    if (i % 2 == 0) 
//    {
//        Console.WriteLine(Math.Pow(i,2));
//    }
//}

//3

//int number =0;
//int Hundredsofdigits =0;
//int Tenthdigit = 0;
//int Onedigit = 0;
//double Hundredsofdigits3 = 0;
//double Tenthdigit3 = 0;
//double Onedigit3 = 0;
//double sum = 0;

//Console.Write("Enter your number:");
//number = int.Parse(Console.ReadLine());

//Hundredsofdigits = (number % 1000) / 100;
//Tenthdigit = (number % 100) / 10;
//Onedigit = number % 10;

//Hundredsofdigits3 = Math.Pow(Hundredsofdigits, 3);
//Tenthdigit3=Math.Pow(Tenthdigit, 3);
//Onedigit3 = Math.Pow(Onedigit,3);

//sum = Hundredsofdigits3 + Tenthdigit3 + Onedigit3;

//if (sum == number)
//{
//    Console.WriteLine("It is Armstrong number");
//}
//else
//{
//    Console.WriteLine("It is Not Armstrong number");
//}

//4

//int number = 0;
//int min = 0;
//Console.Write("Enter your number:");
//number = int.Parse(Console.ReadLine());
//min=number;
//for (int i = 0; i < 19; i++)
//{
//    Console.Write("Enter your number:");
//    number=int.Parse(Console.ReadLine());
//    if (number<min)
//    {
//        min = number;
//    }
//}
//Console.WriteLine("Smallest number:"+min);

//5

//int number = 0;
//int max = 0;
//Console.Write("Enter your number:");
//number = int.Parse(Console.ReadLine());
//max = number;
//for (int i = 0; i < 19; i++)
//{
//    Console.Write("Enter your number:");
//    number = int.Parse(Console.ReadLine());
//    if (number > max)
//    {
//        max = number;
//    }
//}
//Console.WriteLine("Largest number:" + max);

//6

//int number = 0;
//int sum = 0;
//double avg = 0;

//for (int i = 0; i < 20; i++)
//{
//    Console.Write("Enter your number:");
//    number = int.Parse(Console.ReadLine());

//    sum += number;
//}

//avg = sum / 20;
//Console.WriteLine("Average numbers:"+avg);

//7

//int number = 0;
//int Rightdigit = 0;
//String Rightdigit5 = "";
//for (int i = 0; i < 20; i++)
//{
//    Console.Write("Enter your number:");
//    number = int.Parse(Console.ReadLine());

//    Rightdigit=number%10;
//    if (Rightdigit == 5)
//    {
//        Rightdigit5+=number.ToString()+"-";
//    }
//}
//Console.WriteLine(Rightdigit5);

//8

//int number = 0;
//int sum = 1;

//Console.Write("Enter your number:");
//number=int.Parse(Console.ReadLine());

//for (int i = 1; i <= number; i++)
//{
//    sum = i * sum;
//}
//Console.WriteLine(sum);

//9

//int number = 0;
//int count = 0;
//String str = "";

//Console.Write("Enter your number:");
//number = int.Parse(Console.ReadLine());
//str =number.ToString();
//count = str.Length;
//Console.WriteLine("Number of digits:" + count);

//10

//int number = 0;
//int len = 0;
//int start = 0;
//String str = "";
//String turns = "";
//Console.Write("Enter your number:");
//number = int.Parse(Console.ReadLine());
// turns=number.ToString();
//len = turns.Length;
//for(int i = len-1; i >=0; i--)
//{
//    str+=turns.Substring(i,1);

//}
//Console.WriteLine(str);

//11

//int number = 0;

//Console.Write("Enter your number:");
//number = int.Parse(Console.ReadLine());

//if (number % 2 != 0&&number%3!=0&& number % 5 != 0 
//    && number % 7 != 0 && 
//    number!=1 || number == 2)
//{
//    Console.WriteLine("First number:" + number);
//}
//else
//{
//    Console.WriteLine("This is not a first number!!");
//}

//12

//for (int i = 1; i <= 1000; i++)
//{
//    if (i% 2 != 0 && i % 3 != 0 && i % 5 != 0
//    && i % 7 != 0 && i != 1 || i== 2)
//    {
//        Console.WriteLine(i);
//    }
//}

//13

//int len = 0;
//String str = "";
//String turns = "";

//for (int i = 1000; i <= 9999; i++)
//{
//    turns = i.ToString();
//    len = turns.Length;
//    for (int a = len - 1; a >= 0; a--)
//    {
//        str += turns.Substring(a, 1);
//    }
//    if (str == turns)
//    {
//        Console.WriteLine(str);
//    }
//    str = "";
//}

//14

//int number = 0;
//int sum = 0;

//Console.Write("Enter your number:");
//number = int.Parse(Console.ReadLine());

//for (int i = 1; i <= number; i++)
//{
//    if (i==1||i%2==0)
//    {
//        sum += i;
//    }
//    else
//    {
//        sum -= i;
//    }
//}
//Console.WriteLine(sum);

//15

//16

//int number = 0;
//int sum = 0;
//int count = 0;

//Console.Write("Enter your number:");
//number = int.Parse(Console.ReadLine());

//for (int i = 1; i <= number; i++)
//{
//    if (number%i==0)
//    {
//        sum += i;
//        count++;
//    }
//}
//Console.WriteLine("Sum divided:"+sum+"  "+"divisor number:"+count);

//17

//int month = 0;
//int day = 0;
//int yearday = 0;

//Console.Write("Enter your day:");
//day = int.Parse(Console.ReadLine());

//Console.Write("Enter your month:");
//month = int.Parse(Console.ReadLine());

//if (month<=6)
//{
//    yearday = ((month - 1) * 31)+day;
//    Console.WriteLine(yearday);
//}
//else  if (month > 6&&month<12)
//{
//    yearday = (6*31)+((month - 7)*30)+day;
//    Console.WriteLine(yearday);
//}
//else if(month==12)
//{
//    yearday=(6*31)+(5*30)+day;
//    Console.WriteLine(yearday);
//}

//18

//int numberone = 0;
//int numbertwo = 0;
//int bmm = 0;
//Console.Write("Enter your numberone:");
//numberone = int.Parse(Console.ReadLine());

//Console.Write("Enter your numbertwo:");
//numbertwo = int.Parse(Console.ReadLine());

//while (numbertwo!=0)
//{
//   bmm = numbertwo;
//    numbertwo=numberone%numbertwo;
//    numberone = bmm;
//}
//Console.WriteLine(bmm);

//19

//int number = 0;
//int sum = 0;
//int remainder = 10;
//int distribution = 1;
//int len = 0;

//Console.Write("Enter your number:");
//number = int.Parse(Console.ReadLine());

//len=number.ToString().Length;
//for(int i = 1; i <= len; i++)
//{
//    sum += (number % remainder) / distribution;
//    remainder *= 10;
//    distribution *= 10;
//}
//Console.WriteLine(sum);

//20

//String name = "";
//int time = 0;
//int rights = 0;
//int sum = 0;

//Console.Write("Enter your name:");
//name = Console.ReadLine();

//Console.Write("Enter your time:");
//time = int.Parse(Console.ReadLine());

//Console.Write("Enter your rights:");
//rights = int.Parse(Console.ReadLine());

//sum = rights * time;

//Console.WriteLine(name+sum);

//21

//for (int i = 0; i <= 1000; i++)
//{
//    if (i % 2 == 0)
//    {
//        Console.WriteLine(i);
//    }
//}

//22

//for (int i = 0; i <= 1000; i++)
//{
//    if (i % 9 == 0)
//    {
//        Console.WriteLine(i);
//    }
//}

//23

//int number = 0;
//int sum = 0;
//int remainder = 10;
//int distribution = 1;
//int len = 0;

//Console.Write("Enter your number:");
//number = int.Parse(Console.ReadLine());

//len = number.ToString().Length;
//for (int i = 1; i <= len; i++)
//{
//    sum += (number % remainder) / distribution;
//    remainder *= 10;
//    distribution *= 10;
//}


//if (sum % number==0)
//{
//    Console.WriteLine("Ok");
//}
//else
//{
//    Console.WriteLine("Error");
//}

//24

//int number1 = 0;
//int number2 = 0;

//Console.Write("Enter your number1:");
//number1 = int.Parse(Console.ReadLine());

//Console.Write("Enter your number2:");
//number2 = int.Parse(Console.ReadLine());

//for (int i = number1; i < number2; i++)
//{
//    if (i%3 == 0)
//    {
//        Console.WriteLine(i);
//    }
//}

//25

//int unit=0;
//int tens = 0;
//int hundreds = 0;
//int thousands = 0;
//for (int i = 1000; i < 9999; i++)
//{
//    unit = i % 10;
//    tens=(i%100) / 10;
//    hundreds=(i%1000) / 100;
//    thousands = (i%10000) / 1000;
//    if (unit%2==0&&tens%2!=0&&hundreds%2==0&&thousands%2!=0)
//    {
//        Console.WriteLine(thousands+" "+hundreds+" "+tens+" "+unit);
//    }
//}

//26

//int total = 1000;
//int count = 0;

//for (int i = 0; i <= total; i += 200)
//{
//    for (int j = 0; j <= total-i; j+=100)
//    {
//        for (int k = 0; k <= total-i-j; k += 50)
//        {
//            if (i+j+k == total)
//            {
//                count++;
//            }
//        }
//    }
//}
//Console.WriteLine(count);

//27

//int m = 0;
//int n=0;
//int sum = 0;

//Console.Write("Enter your number1:");
//m = int.Parse(Console.ReadLine());

//Console.Write("Enter your number2:");
//n = int.Parse(Console.ReadLine());

//for(int i = 0; i < n; i++)
//{
//    sum += m;
//}
//Console.WriteLine(sum);






