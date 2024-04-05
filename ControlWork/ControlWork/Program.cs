namespace ControlWork;

class Program
{
    static void Main(string[] args)
    {
        var dictCities = new Dictionary<string, int>();
        dictCities.Add("Kazan", 1000000);
        dictCities.Add("Moscow", 12615882);
        dictCities.Add("Saint Petersburg", 5398064);
        dictCities.Add("Novosibirsk", 16100);
        dictCities.Add("Yekaterinburg", 14830);
        dictCities.Add("Nizhny Novgorod", 1252236);
        dictCities.Add("Samara", 11900);
        dictCities.Add("Omsk", 115400);
        dictCities.Add("Chelyabinsk", 1130273);
        dictCities.Add("Rostov-on-Don", 1130305);
        dictCities.Add("Ufa", 1128787);
        
        foreach (var city in dictCities)
        {
            if(city.Value > 1000000) Console.WriteLine(city.Key);
        }

        Console.WriteLine("---------------------");
        int[] intArray = { 1, 2, 2, 3, 4, 4, 5 };
        string[] stringArray = { "apple", "banana", "apple", "cherry", "banana" };
        Student[] students = new Student[]
        {
            new Student("Иван Иванов", 1),
            new Student("Мария Смирнова", 2),
            new Student("Петр Петров", 1),
            new Student("Олег Алексеев", 3),
            new Student("Анна Кузнецова", 2),
            new Student("Анна Кузнецова", 2),
            new Student("Иван Иванов", 1)
        };
        PrintArray(GetDistinctValues(intArray));
        PrintArray(GetDistinctValues(stringArray));
        PrintArray(GetDistinctValues(students));
    }

    static void PrintArray<T>(T[] array)
    {
        foreach (var element in array)
        {
            Console.Write($"{element}   ");
        }
        Console.WriteLine();
    }
    
    static T[] GetDistinctValues<T>(T[] array)
    {
        if (array == null || array.Length == 0) return Array.Empty<T>();
        var distictValues = new List<T>();
        foreach (var value in array)
        {
            if(!distictValues.Contains(value)) distictValues.Add(value);
        }

        return distictValues.ToArray();
    }
}