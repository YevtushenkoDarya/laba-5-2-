using System;
using System.Globalization;
namespace Laba5
{
    public class Program
    {
        static void Main()
        {
            string number = Console.ReadLine(); // ввод числа
            if (SumNumber(number) == 0) Console.WriteLine("exception"); // ветка для некорректного ввода
            else
            {
                Console.WriteLine(SumNumber(number)); // ветка для корректного ввода
            }
        }
        static int SumNumber(string number) // метод для сложения цифр
        {
            int result = 0; // задание переменной для хранения суммы цифр
            for (int i = 0; i < number.Length; i++) // цикл перебирает каждый элемент строки
            {
                if ((int)number[i] > 47 && (int)number[i] < 58) result = result + (int)number[i] - 48; // проверка является ли символ цифрой
                else if ((int)number[i] == 45 && i==0); // ветка если число число отрицательное
                else 
                {
                    result = 0; // ветка если число введено не корректно
                    return result; // возвращение значения в случае некорректного ввода
                }
            }
            return result; // возвращение значение в случае корректного ввода
        }
    }
}
