Random rnd = new Random();
while (true)
{
    int value = rnd.Next(0, 100);
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
