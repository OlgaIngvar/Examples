System.Console.WriteLine("Введите Ваше имя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    System.Console.WriteLine("Ура, это снова Маша");
}
else
{
    System.Console.Write("Привет, ");
    System.Console.WriteLine(username);
}