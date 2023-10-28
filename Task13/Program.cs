// See https://aka.ms/new-console-template for more information
int Promt (string message)
{
    Console.Write (message);
    string value=Console.ReadLine();
    int result=Convert.ToInt32(value);
    return result;
}

int Zadacha (int number)
{
    while (number>999)
    {
        number=number/10;
    }
    return number%10;
}
int number = Promt("Введите число ");
if (number < 100)
{
    Console.Write("Третьей цифры нет ");
}
else
{
    Console.Write(Zadacha(number));
}