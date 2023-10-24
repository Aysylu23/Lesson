/*void Metod1()
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

string Metod4(int count, string text)
{
    string result = String.Empty;
    for(int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Metod4(10, "asdf");
Console.WriteLine(res);