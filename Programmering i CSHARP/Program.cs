Console.WriteLine("Enter size of square");

int Size;

Size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

for (int row = 0; row < Size; row++)
{
    for (int column = 0; column < Size; column++)
    {
        if (row == 0 || column == 0 || row == Size - 1|| column == Size - 1)
        {
            Console.Write("* ");
        }
        else
        {
            Console.Write("  ");
        }
    }
    Console.WriteLine();
}



// ---------------------------------------------------
Random rnd = new Random();

int num = rnd.Next(100) + 1;
Console.WriteLine(num);
// ---------------------------------------------------

int Count = 1;
int Sum = 0;

while(Count<1001)
{
    Sum = Sum + Count; 
    Count++;
    Console.WriteLine(Sum);
}

// ---------------------------------------------------