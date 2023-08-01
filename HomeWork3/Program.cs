using Array = HomeWork3.InterfaceHW.Array;

int[] data = { 10, 5, 30, 12, 50 };
int[] data2 = { 123, 101, 125, 107, 132, 111 };
Array array = new(data);
Array array2 = new(data2);

//Вызов метода Show() без info
array.Show();
array2.Show();

//Вызов метода Show() с info
array.Show("Это массив целых чисел");
array2.Show("Это массив целых чисел больше 100");

//ищем нужное число в массие 
int valueToSearch = 30;
if (array.Search(valueToSearch))
{
    Console.Write($"\nЧисло {valueToSearch} найдено в массиве - ");
    array.Show();
}   
else
    Console.WriteLine($"\nЧисло {valueToSearch} не найдено в массиве.");

//Сортировка
Console.WriteLine("\nИсходник массива: ");
array.Show();

Console.WriteLine("\nотсортировано по возрастанию:");
array.SortAsc();
array.Show();

Console.WriteLine("\nОтсортировано по убыванию:");
array.SortDesc();
array.Show();

Console.WriteLine("\nСортировка по параметру (возростание):");
array.SortByParam(true);
array.Show();

Console.WriteLine("\nСортировка по параметру (убывание):");
array.SortByParam(false);
array.Show();