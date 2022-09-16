// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

 
// Функция определения массива 
int [] GetArray(int n)
    {        
        int[] array = new int [n];
        for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(100, 1000);
            }

        return array;
    }

// Функция определения чётных чиссел в массиве
void PrintGetEvenNumbers(int [] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                    {
                        count++;
                    }                                
            } 
       
       Console.WriteLine($"Ваш массив из случайных чисел [{string.Join(",", array)}] ");
       Console.WriteLine($"Чётных чисел в массиве {count}");
    }


//Определяем массив
Console.WriteLine("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());

// Вызов функций
int [] array = GetArray(n);
PrintGetEvenNumbers(array);