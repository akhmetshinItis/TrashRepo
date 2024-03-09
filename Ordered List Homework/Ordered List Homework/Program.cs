using StackApp;
var l = new OrderedList<int>();
var r = new Random();
for (int i = 0; i < 5; i++)
{
    l.Add(r.Next(0, 10));
}

var l2 = new OrderedList<int>();
for (int i = 0; i < 6; i++)
{
    l2.Add(r.Next(0, 10));
}
Console.WriteLine(l);
Console.WriteLine(l2);
l.Merge(l2);
Console.WriteLine(l);

