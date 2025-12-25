using System;
    
class Program
{
    static void Main()
    {
        Console.WriteLine("Калькулятор");
        Console.Write("Введите первое число: ");
        double num1_double = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите второе число: ");
        double num2_double = Convert.ToDouble(Console.ReadLine());
        double inc1 = num1_double;
        double inc2 = num2_double;
        bool tempbool1 = Convert.ToBoolean(num1_double);
        bool tempbool2 = Convert.ToBoolean(num2_double);
        int tempint1 = Convert.ToInt32(num1_double);
        int tempint2 = Convert.ToInt32(num2_double);
        int sdvig = tempint1 << tempint2;
        int sdvigpr = tempint1 >> tempint2;
        Console.WriteLine($"Сложение: {num1_double} + {num2_double} = {num1_double + num2_double}");
        Console.WriteLine($"Вычитание: {num1_double} - {num2_double} = {num1_double - num2_double}");
        Console.WriteLine($"Умножение: {num1_double} * {num2_double} = {num1_double * num2_double}");
        Console.WriteLine($"Деление: {num1_double} / {num2_double} = {num1_double / num2_double}");
        Console.WriteLine($"Остаток от деления: {num1_double} % {num2_double} = {num1_double % num2_double}");
        Console.WriteLine($"Инкремент первого числа: {inc1}++ = {++inc1}");
        inc1 = num1_double;
        Console.WriteLine($"Декремент первого числа: {inc1}-- = {--inc1}");
        Console.WriteLine($"Инкремент второго числа: {inc2}++ = {++inc2}");
        inc2 = num2_double;
        Console.WriteLine($"Декремент второго числа: {inc2}-- = {--inc2}");
        Console.WriteLine("КОНЕЦ ОСНОВНЫХ ОПЕРАЦИЙ!!! НАЧАЛО ЛОГИЧЕСКИХ!!!");
        Console.WriteLine($"Логическое умножение (&): {tempint1} & {tempint2} = {tempint1 & tempint2}");
        Console.WriteLine($"Логическое сложение: {tempint1} | {tempint2} = {tempint1 | tempint2}");
        Console.WriteLine($"Логическое исключающее ИЛИ: {tempint1} ^ {tempint2} = {tempint1 ^ tempint2}");
        Console.WriteLine($"Поразрядная исключающее ИЛИ: {tempint1} ^ {tempint2} = {tempint1 ^ tempint2}");
        Console.WriteLine($"Сдвиг влево: {tempint1} << {tempint2} = {sdvig}");
        Console.WriteLine($"Сдвиг вправо: {tempint1} >> {tempint2} = {sdvigpr}");
        Console.WriteLine($"Логическая инверсия: !({tempbool1} == {tempbool2}) = !{tempbool1 == tempbool2}");
    }

}
