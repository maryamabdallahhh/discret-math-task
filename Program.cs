// See https://aka.ms/new-console-  


Console.Write("enter the first number : ");
int num1 = int.Parse(Console.ReadLine());
Console .Write("enter the second number : ");
int num2= int.Parse(Console.ReadLine());
Console.WriteLine("the prime numbers are : ");
    for (int i = num1; i < num2; i++)
    {
    int j;
    for (j = 2; j < i; j++)
    {
        if (i % j == 0) break;
    }
        if (j == i) Console.WriteLine("{0}, ", i);

    }
    

