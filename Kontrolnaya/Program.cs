string[] myArray = {"Hello", "My", "World"};
string[] printArray = new string[myArray.Length];
string k = "";

for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i].Length <= 3) 
    {
        printArray[i] = myArray[i];          //Записываем элемент в массив другой массив.
        Console.Write(printArray[i] + "\t"); //Печатаем элемент массива.
        k = myArray[i];
    }
}

if (k.Length == 0) Console.WriteLine("В массиве нет элементов с количеством символов <= 3.");
return;