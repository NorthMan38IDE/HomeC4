// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Блок функций
int InputInt(string msg){ // Проверка на вшивость
    System.Console.Write($"{msg}");
    int value;
    bool isCorrect = int.TryParse(Console.ReadLine(), out value);
    if (isCorrect)
    {
        return value;
    }
    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(1);
    return 0;} 

bool ValidateNumberB (int numB){ // Проверка на нулевое или отрицательное значение второго числа
    if (numB <= 0)
    {
        System.Console.WriteLine("Значение не должно быть отрицательным или равным нуля");
        return false;
    }
    return true;}


int Stepen(int numA, int numB){ // Вычисление степени B
    int iteration = 1;
    for(int count = 0; count < numB; count++)
    {
        iteration *= numA;
    }
    return iteration;}


// Блок вычисления

int numberA = InputInt("Введите число A:  ");
int numberB = InputInt("Введите число B:  ");
System.Console.WriteLine();
if (ValidateNumberB(numberB))
{
System.Console.WriteLine(
    $" Результат возведения числа А: {numberA} в натуральную степень числа B: {numberB} равен =  {Stepen(numberA, numberB)}"
);
}