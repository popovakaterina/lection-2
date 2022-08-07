void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght) 
    {
        collection[index] = new Random().Next(1,10);
        index ++;
    }
}

void PrintArray(int [] col) //voit метод, метод который ничего не возвращает
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine (col[position]);
        position++;
    }   
}
int IndexOf(int []collection, int find) 
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // Задать по умолчанию -1, чтобы понимать, что такого эл-та массива не существует

    while(index < count)
    {
        if (collection[index] == find) 
        {
            position = index;
            break;
        }
        index++;
    }
    return position;

}
int [] array = new int [10]; //Создать новый массив с 10 эл-ми

FillArray(array); //метод заполнения массива
PrintArray(array); //метод вывода массива
Console.WriteLine();

int pos = IndexOf(array, 444); // какой элемент надо искать
Console.WriteLine(pos); // вывести индекс эл-та

