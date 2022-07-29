//Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма.

void Print(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "   ");
    }
}

string[] startMassiv = { "hello", "2", "world", ":-", "4 5*", "onion.", "", "~!k" };


int SearchMassLen(string[] mass, int strLen, string specStr) // specStr - строка больше длины strLen
{
    int count = 0;
    for (int i = 0; i < mass.Length; i++) // поиск длины финишного массива
    {
        if (mass[i].Length <= strLen)
        {
            count++;
        }
        else
        {
            mass[i] = specStr; // исключаем строки длинее 3х символов
        }
    }
    return count;
}

void CreateFinishMass(string[] mass1, string[] mass2, int strLen)
{
    for (int i = 0, j = 0; i < mass1.Length; i++)
    {
        if (mass1[i].Length <= strLen)
        {
            mass2[j] = mass1[i];
            j++;
        }
    }
}

Print(startMassiv);
Console.WriteLine();

int count = SearchMassLen(startMassiv, 3, "1111");// длина финишного массива
string[] finishMassiv = new string[count]; // создаём финишный массив
CreateFinishMass(startMassiv, finishMassiv, 3);
Print(finishMassiv);
