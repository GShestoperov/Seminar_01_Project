
Console.Write("Введите число: ");
int N;
while (!int.TryParse(Console.ReadLine(), out N)) ;

int index = -N;

while (index <= N)
{
    if (index % 2 == 0)
    {
        Console.Write(index + " ");
    }
    index++;
}

