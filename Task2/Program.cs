double[] a = {3, 6, 8};
double[] b = {2, 1, -7};
//double [] a = {7, -5, 0};
//ouble [] b = {1, -1, 9};
double Squaring(double num1, double num2)
{
    double number = Math.Pow((num2-num1),2);
    return number;
}
double sum = Squaring(a[0],b[0])
            +Squaring(a[1],b[1])
            +Squaring(a[2],b[2]);
double result = Math.Sqrt(sum);
Console.WriteLine($"Расстояние равно = " + result);

