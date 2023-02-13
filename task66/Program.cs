// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// 1.   Функция получения положительного числа от пользователя с проверкой, что задано число
// 2.   Функция нахождения суммы натуральных элементов в промежутке от M до N
// 3.   Демонстрация работы с выводом в консоль
// 3.1  Ввод данных с проверкой
// 3.2  Вызов функции с выводом результата в консоль
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

// 2.   Функция нахождения суммы натуральных элементов в промежутке от M до N
int GetSummOfAllElementsFromMToN(int M, int N)
{
    int result = 0;
    for(int i = M; M <= N; M++) result += M;

    return result;
}

// 3.   Демонстрация работы с выводом в консоль
string exit_condition = "";

while (exit_condition != "n")
{
    // 3.1  Ввод данных с проверкой
    System.Console.WriteLine("Программа выведет сумму всех натуральных элементов в промежутке от M до N");
    System.Console.WriteLine("Введите число M:  ");
    int M = getPositiveIntNumberFromUserWithCheck();
    System.Console.WriteLine("Введите число N:  ");
    int N = getPositiveIntNumberFromUserWithCheck();
    
    // 3.2  Вызов функции с выводом результата в консоль
    int summ = GetSummOfAllElementsFromMToN(M, N);
    System.Console.WriteLine($"Сумма всех натуральных элементов в промежутке от {M} до {N} равна: " + summ);
    // 4.   Немного интерфейса))
    System.Console.Write("Хотите сделать это ещё раз? y / n  ");
    exit_condition = Console.ReadLine()!;
}

System.Console.WriteLine("Благодарим за использование программы!");
