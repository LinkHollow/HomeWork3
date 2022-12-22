// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.WriteLine("Введите пятизначное число: ");
string num = Console.ReadLine()!;
if(num.Length < 5 || num.Length > 5)
{
    System.Console.WriteLine("Введено не пятизначное число");
}
else 
{
    int con1 = Convert.ToInt32(Convert.ToString(num[0]));
    int con2 = Convert.ToInt32(Convert.ToString(num[1]));
    int con3 = Convert.ToInt32(Convert.ToString(num[3]));
    int con4 = Convert.ToInt32(Convert.ToString(num[4]));
      if(con1 == con4 && con2 == con3)
    {
        System.Console.WriteLine("Число является палиндромом");
    }
    else
    {
        System.Console.WriteLine("Число не является палиндромом");
    }
}