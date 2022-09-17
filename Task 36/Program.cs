// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int sum = 0;

// Функция определения массива
int [] GetArray(int n, int minValue, int maxValue)
    {
        int[] array = new int [n];
        var random = new Random();

        for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(minValue, maxValue + 1);   
            }

        return array;
    }

//Функция сложения элементов стоящих на нечётных позициях.
int PrintGetSumNoteven(int [] array)
    {
        // int sum = 0;
        for (int i = 1; i < array.Length; i++)
            {
                sum = sum + array [i];
                i++;
            }
    
        return sum;   
    }

//Определяем массив
Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите начальное значение интервала ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конечное значение интервала: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

//Вызов функций
int [] array = GetArray(n, minValue, maxValue);
PrintGetSumNoteven(array);

//Результат
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях в интервале от {minValue} до {maxValue} равно {sum}.");
Console.WriteLine($"Ваш массив из случайных чисел [{string.Join(",", array)}] ");

