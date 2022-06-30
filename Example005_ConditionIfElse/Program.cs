Console.WriteLine("Введите имя пользователя ");
string UserName = Console.ReadLine();

if (UserName.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же Маша!");
} 
else
{
    Console.WriteLine("Привет, " & UserName);
}
