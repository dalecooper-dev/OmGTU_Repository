/******************************************************************************
Дана последовательность из n элементов, необходимо определить:
1.Количество элементов, которых нет ни одной четной цифр.
2.Определить, все ли элементы, кратные 5, имеют четную сумму цифр.
3.Определить наибольшую сумму элементов пар, которых первый элемент меньше второго.
4.Определить количество пар элементов, у которых произведение кратна 7 (под парой понимается любые 2 элемента).
(4 в 1)
*******************************************************************************/
using System;
class Sequence
{
    static void Main(string[] args)
    {
        Sequence_one();
        Sequence_two();
        Sequence_three();
        Sequence_four();
    }
    // Количество элементов, которых нет ни одной четной цифр.
  static void Sequence_one() 
  {
    int quantity = Convert.ToInt32(Console.ReadLine());
    int [] numbers = new int [quantity];
    double rubbish_number = 0;
    double digit;
    int final = 0;
    for(int i = 0; i < quantity; i++)
    {
        bool condition = true;
        numbers [i] = Convert.ToInt32(Console.ReadLine());
        rubbish_number = Math.Abs(numbers [i]);
        while (rubbish_number > 0)
        {   
            digit = rubbish_number%10;
            rubbish_number = Math.Floor(rubbish_number/10);
            if (digit%2 == 0)
            {
                condition = false;
            }
        }
        if(condition == true)
        {
            final++;
        }
    }
    Console.WriteLine($"quantity of numbers = {final}");
}

    // Определить, все ли элементы, кратные 5, имеют четную сумму цифр.
  static void Sequence_two()
  {
    int quantity = Convert.ToInt32(Console.ReadLine());
    int [] numbers = new int [quantity];
    double rubbish_number = 0;
    int final = 0;
    for(int i = 0; i < quantity; i++)
    {
        numbers [i] = Convert.ToInt32(Console.ReadLine());
        rubbish_number = Math.Abs(numbers [i]);
        if(rubbish_number%5 == 0)
        {
            double sum = 0;
            while(rubbish_number > 0)
            {
                sum += rubbish_number%10;
                rubbish_number = Math.Floor(rubbish_number/10);
                
                
            }
            if(sum%2 == 0)
            {
                final++;
            }
            
            
        }
        
    }
    if(final == quantity){
    Console.WriteLine("True");
    }
    else
    {
        Console.WriteLine("False");
    }
}
    
    // Определить наибольшую сумму элементов пар, которых первый элемент меньше второго.
  static void Sequence_three()
  {
    int quantity = Convert.ToInt32(Console.ReadLine());
    int [] numbers = new int [quantity];
    int sum = 0;
    for(int i = 0; i < quantity; i++)
    {
        numbers[i] = Convert.ToInt32(Console.ReadLine());
    }
    for(int j = 0; j < quantity-1; j++)
    {

        
        if(numbers[j] < numbers[j+1])
        {
            sum = sum > (numbers[j] + numbers[j+1]) ? sum : (numbers[j] + numbers[j+1]);
        }
        
    }
    Console.WriteLine($"sum = {sum}");
}
    
    // Определить количество пар элементов, у которых произведение кратна 7 (под парой понимается любые 2 элемента).
  static void Sequence_four()
  {
    int quantity = Convert.ToInt32(Console.ReadLine());
    int [] numbers = new int [quantity];
    int n = 0;
    for(int k = 0; k < quantity; k++)
    {
        numbers[k] = Convert.ToInt32(Console.ReadLine());
    }
    for(int i = 0; i < quantity;i++)
    {
        for(int j = i; j < quantity; j++)
        {
            if (j != i)
            {
                n = (numbers[i]*numbers[j])%7==0 ? n+1 : n;
            }
        }
    }
    Console.WriteLine($"{n}");
  }
}