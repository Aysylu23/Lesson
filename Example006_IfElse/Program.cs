
Console.Write("Введите имя пользователя:");
string username = Console.ReadLine();

if(username.ToLower() == "маша") //ToLover -переводит все буквы в нижний регистр
{
    Console.WriteLine("Ура, это же МАША!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}

