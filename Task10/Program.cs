// See https://aka.ms/new-console-template for more information
Console.Write("Введите трехзначное число");
int number=Convert.ToInt32(Console.ReadLine());
if((number>99&&number<1000)||(number<-99&&number>-1000))
{
    int result=number%100/10;
    Console.Write("Вторая цифра числа"+result);
}
else
{
    Console.Write("Неверно введено число");
}