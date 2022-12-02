// Задача необязательная FIZZ BUZZ: 
// Напишите программу, которая выводит на экран числа от 1 до 100. 
// При этом вместо чисел, кратных трем, программа должна выводить слово Fizz, а вместо чисел, кратных пяти — слово Buzz. 
// Если число кратно пятнадцати, то программа должна выводить слово FizzBuzz. 
// Задача может показаться очевидной, но нужно получить наиболее простое и красивое решение.

int i = 0;
while (i < 100)
{
    int num = i + 1;
    if (num % 3 == 0 && num % 5 != 0 && num % 15 != 0)
    {
        Console.Write("Fizz ");
    }
    else if (num % 5 == 0 && num % 3 != 0 && num % 15 != 0)
    {
        Console.Write("Buzz ");
    }
    else if (num % 15 == 0)
    {
        Console.Write("FizzBuzz ");
    }
    else
    {
        Console.Write($"{num} ");
    }
    i++;
}

// Пытался попробовать написать программу через функцию, не хватает понимания 
// 
// void FillArray(int[] collection)
// {
//     int index = 0;
//     while (index < 100)
//     {
//         collection[index] = index + 1;
//         index++;
//     }
// }
// void PrintArray(int[] col)
// {
//     int position = 0;
//     while (position < 100)
//     {
//         Console.Write(col[position]);
//         position++;
//     }
// }
// int[] array = new int[100];

// FillArray(array);
// PrintArray(array);
// Console.Write($"{array} ");