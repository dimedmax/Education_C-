// Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы

int[] array = { 1, 2, 5, 0, 10, 34 };

Reverse(array, array.Length - 1);

void Reverse(int[] array, int index){
    if (index < 0)
        return;
    Console.Write(array[index]);

    if (index != 0)
        Console.Write(" ");

    Reverse(array, index - 1);
}