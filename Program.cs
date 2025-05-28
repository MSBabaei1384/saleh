using System.Numerics;

Console.WriteLine("Hello, World!");


static BigInteger Fib(BigInteger x)
{
    if (x <= 1)
        return x;

    BigInteger a = 0;
    BigInteger b = 1;
    BigInteger c = 0;

    for (int i = 2; i <= x; i++)
    {
        c = a + b;
        a = b;
        b = c;
        //Console.WriteLine(a + " " + b + " " + c);
    }

    return b;

}
int number = 0;

Console.Write("Enter Your Number:");
number = int.Parse(Console.ReadLine());
Console.WriteLine(Fib(number));
