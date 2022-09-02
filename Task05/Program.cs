// случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа
// 78->8
// 12->2
// 85->8
//-------------------------------------------------------------------------------

int number = new Random().Next(10, 100);

//int number = 55;
// int firstDigit = number / 10;
// int secondDigit = number % 10;

//          первый вариант решения
// if(firstDigit > secondDigit) System.Console.WriteLine($"Наибольшая цифра числа {number} -> {firstDigit}");
// else System.Console.WriteLine($"Наибольшая цифра числа {number} -> {secondDigit}");

//          Решение через Тернарный оператор

// if (firstDigit == secondDigit) Console.WriteLine($"Цифры рывны");
// else
// {
//     int max = firstDigit > secondDigit ? firstDigit : secondDigit;
//     System.Console.WriteLine($"Наибольшая цифра числа {number} -> {max}");
// }

//          Решение через Метод

int MaxDigit(int num)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}
int maxDigit = MaxDigit(number);
System.Console.WriteLine($"Наибольшая цифра числа {number} -> {maxDigit}");