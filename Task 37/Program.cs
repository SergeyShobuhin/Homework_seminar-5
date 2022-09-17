// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21



int tempArray = 0;
int [] rezult = null;

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

//Функция умножения парных элементов 
int [] GetMultPairs(int [] array)
    {
        
        if (array.Length % 2 == 0) // если количество элементов массива чётное
        {
            tempArray = array.Length / 2;
            rezult = new int[tempArray];

            for (int i = 0; i < tempArray; i++)
            {
                rezult[i] = array[i] * array[array.Length - i - 1];
            }
        }
        else  //  если количество элементов массива НЕ чётное
        {
            tempArray = (array.Length / 2) + 1; 
            rezult = new int[tempArray];

            for (int i = 0; i < tempArray; i++)
            {
                if (i == (tempArray - 1))
                {
                    rezult[i] = array[i];
                }
                else
                {
                    rezult[i] = array[i] * array[array.Length - i - 1];
                }
            }
        }
        
        return rezult;
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
GetMultPairs(array);

//Результат
Console.WriteLine($"Ваш массив из случайных чисел в интервале от {minValue} до {maxValue}: [{string.Join(",", array)}] ");
Console.WriteLine($"Произведение пар массива = [{string.Join(",", rezult)}] ");




// Console.WriteLine(GetMultPairs(array));