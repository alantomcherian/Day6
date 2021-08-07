using System;

namespace Day6
{
    class Program
    {
        public static void fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            int s = 0;

            Console.WriteLine(a);
            Console.WriteLine(b);

            for (int i = 2; i < n; i++)
            {
                s = a + b;
                a = b;
                b = s;
                Console.Write(s+" ");
            }
            
        }

        public static void prime(int n)
        {
            int m = n / 2;
            int flag = 0;
            for (int i = 2; i <= m; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("Number is not Prime.");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.Write("Number is Prime.");
        }

        public static void perfect(int n)
        {
            int m = n / 2;
            int sum = 0;
            for (int i = 1; i <= m; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                    sum += i;
                }
            }
            if (n == sum)
            {
                Console.WriteLine(n + " is a perfect no.");
            }
            else
            {
                Console.WriteLine(sum);
                Console.WriteLine(n + " is not a perfect no.");
            }
        }

        public static void reverse(int n)
        {
            int sd;
            Console.Write("reverse of "+n+" is :- ");
            while (n != 0)
            {
                sd = n % 10;
                Console.Write(sd);
                n = n / 10;
            }
        }

        public static void coupon(int a)
        {
            Random r = new Random();
            int cn=0;
            int counter = 0;
            while (cn != a)
            {
                cn = r.Next();
                counter++;
            }
            Console.WriteLine("To get coupon no:: "+a+" we had gone through "+counter+" numbers.");
        }

        public static void stopwatch()
        {
            string start;
            string stop;

            Console.WriteLine("press to start");
            Console.ReadKey();
            start = DateTime.Now.ToString("mm:ss tt");
            Console.WriteLine(" Start time: {0}",start);

            Console.WriteLine("press to stop");
            Console.ReadKey();
            stop = DateTime.Now.ToString("mm:ss tt");
            Console.WriteLine("end time :{0}",stop);

            Console.WriteLine("press to show elapsed time");
            Console.ReadKey();
            TimeSpan time = DateTime.Parse(stop).Subtract(DateTime.Parse(start));
            Console.WriteLine("elapsed time :: "+time);
        }

            static void Main(string[] args)
        {          
            int w = 1;
            while (w == 1)
            {
                Console.WriteLine();
                Console.WriteLine("enter choice::");
                Console.WriteLine("0. exit menu");
                Console.WriteLine("1. fibonacci");
                Console.WriteLine("2. perfect no");
                Console.WriteLine("3. Prime");
                Console.WriteLine("4. reverse of a number");
                Console.WriteLine("5. Random coupon ");
                Console.WriteLine("6. stopwatch");               
                int c = int.Parse(Console.ReadLine());
                switch (c)
                {
                    case 0:
                        w = 0;
                        break;
                    case 1:
                        fibonacci(10);
                        break;
                    case 2:
                        perfect(28);
                        break;
                    case 3:
                        prime(10);
                        break;
                    case 4:
                        reverse(123);
                        break;
                    case 5:
                        coupon(1230);
                        break;
                    case 6:
                        stopwatch();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
