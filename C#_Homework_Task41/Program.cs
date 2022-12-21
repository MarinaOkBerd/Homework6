//  41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Введите числа.");
string numbers = Console.ReadLine()??"";
int [] array = Array.ConvertAll(numbers.Split(), int.Parse);
int counter = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        counter ++;
    }
    
}

Console.WriteLine($"Введено {counter} чисел больше нуля.");

