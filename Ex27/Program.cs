// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

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

int Summa(int value){ // Сумма цифр в числе
int tmp = 0;
    for(int i = 0; value > 0; i++)
    {
       int iteration = value % 10; // магия
       tmp = tmp + iteration;      // магия
       value /= 10;                // магия
    }
    return tmp;}

int Number = InputInt("Введите произвольное число  --> ");
System.Console.WriteLine($"Сумма цифр в числе равна =>  {Summa(Number)}");