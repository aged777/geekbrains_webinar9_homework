// Задача 64: Задайте значение N. Напишите программу, которая 
// выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// 1.   Функция проверки, что задано число
// 2.   Функция вывода натуральных чисел от N до 1
// 3.   Демонстрация работы с выводом в консоль
// 3.1  Ввод данных с проверкой
// 3.2  Демонстрация работы функций с выводом в консоль
// 4.   Немного интерфейса))

// 1.   Функция получения положительного числа от пользователя с проверкой, что задано число
int getPositiveIntNumberFromUserWithCheck()
{
    int result = 0;
    bool ifNumber = false;

    while (!ifNumber)
    {
        System.Console.WriteLine("Введите положительное целое число: ");
        int.TryParse(Console.ReadLine(), out result);
        if(result > 0) ifNumber = true;
    }

    return result;
}

// 2.   Функция вывода натуральных чисел от N до 1
void PrintNumbersFromNTo1(int N)
{
    if(N == 1) {
        System.Console.WriteLine(N);
        return;
    }
    System.Console.Write(N + ", ");
    PrintNumbersFromNTo1(N - 1);
    
}

// 3.   Демонстрация работы с выводом в консоль
string exit_condition = "";

while (exit_condition != "n")
{
    // 3.1  Ввод данных с проверкой
    System.Console.WriteLine("Программа выведет все натуральные числа в промежутке от N до 1.");
    System.Console.WriteLine("Введите число N:  ");
    int N = getPositiveIntNumberFromUserWithCheck();
    
    // 3.2  Демонстрация работы функций с выводом в консоль
    PrintNumbersFromNTo1(N);

    // 4.   Немного интерфейса))
    System.Console.Write("Хотите сделать это ещё раз? y / n  ");
    exit_condition = Console.ReadLine()!;
}

System.Console.WriteLine("Благодарим за использование программы!");