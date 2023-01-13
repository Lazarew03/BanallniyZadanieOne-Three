using System;

namespace BanallniyZadanie 
{
    internal class Program 
    {
        static void Main() 
        {
            Task task = new Task();// Создаю экземпляр класса Task - task
            Console.WriteLine("\tСравнение двух чисел"); 
            Console.Write(" Введите первое число: ");
            int numberOne = Convert.ToInt32(Console.ReadLine()); // Что ввёл пользователь конвертируется в int(т.к изначально string, и если не будет каста, то метод не сможет выполниться(т.к параметры метода в int)(далее в АНАЛогичных(Ростельком не одобряет) примерах не расписываю)) и присваивается переменной numberOne
            Console.Write(" Введите второе число: ");
            int numberTwo = Convert.ToInt32(Console.ReadLine());// Что ввёл пользователь конвертируется в int(т.к изначально string) и присваивается переменной numberTwo
            task.СomparisonNumber(numberOne, numberTwo); // Вызывается метод из экземпляра класса task, принимающий 2-а параметра(numberOne, numberTwo)
            Console.WriteLine("\tПрограмма которая знает только числа больше 5 И не меньше 10");
            Console.Write(" Введите число: ");
            int numberBetween = Convert.ToInt32(Console.ReadLine());// Что ввёл пользователь конвертируется в int(т.к изначально string) и присваивается переменной numberBetween
            task.NumberBetweenFiveAndTen(numberBetween); // Вызывается метод из экземпляра класса task, принимающий 1 параметр(numberBetween)
            Console.WriteLine("\tПрограмма которая знает только числа равные 5 ИЛИ 10");
            Console.Write(" Введите число: ");
            int equalNum = Convert.ToInt32(Console.ReadLine());// Что ввёл пользователь конвертируется в int(т.к изначально string) и присваивается переменной numberTwo
            task.EqualFiveOrTen(equalNum);// Вызывается метод из экземпляра класса task, принимающий 1 параметр(equalNum)
            Console.ReadKey();

        }
    }
    public class Task // создаю класс Task в котором хранятся методы по заданиям : один, два, три
    {
        public void СomparisonNumber(int numOneComparse, int numTwoComparse) //публичный метод сравнения, не возвращающий ничего, с двумя параметрами
        {
            // три условия. сравнивают 2 параметра метода(больше, равно и меньше)
            if (numOneComparse > numTwoComparse)
            {
                Console.WriteLine($" Ответ: {numOneComparse} больше {numTwoComparse}");
            }
            if (numOneComparse == numTwoComparse)
            {
                Console.WriteLine($" Ответ: {numOneComparse} равно {numTwoComparse}");
            }
            if (numOneComparse < numTwoComparse)
            {
                Console.WriteLine($" Ответ: {numOneComparse} меньше {numTwoComparse}");
            }
        }
        public void NumberBetweenFiveAndTen(int numBetween)//публичный метод между 5 и 10, не возвращающий ничего, с одним параметром
        {
            // условие - если параметр больше 5 и(знак &&) меньше 10, выводит строку о выше сказанном, если нет , то выводит строку "Неизвестное число"
            if (5 < numBetween && numBetween < 10)
            {
                Console.WriteLine($" Число {numBetween} больше 5 и меньше 10.");
            }
            else
            {
                Console.WriteLine(" Неизвестное число");
            }
        }
        public void EqualFiveOrTen(int equalNum)//публичный метод равенство 5 или 10, не возвращающий ничего, с одним параметром
        {
            // условие - если параметр равен 5 или(знак ||) равен 10, выводит строку о выше сказанном, если нет , то выводит строку "Неизвестное число"
            if (5 == equalNum || equalNum == 10)
            {
                Console.WriteLine($" Число {equalNum} либо равно 5, либо равно 10.");
            }
            else
            {
                Console.WriteLine(" Неизвестное число");
            }
        }
    }
}
