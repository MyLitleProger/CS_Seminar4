Console.Clear();
restart:
Console.WriteLine("1-4 Задачи семинара");
Console.WriteLine("5-7 Практические задачи");
Console.WriteLine("8 Дополнительная задача \n");
Console.Write("Что бы запустить какую то конкретную задау введите номер этой задачи то 1 до 8: ");
int Task = int.Parse(Console.ReadLine());

switch(Task){
    case 1:
    /*Задача 24: Напишите программу которая принимает на вход
     число А и выдает сумму чиселот 1 до А.*/
    task24:
    Console.WriteLine("Выберите способ решение 1 или 2: ");
    int choice = int.Parse(Console.ReadLine());
    double x;
    int z, sum = 0;
    switch(choice){
        case 1:
            Console.Write("Введите число А: ");
            x = double.Parse(Console.ReadLine());
            Console.Write((1 + x) / 2 * x);
        break;

        case 2:
            Console.Write("Введите число А: ");
            z = int.Parse(Console.ReadLine());
            for(int i = 0; i <= z; i++)
                sum += i;
            Console.Write($"Результат: {sum}");
        break;

        default:
        goto task24;
    }
    break;

    case 2:
    /*Задача 26: Напишите программу, которая принимает на 
    вход число и выдает количество цифр в числе.*/
    Console.Write("Введите число: ");
    z = int.Parse(Console.ReadLine());
    sum = 1;
    while(z / 10 != 0){
        z /= 10;
        sum++;
    }
        Console.Write($"Результат: {sum}");
    break;

    case 3:
    /*Задача 28: Напишите программу, которая принимает на вход 
    число N  и выдает произведение чисел от 1 до N*/
    Console.Write("Введите число А: ");
    z = int.Parse(Console.ReadLine());
    sum = 1;
    for(int i = 2; i <= z; i++)
    sum *= i;
    Console.Write($"Результат: {sum}");
    break;

    case 4:
    /*Задание 30: Напишите программу, которая выводит массив 
    из 8 элементов, заполненный нулями и единицами в случайном
    порядке.*/

    int k = 8;
    int[] mas = new int [k];
    for (int i = 0; i < mas.Length; i++)
        mas[i] = new Random().Next(0,2);

        Console.Write ($"[{string.Join(", ", mas)}]");
    break;

    case 5:
    /*Задача 25: Напишите цикл, который принимает на вход два
     числа (A и B) и возводит число A в натуральную степень B.
     НЕ ИСПОЛЬЗОВАТЬ Math.Pow*/
    Console.Write("Введите число А: ");
    int A = int.Parse(Console.ReadLine());
    Console.Write("Введите число В: ");
    int B = int.Parse(Console.ReadLine());
    int Value = A;
    for (int i = 1; i < B; i++){
        Value = Value * A; 
    }
    Console.Write($"{A},{B} -> {Value}");
    break;
    
    case 6:
    /*Задача 27: Напишите программу, которая принимает на вход
     число и выдаёт сумму цифр в числе.*/
    Console.Write("Введите число: ");
    A = int.Parse(Console.ReadLine());
    int a = A;
    Value = 0;
    while (a > 1){
        B = a % 10;
        Value = Value + B;
        a = a / 10;
        //Console.WriteLine($"{a} -> {Value}");
    }
    Console.Write($"{A} -> {Value}");
    break;

    case 7:
    /*Задача 29: Напишите программу, которая задаёт массив из 8 
     элементов, запрашивает данные(элементы массива) у пользователя
     и выводит их на экран.*/
    int n = 8;
    int[] array = new int [n];
    for (int i = 0; i < array.Length; i++){
        Console.Write("Введите элемент массива: ");
        array[i] = int.Parse(Console.ReadLine());}

        Console.Write ($"{string.Join(", ", array)} -> [{string.Join(", ", array)}] ");
    
    break;

    case 8:
    /*Дана последовательность из N целых чисел и число К. Необходимо
    сдвинуть всю последовательность (сдвиг циклический) на |К| элементов
    впарво, если К - положительное и влево, если отрицательное.*/
    System.Console.Write("Укажите размерность массива: ");
    int quantity = int.Parse(Console.ReadLine());
    int[] sequence_A = new int [quantity];
    System.Console.Write("Укажите сдвиг: ");
    int K = int.Parse(Console.ReadLine());

    for (int i = 0; i < sequence_A.Length; i++){       
        sequence_A[i] = new Random().Next(0, 10);         //заполнение масива
    }
    Console.WriteLine($"[{string.Join(", ", sequence_A)}]");
    
    if (K >= 0){
    //сдвиг вправо
    for (int j = 0; j < K; j++){

        int last = sequence_A[sequence_A.Length - 1];
        
        for (int i = sequence_A.Length - 2; i >= 0; i--){
            sequence_A[i + 1] = sequence_A[i];
        }
        sequence_A[0] = last;
    }
    Console.WriteLine($"[{string.Join(", ", sequence_A)}]"); 
    }

    else{
    //сдвиг влево
    for (int j = 0; j < Math.Abs(K); j++){
        
        int first = sequence_A[0];
        
        for (int i = 0; i <= sequence_A.Length - 2; i++){
            sequence_A[i] = sequence_A[i + 1];
        }
        sequence_A[quantity - 1] = first;
    }   
    Console.WriteLine($"[{string.Join(", ", sequence_A)}]");
    }

    break;

    default:
    Console.WriteLine("Введите корректное значение.");
    goto restart;
}