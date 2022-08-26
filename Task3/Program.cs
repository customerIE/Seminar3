int N = new Random().Next(1,10);
int[] array = new int [N];
int cubic_degree(int num)
{
    num = Convert.ToInt32(Math.Pow(num,3));
    return num;
}
Console.WriteLine($"Таблица кубов от 1 до " + N + " - ");
for (int i=0; i<N; i++)
{
    array[i] = cubic_degree(i+1);
    Console.Write(array[i] + " ");
}


