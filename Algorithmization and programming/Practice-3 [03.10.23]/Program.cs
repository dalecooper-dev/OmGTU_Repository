/******************************************************************************
Дана последовательность из n элементов, необходимо определить:
1.Количество элементов, запись которых в троичной, пятеричной и семеричной системах счисления оканчивается на одну и ту же цифру.
2.Определить количество элементов, которые содержат в своей записи хотя бы одну 7.
3.Определить у всех ли элементов сумма цифр кратна 7.
(3 в 1)
*******************************************************************************/
using System;
class Sequence {
  static void Main() {
    int amount_of_numbers, number_in_10, number_in_7, number_in_5, number_in_3, convertible_number, counter, counter_of_same_endings = 0, counter_of_numbers_with_seven = 0, sum;
    Boolean is_sum_of_all_numbers_is_divided_by_7 = true;
    amount_of_numbers = Convert.ToInt32(Console.ReadLine());

    for(int i = 0; i < amount_of_numbers; i++)
    {
        number_in_10 = Convert.ToInt32(Console.ReadLine());
        number_in_7 = 0;
        number_in_5 = 0;
        number_in_3 = 0;
        sum = 0;

        convertible_number = number_in_10;
        counter = 0;
        while(convertible_number > 0)
        {
            number_in_7 += Convert.ToInt32((convertible_number % 7) * Math.Pow(10, counter));
            convertible_number = convertible_number / 7;
            counter++;
        }
    
        convertible_number = number_in_10;
        counter = 0;
        while (convertible_number > 0)
        {
            number_in_5 += Convert.ToInt32((convertible_number % 5) * Math.Pow(10, counter));
            convertible_number = convertible_number / 5;
            counter++;
        }
    
        convertible_number = number_in_10;
        counter = 0;
        while (convertible_number > 0)
        {
            number_in_3 += Convert.ToInt32((convertible_number % 3) * Math.Pow(10, counter));
            convertible_number = convertible_number / 3;
            counter++;
        }
        
        if(((number_in_7 % 10) == (number_in_5 % 10)) & ((number_in_5 % 10) == (number_in_3 % 10)) & ((number_in_7 % 10) == (number_in_3 % 10)))
        {
            counter_of_same_endings++;
        }
    
        convertible_number = number_in_10;
        while (convertible_number > 0)
        {
            if((convertible_number % 10) == 7)
            {
                counter_of_numbers_with_seven++;
                break;
            }
            convertible_number = convertible_number / 10;
        }
    
        convertible_number = number_in_10;
        while (convertible_number > 0)
        {
            sum += convertible_number % 10;
            convertible_number = convertible_number / 10;
        }
    
        if(sum % 7 != 0)
        {
            is_sum_of_all_numbers_is_divided_by_7 = false;
        }
    }
    Console.WriteLine(counter_of_same_endings + " элементов оканчиваются на одну и ту же цифру в 3, 5, 7 системах счисления.");
    Console.WriteLine(counter_of_numbers_with_seven + " элементов, содержащих хотя бы одну цифру 7.");
    Console.WriteLine(is_sum_of_all_numbers_is_divided_by_7);
  }
}