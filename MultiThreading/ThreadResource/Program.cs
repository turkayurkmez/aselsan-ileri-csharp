// See https://aka.ms/new-console-template for more information
using ThreadResource;

Console.WriteLine("Hello, World!");
Thread[] threads = new Thread[10];

for (int i = 0; i < 10; i++)
{
    threads[i] = new Thread(() => new NumberGenerator().PrintNumbers());
    threads[i].Start();
}