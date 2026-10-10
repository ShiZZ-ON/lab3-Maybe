//int s = 0;
//int k = 0;
//int n = 0;
//Console.WriteLine("Введи числа:");
//do
//{
//    try
//    {
//        n = int.Parse(Console.ReadLine());
//            //s = s + n;
//        s += n;
//            //k = k + 1;
//        k++;
//    }

//    catch (Exception e)
//    {
//        Console.WriteLine(e.Message);

//    }
//}
//while (n!= 0);
//    //k = k - 1;
//k--;
//Console.WriteLine($"Сумма чисел{s}, количество: {k}"); 



//double s = 0;
//int k = 0;
//Console.WriteLine("Введи числа: ");
//do
//{
//    try
//    {
//        int n = int.Parse(Console.ReadLine());
//        if (n < 0) break;
//        s += n;
//        k++;
//    }
//    catch (Exception e)
//    {
//        Console.WriteLine(e.Message);
//    }
//}
//while (true);
//Console.WriteLine($"Среднее арифметическое:{s/k:F2}");

//int s = 0;
//int i = 0;
//while (i < 100 )
//{
//    i++;
//    if (i % 5 == 0) continue;
//    s += i;

//}
//Console.WriteLine($"S={s}");

//for (int i = 35; i <= 87; i++)
//{
//    if ( i%7==1|| i % 7 == 2 || i % 7 == 5)
//        Console.Write(i+" ");
//}

//try
//{
//    int n = 0;
//    do
//    {
//        Console.Write("Введи n: ");
//        n = int.Parse(Console.ReadLine());
//        if ( n < 0 )
//            Console.WriteLine("Введи положительное число!!!");
//    }
//    while (n < 0);
//    long F = 1;
//    for (int i = 1; i <= n; i++)
//        Console.WriteLine($"Факториал {n}:{F} ");
//}
//catch(Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//try
//{

//    long temp = 0;
//    long k3 = 0;
//    long kLast = 0;
//    long kEven = 0;
//    long kSumGreaterFive = 0;
//    long kMultGreaterSeven = 1;
//    long kZeroFive = 0;

//    Console.Write("Enter n: ");
//    long n = int.Parse(Console.ReadLine());

//    long Last = n % 10;

//    while (n != 0)
//    {
//        temp = n % 10;
//        if (temp == 3) k3++;
//        if (temp == Last) kLast++;
//        if (temp % 2 == 0) kEven++;
//        if (temp > 5) kSumGreaterFive += temp;
//        if (temp > 7) kMultGreaterSeven *= temp;
//        if (temp == 0 || temp == 5) kZeroFive++;
//        n /= 10;
//    }

//    Console.WriteLine($"Количество 3: {k3}");
//    Console.WriteLine($"Последняя цифра встречается: {kLast}");
//    Console.WriteLine($"Количество четных: {kEven}");
//    Console.WriteLine($"Сумма больше 5: {kSumGreaterFive}");
//    Console.WriteLine($"Произведение его цифр, больших семи: {kMultGreaterSeven}");
//    Console.WriteLine($"Встречаются цифры от 0 и 5: {kZeroFive}");

//}

//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//for (int i = 1; i <= 9; i++) //Внешний цикл
//{
//    for (int j = 1; j <= 9; j++) //Внутренний цикл
//    {
//        Console.Write($"{i}*{j}={i * j} ");
//    }
//    Console.WriteLine();
//}

//for (int i = 1; i <= 5; i++)
//{
//    for (int j = 1; j <= i; j++)
//    {
//            Console.Write($"{i*10} ");
//    }
//    Console.WriteLine();
//}



//11 Вариант Высокий     уровень

using System.Linq.Expressions;

int p = 1;
int k = 0;
do
{
    Console.Write("введи число: ");

    {
        int n = int.Parse(Console.ReadLine());
        if (n == 0) { break; }

        if (n > 0) { continue; }
        p = p * n;
        k = k + 1;


    }

   
}
while (true);
if (k == 0)
{
    Console.WriteLine("не было отрицательных");
}
else
{
    Console.WriteLine($"произведение отрицательных: {p}");
}