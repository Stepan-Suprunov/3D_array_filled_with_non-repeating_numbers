// Сформировать трёхмерный массив из неповторяющихся двузначных чисел. Построчно вывести массив, добавляя индексы каждого элемента.


void FillArray(int[,,] collection)
{
    int New = 10;
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            for (int k = 0; k < collection.GetLength(2); k++)
            {
                collection[i,j,k] = New;
                New++;
            }
        }
    }
}

void PrintArray(int[,,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            for (int k = 0; k < collection.GetLength(2); k++)
            {
                Console.WriteLine(collection[i, j, k] + " [" + i + "," + j + "," + k +"]");
            }
        }
    }
}

int[,,] array = new int[4, 4, 4];

FillArray(array);
PrintArray(array);