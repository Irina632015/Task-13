//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
///645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
int num = int.Parse(Console.ReadLine());
int k = (int)Math.Log10(num)-2;
Console.WriteLine(k < 0 ? "No such digit" : (num % (int)Math.Pow(10, k + 1) / (int)Math.Pow(10, k)).ToString());
Console.ReadLine();