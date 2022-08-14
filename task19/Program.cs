// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.

Console.WriteLine( "Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int dig1 = number/10000;
int dig2 = number/1000%10;
int dig4 = number/10%10;
int dig5 = number%10;

if( dig1 == dig5 && dig2 == dig4)
{
    Console.WriteLine("Это число палиндром!");
}
else
{
   Console.WriteLine("Это число не является палиндромом!"); 
}

