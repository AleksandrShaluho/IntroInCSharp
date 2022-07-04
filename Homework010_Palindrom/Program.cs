﻿//программа принимает на вход пятизначное число и проверяет, является ли оно палиндромом

//1. быстрый и легкий способ. НЕ универсальный, только для пятизначных чисел.

/*Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number/100000 > 0 || number/10000 < 1) Console.WriteLine("Введенное число не является пятизначным!");
else if (number/10000 == number%10 && number/1000%10 == number/10%10)
    {
        Console.WriteLine($"{number}-> да");
    } 
        else Console.WriteLine($"{number}-> нет");
*/

//2. Более правильный и универсальный способ. 
//Решение построено на главном свойстве полиндрома - равенство при "прочтении" в обоих направлениях.Сначала "перевернем" число, потом просто сравним.

//для отработки материалов семинаров, добавим цикл, не выпускающий пользователя из программы, пока тот не введет коректное число или не попросит выйти.
int number = -1;
string userInput = String.Empty;
while (true)
{
    Console.WriteLine("Введите любое натуральное  число: ");
    
    //проверяем, не созрел ли пользователь для выхода
    userInput = Console.ReadLine();
    if (userInput == "exit") break;
    //если не созрел, переходим к основной программе
    else
    {    
        number = Convert.ToInt32(userInput);
        //проверяем, что число натуральное и программа с ним справится
        if (number < 0) Console.WriteLine("Программа работает только с натуральными числами. Введите натуральное число либо команду exit");
        else
        {
            //переменная для временного хранения исходного числа и отщипывания по одной цифре для переворота
            int forDecCount = number;

            //переменная для итогового отраженного числа.
            int mirrowedNumber = 0;

            //dec - величина одного разряда в десятичной системе счисления
            int dec = 10;
                      
            // выполняем в цикле отбор последней текущей цифры исходного числа и запись ее в итоговое "отраженное" число. Цикл длится пока не останется разрядов с цифрами в исходном числе. 
//Числовой вариант цикла.
            while (forDecCount > 0) 
            {
                //начинаем цикл с отбора последней текущей цифры исходного числа и записи в итоговое "отражение". Чтобы в итоговом "отражении" цифры не просто суммировались, а записывались каждая в свой разряд, мы сначала "сдвигаем" все цифры на разряд влево, умножая "отражение" на 10.    
                mirrowedNumber = mirrowedNumber*dec + forDecCount%dec;
                //после того, как последняя текущая цифра записана в отражение, отбрасываем ее из исходного числа и переходим в следующую итерацию цикла
                forDecCount = forDecCount/dec;
            }

            //Строковый вариант цикла. "Отражение" пишем не в число, а в строку
            /* 
            //понадобится дополнительная переменная (только для удобства демонстрации строкового варианта
            string mirrowedString = String.Empty;

            while (forDecCount > 0)
            {
                 //начинаем цикл с отбора последней текущей цифры исходного числа и записи в итоговое "отражение". Вместо числового суммирования применяем объединение строк.    
                 mirrowedString = mirrowedString + forDecCount%dec;
                 //после того, как последняя текущая цифра записана в отражение, отбрасываем ее из исходного числа и переходим в следующую итерацию цикла
                 forDecCount = forDecCount/dec;
            }
            */

            //Теперь сравниваем два числа (исходное и отраженное) и выводим результат
            //Для строкового варианта цикла предварительно надо будет перевести строку в число
            //mirrowedNumber = Convert.ToInt32(mirrowedString);

            if (number == mirrowedNumber) Console.WriteLine($"{number} -> да");
            else Console.WriteLine($"{number} -> нет");
            break;
        }
    }
}