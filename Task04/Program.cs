//Напишите программу, которая принимает на вход
//три числа и выдает максимальное их этих чисел

int a;
int b;
int c;

Console.WriteLine("Введите первое число");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
c = Convert.ToInt32(Console.ReadLine());

 if (a>b)
 {
         if(a>c)
         {
          Console.WriteLine("{0} Максимальное первое число", a); 
         }
         else 
         {
             if (b>c)
              {
              Console.WriteLine("{0} Максимальное второе число число", b); 
              }
             else
              {
              Console.WriteLine("{0} Максимальное третье  число", c); 
              }
         }
 }
 else 
 {
            if(c>b)
         {
         Console.WriteLine("{0} Максимальное третье число", c); 
         }
         else
         {
         Console.WriteLine("{0} Максимальное третье число", b); 
         }
 }
         // Завершение четвертой задачи
