// See https://aka.ms/new-console-template for more information
using System.Collections.ObjectModel;

Console.WriteLine("Hello, World!");
ObservableCollection<string> list = new ObservableCollection<string>();
list.CollectionChanged += List_CollectionChanged;


list.Add("Ali");
list.Add("Veli");
list.Add("Deli");
list.Remove("Ali");
list[0] = "Mehmet";



void List_CollectionChanged(object? sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
{
	switch (e.Action)
	{
		case System.Collections.Specialized.NotifyCollectionChangedAction.Add:

            Console.WriteLine($"yeni eleman eklendi: {e.NewItems![0]}");
			break;
		case System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
            Console.WriteLine($"eleman silindi: {e.OldItems![e.OldStartingIndex]}");
            break;
		case System.Collections.Specialized.NotifyCollectionChangedAction.Replace:
            Console.WriteLine($"yeni değişiklik var... {e.NewStartingIndex}");
            break;
		case System.Collections.Specialized.NotifyCollectionChangedAction.Move:
			Console.WriteLine($"yeni değişiklik var... {e.NewStartingIndex}");
            break;
		case System.Collections.Specialized.NotifyCollectionChangedAction.Reset:
			break;
		default:
			break;
	}
}