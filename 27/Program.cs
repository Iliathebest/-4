// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число ");
 int number = Convert.ToInt32(Console.ReadLine());

        int sum(int number)
        {
             int b = Convert.ToString(number).Length;
            int a = 0;
            int result = 0;

            for (int i = 0; i <b; i++)
            {
                a = number - number % 10;
                result = result + (number - a);
                number = number / 10;
            }
            return result;
        }

        int sumNumber = sum(number);
        Console.WriteLine("Сумма цифр в числе: " + sumNumber);