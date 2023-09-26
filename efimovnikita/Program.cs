//int n = int.Parse(Console.ReadLine());
//int k = 0;
//while(Math.Pow(3, k) < n)
//{
//    k++;
//}
//if (Math.Pow(3, k) == n)
//{
//    Console.WriteLine($"YES, stepen = {k}");
//}
//else
//{
//    Console.WriteLine("NO");
//} 
// это домашка на среду 20.09.23(является ли число степенью тройки)



//int k = int.Parse(Console.ReadLine());
//int f = 1;
//int s = 0;
//for(int n = 1; n < k + 1; n++)
//{
//    f = f * n;
//    s = s + f;
//}
//Console.WriteLine(s);
// прога для нахождения суммы факториалов



//double x = double.Parse(Console.ReadLine());
//double s = 0;
//double m = 1;
//double l = 1;

//for (int k = 1; k < 10; k++)
//{
//    s = s + (m / l);
//    m = m * x;
//    l = l * k;
//}
//Console.WriteLine(s);
//Console.WriteLine(Math.Exp(x));



//int k = int.Parse(Console.ReadLine());
//int cnt = 0;
//for (int a = 1; a < 10; a++)
//{
//    for (int b = 0; b < 10; b++)
//    {
//        for(int c = 0; c < 10; c++)
//        {
//            if (a+b+c == k)
//            {
//                cnt++;
//            }
//        }
//    }
//}
//Console.WriteLine(cnt);

//int cnt = 0;
//int cnt1 = 0;
//int cnt2 = 0;
//for (int a = 0; a < 10; a++)
//{
//    for (int b = 0; b < 10; b++)
//    {
//        for (int c = 0; c < 10; c++)
//        {
//            for (int d = 0; d < 10; d++)
//            {
//                for (int e = 0; e < 10; e++)
//                {
//                    for (int f = 0; f < 10; f++)
//                    {
//                        if((a + b + c) == (d + e + f))
//                        {
//                            cnt++;
//                        }
//                        if ((a + c + e) == (b + d + f))
//                        {
//                            cnt1++;
//                        }
//                        if (((a+b+c) == (d+e+f)) && ((a+c+e) == (b + d + f)))
//                        {
//                            cnt2++;
//                        }
//                    }
//                }
//            }
//        }
//    }
//}
//Console.WriteLine(cnt);
//Console.WriteLine(cnt1);
//Console.WriteLine(cnt2);



// double x = double.Parse(Console.ReadLine());
// double y = double.Parse(Console.ReadLine());
// if(((x >= 0 && x <= 1) && (y <= 0 && y <= (-1 * x))) || (x <= 0 && x >= -1 && y >= 0 && y >= (-1 * x)))
// {
//     Console.WriteLine("Входит");
// }
// else
// {
//     if (x >= -1 && x <= 0 && y <= 0 && y >= x)
//     {
//         Console.WriteLine("ВХОДИТ");
//     }
//     else
//     {
//         Console.WriteLine("Не Входит");
//     }
// }
// Console.WriteLine(Math.Pow(42, 2));
// Console.WriteLine(Math.Pow(23, 23));