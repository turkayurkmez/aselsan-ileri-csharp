// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("Hello, World!");
/*
 * List,
 * Dictionary,
 * HashSet,
 * Tükenen koleksiyonlar
 * LinkedList,
 * 
 */

List<Person> people = new List<Person>
{
    new Person { Name = "Ali", Age = 20 },
    new Person { Name = "Veli", Age = 30 },
    new Person { Name = "Deli", Age = 40 }
};

List<string> words = new List<string> { "Ali", "Veli", "Deli" };
Dictionary<int, string> plates = new Dictionary<int, string>();
Dictionary<int, CustomValue> keyValuePairs = new Dictionary<int, CustomValue>();

plates.Add(34, "İstanbul");
//plates.Add(34, "İzmir");
if (!plates.TryAdd(34,"İstanbul"))
{
    Console.WriteLine("Aynı key olduğundan eklenemedi!");
}

var izmirVarMi = plates.TryGetValue(35, out string city);
if (!izmirVarMi)
{
    Console.WriteLine("Yok izmir falan");
}

HashSet<string> cities = new HashSet<string> { "İstanbul", "Ankara", "İzmir" };
cities.Add("Yozgat");

cities.ToList().ForEach(c => Console.WriteLine(c));

Hashtable table = new Hashtable();



if (words.Contains("Ali"))
{

}

people.Contains(new Person { Name = "Ali", Age = 20 });
people.ForEach(p => Console.WriteLine(p.Name));
bool firstLetterIsBig = people.TrueForAll(p => (char.IsUpper( p.Name[0])));

if (firstLetterIsBig)
{

}

foreach (var person in people)
{
    Console.WriteLine(person.Name);
    people.Remove(person);
}



public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    // override object.Equals
    public override bool Equals(object obj)
    {
        //       
        // See the full list of guidelines at
        //   http://go.microsoft.com/fwlink/?LinkID=85237  
        // and also the guidance for operator== at
        //   http://go.microsoft.com/fwlink/?LinkId=85238
        //

        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        // TODO: write your implementation of Equals() here       
        return base.Equals(obj);
    }

    // override object.GetHashCode
    public override int GetHashCode()
    {
        // TODO: write your implementation of GetHashCode() here
        throw new NotImplementedException();
        return base.GetHashCode();
    }


    //public class CustomValue
    //{
    //    public List<string> Elements { get; set; }
    }






public class CustomValue
{
    public int Id { get; set; }
    public string Name { get; set; }
}


