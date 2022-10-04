namespace secpract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int f = 0;
            while (f == 0)
            {
                Console.WriteLine("Интерфейс:");
                Console.WriteLine();
                // gfhff
                Console.WriteLine("1. Игра угадай число");
                Console.WriteLine("2. Таблица умножения");
                Console.WriteLine("3. Калькулятор делителей числа");
                Console.WriteLine("4. Закрыть интерфейс");
                Console.WriteLine();
                int ch = Convert.ToInt32(Console.ReadLine());
                if (ch == 1)
                {
                    Game();
                }
                else if (ch == 2)
                {
                    Tabl();
                }
                else if (ch == 3)
                {
                    kalkul();
                }
                else if (ch == 4)
                {
                    f = 1;
                }
                else
                {
                    Console.WriteLine("другие программы находятся в стадии разработки ");
                }
            }
        }
        static void Game()
        {
            Console.WriteLine("Игра угадай число запущена");
            Console.WriteLine();
            Console.WriteLine("Введите начальное число:");
            Random rnd = new Random();
            int r = rnd.Next(0, 100);

            int k = 0;
            while (k == 0)
            {
                int c = Convert.ToInt32(Console.ReadLine());

                if (r == c)
                {
                    Console.WriteLine("Ура вы выиграли!!!");
                    Console.WriteLine();
                    k = 1;

                }
                else if (r < c)
                {
                    Console.WriteLine("Введи число меньше:");
                }
                else if (r > c)
                {
                    Console.WriteLine("Введи число больше:");
                }
            }

        }

        static void Tabl()
        {
            Console.WriteLine("Таблица умножения выведена на экран:");
            int b = 1;
            while (b != 90)
            {
                int a = 2;
                int[,] g = new int[10, 8]
                {
     { b = a * 1, b = (a+1)*1, b = (a+2)*1 , b = (a+3)*1, b = (a+4)* 1, b = (a+5)* 1,  b = (a+6)* 1,  b = (a+7)* 1 },
    { b = a * 2 , b = (a+1)* 2, b = (a+2)* 2, b = (a+3)* 2, b = (a+4)* 2,  b = (a+5)* 2,  b = (a+6)* 2,  b = (a+7)* 2 },
    { b = a * 3, b = (a+1)* 3, b = (a+2)* 3, b = (a+3)* 3, b = (a+4)* 3, b = (a+5)* 3,  b = (a+6)* 3,  b = (a+7)* 3},
    { b = a * 4, b = (a+1)*4, b = (a+2)*4 , b = (a+3)*4, b = (a+4)* 4, b = (a+5)* 4,  b = (a+6)* 4,  b = (a+7)* 4 },
     { b = a * 5, b = (a+1)*5, b = (a+2)*5 , b = (a+3)*5, b = (a+4)* 5, b = (a+5)* 5,  b = (a+6)* 5,  b = (a+7)* 5 },
     { b = a * 6, b = (a+1)*6, b = (a+2)*6 , b = (a+3)*6, b = (a+4)* 6, b = (a+5)* 6,  b = (a+6)* 6,  b = (a+7)* 6 },
     { b = a * 7, b = (a+1)*7, b = (a+2)*7 , b = (a+3)*7, b = (a+4)* 7, b = (a+5)* 7,  b = (a+6)* 7,  b = (a+7)* 7 },
     { b = a * 8, b = (a+1)*8, b = (a+2)*8 , b = (a+3)*8, b = (a+4)* 8, b = (a+5)* 8,  b = (a+6)* 8,  b = (a+7)* 8 },
     { b = a * 9, b = (a+1)*9, b = (a+2)*9 , b = (a+3)*9, b = (a+4)* 9, b = (a+5)* 9,  b = (a+6)* 9,  b = (a+7)* 9 },
     { b = a * 10, b = (a+1)*10, b = (a+2)*10 , b = (a+3)*10, b = (a+4)* 10, b = (a+5)* 10,  b = (a+6)* 10,  b = (a+7)* 10 }
                };

                for (int r = 0; r < g.GetLength(0); r++)
                {
                    for (int m = 0; m < g.GetLength(1); m++)
                    {
                        Console.Write(g[r, m] + "\t");
                    }
                    Console.WriteLine();
                }
            }

        }
        static void kalkul()
        {
            Console.WriteLine("Калькулятор делителей числа запущен:");
            Console.WriteLine("Чтобы выйти нажмите: 0");
            int final = 0;
            while (final == 0)
            {
                    int n = Convert.ToInt32(Console.ReadLine());
                if (n > 0)
                {
                    for (int i = 1; i < n + 1; i++)
                        if (n % i == 0)
                        {
                            Console.WriteLine(i);
                            Console.WriteLine();
                        }
                }
                else if (n == 0)
                {
                    final = 1;
                }
                else
                {
                    Console.WriteLine("Введите  положительное число");
                }
            }

        }
    }
    }