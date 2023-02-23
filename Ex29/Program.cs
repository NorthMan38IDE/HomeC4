// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

//                                      Блок функций
int InputInt(string msg){                                   // Проверка на вшивость
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

int[] creationArray(int size, int minValue, int maxValue ){ // Функция создания массива и заполнение рандомными значениями
    int[] newArray = new int[size];
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue+1); // используем заданные пороги минимального и максимального рандомных значений
    }
    return newArray;}


void PrintArray(int[] array){                               // Вывод массива
    for (int i = 0; i < array.Length; i++)
    {
        System.Threading.Thread.Sleep(50);
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.WriteLine();}

//                                      Блок Вызова
int sizeMassive = InputInt("Введите размер массива --- >  ");
int minRnd = InputInt("Введите минимальное значение массива --- >  ");
int maxRnd = InputInt("Введите максимальное значение массива --- >  ");
int[] RandomArray = creationArray(sizeMassive, minRnd, maxRnd);
PrintArray(RandomArray);



