﻿/*void Metod1()
{
    Console.WriteLine("Автор...");
}
Metod1();*/


/*void Metod2(string msg)
{
    Console.WriteLine(msg);
}
Metod2("Текст сообщения");*/


/*Именованные аргументы*/
/*void Metod2_1(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Metod2_1("Текст", 4);
Metod2_1(msg: "Текст",count: 4);
Metod2_1(count: 4, msg: "Текст");*/


/*int Metod3()
{
    return DateTime.Now.Year;
}
int year = Metod3();
Console.WriteLine(year);*/


/*string Metod4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while(i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Metod4(10, "asdf");
Console.WriteLine(res);*/

/*for*/

/*string Metod4(int count, string text)
{
    string result = String.Empty;
    for(int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Metod4(10, "asdf");
Console.WriteLine(res);*/

/*for (int i = 2; i < 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine ($"{i} * {j} = {i * j}");
    }
    Console.WriteLine ();

}*/


/*string text = "Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого"
            + "Винценгероде, вы бы взяли приступом согласие"
            + "прусского короля. Вы так красноречивы. Вы"
            + "дадите мне чаю?";

//string s = "qwerty" q - 0, w - 1, e - 2, r - 3
//s[3] = r
string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
         if(text[i] == oldValue) result = result + $"{newValue}";
         else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'с', 'С');
Console.WriteLine(newText);*/




int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)
{
    int count = array.Length;
    
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);