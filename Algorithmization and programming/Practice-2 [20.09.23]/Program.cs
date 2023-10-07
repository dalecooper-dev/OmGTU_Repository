/******************************************************************************
Для последовательности из n элементов определить:
1.Наименьшую длину подпоследовательности, состоящей из одинаковых элементов.
2.Все ли элементы последовательности кратны номеру, под которым они считываются.
3.Максимальную длину подпоследовательности, состоящей из различных элементов
4.Образует ли заданная последовательность равномерно убывающую последовательность элементов.
(4 в 1)
*******************************************************************************/
using System;
class Sequence
{
    static void Main(string[] args)
    {
        Calculating_min_subsequence_of_same_numbers(); // Минимальная длина подпоследовательности последовательности из одинаковых элементов
        Checking_multiplisity_of_numbers_and_their_subsequence_number(); // Проверка кратности элементов и их порядковых номеров в последовательности
        Calculating_max_subsequence_of_different_numbers(); // Максимальная длина подпоследовательности последовательности из разных элементов
        Checking_is_subsequence_uniformly_decreasing(); // Проверка является ли последовательность равномерно убывающей
    }

    // Наименьшая длина подпоследовательности последовательности из одинаковых элементов
    static void Calculating_min_subsequence_of_same_numbers() 
    {
        int amount, min_subsequence, current_subsequence = 1, number, previous_number;
        amount = Convert.ToInt32(Console.ReadLine());
        min_subsequence = amount;
        previous_number = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < amount - 1; i++)
        {
            number = Convert.ToInt32(Console.ReadLine());
            if (number == previous_number)
            {
                current_subsequence++;
            }
            else
            {
                if ((min_subsequence > current_subsequence) & (current_subsequence > 1))
                {
                    min_subsequence = current_subsequence;
                }
                current_subsequence = 1;
            }
            previous_number = number;
        }
        Console.WriteLine(min_subsequence + " минимальная длина последовательности из одинаковых элементов");
    }

    // Все ли элементы последовательности кратны номеру, под которым они считываются
    static void Checking_multiplisity_of_numbers_and_their_subsequence_number()
    {
        int amount, number, switcher = 0;
        amount = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= amount; i++)
        {
            number = Convert.ToInt32(Console.ReadLine());
            if (number % i != 0)
            {
                switcher = 1;
                break;
            }
        }
        if(switcher == 0)
        {
            Console.WriteLine("Все числа кратны своему номеру в последовательности");
        }
    }
    
        // Максимальная длина подпоследовательности последовательности из разных элементов
    static void Calculating_max_subsequence_of_different_numbers()
    {
        int amount, max_subsequence, current_subsequence = 1, number, previous_number;
        amount = Convert.ToInt32(Console.ReadLine());
        max_subsequence = 1;
        previous_number = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < amount - 1; i++)
        {
            number = Convert.ToInt32(Console.ReadLine());
            if (number != previous_number)
            {
                current_subsequence++;
            }
            else
            {
                if ((max_subsequence < current_subsequence) & (current_subsequence > 1))
                {
                    max_subsequence = current_subsequence;
                }
                current_subsequence = 1;
            }
            previous_number = number;
        }
        Console.WriteLine(max_subsequence + " максимальная длина последовательности из разных элементов");
    }
    
        // Образует ли заданная последовательность равномерно убывающую последовательность элементов
    static void Checking_is_subsequence_uniformly_decreasing()
    {
        int amount, number, previous_number, difference, switcher = 1;
        amount = Convert.ToInt32(Console.ReadLine());
        previous_number = Convert.ToInt32(Console.ReadLine());
        number = Convert.ToInt32(Console.ReadLine());
        difference = previous_number - number;
        if (difference > 0)
        {
            for (int i = 0; i < amount - 2; i++)
            {
                previous_number = number;
                number = Convert.ToInt32(Console.ReadLine());
                if((previous_number - number) != difference)
                {
                    switcher = 0;
                }
            }
        } else
        {
            switcher = 0;
        }
        if(switcher == 1) 
        {
            Console.WriteLine("Последовательность является равномено убывающей");
        } else
        {
            Console.WriteLine("Последовательность не является равномено убывающей");
        }
    }
}