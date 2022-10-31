// Задача15 Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите цифру от 1 до 7");
int num = Convert.ToInt32(Console.ReadLine());
if (num<1 || num>7){
    Console.WriteLine("Вы ввели число меньше 1 или больше 7");
}
 else if (num>0 && num<6){
    Console.WriteLine("Это будний день");
}
else{
    Console.WriteLine("Это выходной день");
}
