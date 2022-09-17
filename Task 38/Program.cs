// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int minNumber = 0;
int maxNumber = 0;
int residual = 0;

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

//Функция сравнения элементов массива min и max
int GetResidual(int [] array)
    {
        maxNumber = array[0];
        minNumber = array[0];
                
        for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxNumber) maxNumber = array[i];
                if (array[i] < minNumber) minNumber = array[i];
            }
            residual = maxNumber - minNumber; // выявляем разницу
    
        return residual;          
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
GetResidual(array);

//Результат
Console.WriteLine($"Разница между максимальным и минимальным элементов массива = {residual}");
Console.WriteLine($"Ваш массив из случайных чисел [{string.Join(",", array)}] ");

