// Задача 68: Напишите программу вычисления функции 
// Аккермана с помощью рекурсии. Даны два неотрицательных 
// числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// 1.   Функция получения положительного числа от пользователя с проверкой, что задано число
// 2.   Функция нахождения значения Функции Аккермана
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
long CountAccermanFunction(long M, long N) {
    if (M == 0)
        return N + 1;
    else
        if ((M != 0) && (N == 0))
            return CountAccermanFunction(M - 1, 1);
        else
            return CountAccermanFunction(M - 1, CountAccermanFunction(M, N - 1));
}

// 3.   Демонстрация работы с выводом в консоль
string exit_condition = "";

while (exit_condition != "n")
{
    // 3.1  Ввод данных с проверкой
    System.Console.WriteLine("Программа выведет значение функции Аккермана A(M, N)");
    System.Console.WriteLine("Введите число M:  ");
    long M = getPositiveIntNumberFromUserWithCheck();
    System.Console.WriteLine("Введите число N:  ");
    long N = getPositiveIntNumberFromUserWithCheck();
    
    // 3.2  Вызов функции с выводом результата в консоль
    long accermanFunctionMeaning = CountAccermanFunction(M, N);
    System.Console.WriteLine($"Значение функции Аккермана А({M}; {N}) = " + accermanFunctionMeaning);
    // 4.   Немного интерфейса))
    System.Console.Write("Хотите сделать это ещё раз? y / n  ");
    exit_condition = Console.ReadLine()!;
}

System.Console.WriteLine("Благодарим за использование программы!");

