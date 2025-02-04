// See https://aka.ms/new-console-template for more information
using DelegatesAndEvents;

Console.WriteLine("Hello, World!");

int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//.net 1.1 (2002)
var result = Filters.Filter(numbers, isEven);
//.net 2.0 (2005)
var result2 = Filters.Filter(numbers, delegate (int x)
{
    return x % 2 == 1;
});

//.net 3.0 (2007)
var result3 = Filters.Filter(numbers, p => p % 3 == 0);




show(result);


bool isEven(int number)
{
    return number % 2 == 0;
}



void show(int[] result)
{
    result.ToList().ForEach(p =>
    {
        Console.WriteLine(p);

    });
}