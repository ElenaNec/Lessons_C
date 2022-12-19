// Программа приветствия Маши (не важно какими буквами написано имя)

Console.Write("Введите ваше имя ");
string username = Console.ReadLine()!;
if (username.ToLower() == "маша")
{
    Console.WriteLine("Ура! Это же Маша!");
}
else
{
    Console.Write($"Привет, {username}");
}