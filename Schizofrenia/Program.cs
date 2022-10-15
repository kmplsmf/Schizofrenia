while (true)
{
    Console.WriteLine("ввод операции: ");
    Console.WriteLine("1: игра угадай число");
    Console.WriteLine("2: таблица умножения");
    Console.WriteLine("3: выход");
    int operation = Convert.ToInt32(Console.ReadLine());
    if (operation == 4)
    {
        break;
    }
    if (operation == 1)
    {
        Man();
        static void Man()
        {
            randNum();
        }
    }
    if (operation == 2)
    {
        Mai();
        static void Mai()
        {
            umnozhenie();
        }
    }
    static void randNum()
    {
        Random rnd = new();
        while (true)
        {
            int value = rnd.Next(0, 10);
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == value)
            {
                Console.WriteLine("ура, верное число, ты смог");
                break;
            }
            else
            {
                Console.WriteLine("введите новое число, это число не совсем то что нам нужно");
            }

        }
    }
    static void umnozhenie()
    {
        while (true)
        {
            int[,] table = new int[10, 10];
            for (int i = 1; i < 10; ++i)
            {
                for (int j = 1; j < 10; ++j)
                {
                    table[i, j] = i * j;
                    Console.Write("{0, 4}", table[i, j]);
                }
                Console.WriteLine();
            }
            break;
        }       
    }
}
