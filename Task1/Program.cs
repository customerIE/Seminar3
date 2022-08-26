int [] array = new int [5];
int length = array.Length;
int index = 0;
int digit = 0;
int number = new Random().Next(10000,100000);
//int number = 12821;
//int number = 23432;
Console.WriteLine($"Случайное 5-тизначное число = " + number);
while (number != 0) 
    {
        digit = number % 10;
        array[length-index-1] = digit;
        number = number/10;
        index++;
    }
Console.Write("Массив из полученных цифр:");
for (int i=0; i<length; i++)
{
    Console.Write($"_" + array[i]);
}
Console.WriteLine();
if ((array[0] == array[4]) && (array[1] == array[3]))
{
    Console.WriteLine($"Число - палиндром.");
}
else
{
    Console.WriteLine($"Число - НЕ палиндром.");
}
