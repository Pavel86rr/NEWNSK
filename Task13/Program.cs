//Задача 13. Напишите программу, которая
// выводит третью цифру щаланного чисоа или сообщает,
// что третьей цифры нет

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = num;
int index = 0;
int index1 = 0;

while(num > 0)
{
 num = num/10;
 index +=1;
}

while (index1 <= index - 4)
{ 
   num1 = num1/10; 
   index1 +=1;
}
Console.WriteLine("{0} -Третья цифра числа", num1%10);
