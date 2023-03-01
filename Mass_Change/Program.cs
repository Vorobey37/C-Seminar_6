/*
Напишите программу, которая перевернёт одномерный массив 
(последний элемент будет на первом месте, а первый - на последнем и т.д.)

[1 2 3 4 5] -> [5 4 3 2 1]
*/

Console.Clear();
int[]GetArray (int n) // Создаем массив на n элементов от и заполняем
{
    int [] array = new int [n];
    for (int i=0; i<n; i++)
    {
        array[i] = new Random().Next(1, 11);
        
    }
    return array;
}
int []array = GetArray (5);

void ChangeElementsInArray (int [] array) // Почему-то не работает
{
    
    for (int i=0; i<array.Length/2; i++)
    {
        int temp = array[i];
        array [i] = array[array.Length-i-1];
        array [array.Length-i-1] = temp;
        
    }
    //return array;
}

int [] ChangeElements(int [] array)
{
    int [] array1 = new int [array.Length];
    for (int i=0; i<array1.Length; i++)
    {
        array1[i] = array[array1.Length-i-1];
    }
    return array1;
}

//int []array1 = ChangeElementsInArray (array);
int []array2 = ChangeElements(array);
Console.WriteLine($"[{String.Join(" ", array)}] -> [{String.Join(" ", array2)}]");
//ChangeElementsInArray (array);