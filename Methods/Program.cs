// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

void MyPrintFunc(string name, int age)
{
    Console.WriteLine($"Hey, my name is, {name}. I am {age} years old.");
};

MyPrintFunc("Marcus", 23);


// params for in


int myIf(bool returnA, int a, int b)
{
    if (returnA)
    {
        return a;
    }

    return b;
}

Console.WriteLine();