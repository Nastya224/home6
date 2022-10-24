Console.Write("Кол-во чисел:");
int N = int.Parse(Console.ReadLine());

int counter = 0;

for (int k =0; k < N; k++)
{
    int number = int.Parse(Console.ReadLine()!);
    if (number>0)
    {
        counter++;
    }
}
Console.Write("Кол-во чисел больше нуля:");
Console.WriteLine(counter);