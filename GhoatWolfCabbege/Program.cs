// See https://aka.ms/new-console-template for more information
{

    int secondCoastSum = 0;

    do
    {
        int firstCoastSum = 7;
        secondCoastSum = 0;
        bool isFirstCoast = true;

        Console.WriteLine("Привет! перевези Козу,Капусту и Волка на другой берег. Учитывай, что коза ест капусту, а волк- козу. В лодке только одно место.");

        while (firstCoastSum != 0)
        {
            if (isFirstCoast)
            {
                Console.WriteLine("Кого повезем? Введите число: ");
                switch (firstCoastSum)
                {
                    case 7:
                        Console.WriteLine("Капуста - 1, Коза - 2 Волк - 4");
                        break;
                    case 6:
                        Console.WriteLine("Коза - 2 Волк - 4");
                        break;
                    case 5:
                        Console.WriteLine("Капуста - 1, Волк - 4");
                        break;
                    case 3:
                        Console.WriteLine("Капуста - 1,Коза - 2");
                        break;
                    case 2:
                        Console.WriteLine("Коза - 2");
                        break;
                }

                int selectObj = Convert.ToInt32(Console.ReadLine());
                firstCoastSum -= selectObj;
                secondCoastSum += selectObj;

                if (firstCoastSum != 6 && firstCoastSum != 3)
                {
                    Console.WriteLine("молодец");
                    isFirstCoast = false;
                }
                else
                {
                    Console.WriteLine("ты проиграл. Попробуй снова");
                    break;
                }
            }
            else
            {
                Console.WriteLine("Кого повезем обратно? Введите число:");
                switch (secondCoastSum)
                {
                    case 6:
                        Console.WriteLine("Коза - 2 Волк - 4");
                        break;
                    case 5:
                        Console.WriteLine("Капуста - 1, Волк - 4 Ни кого не брать - 0");
                        break;
                    case 3:
                        Console.WriteLine("Капуста - 1,Коза - 2");
                        break;
                    case 2:
                        Console.WriteLine("Коза - 2 Ни кого не брать - 0");
                        break;
                }

                int selectObj = Convert.ToInt32(Console.ReadLine());
                firstCoastSum += selectObj;
                secondCoastSum -= selectObj;

                if (secondCoastSum != 6 & secondCoastSum != 3)
                {
                    Console.WriteLine("молодец");
                }
                else
                {
                    Console.WriteLine("ты проиграл. Попробуй снова");
                    break;
                }
                isFirstCoast = true;
            }
        }
    } while (secondCoastSum != 7);

    Console.WriteLine("Ты победил!");
}
