//Задача 10. 
//Напишите программу, которая принимает на вход
// трехзначное число и на выходе  показывает вторую
// цифру этого числа

Console.WriteLine("Введите трехзначное число");

int num = Convert.ToInt32(Console.ReadLine());
if(num<1000 && num>=100)
{
    Console.WriteLine((num/10)%10);
}
else
{
    Console.WriteLine("Число не трехзначное");   
}