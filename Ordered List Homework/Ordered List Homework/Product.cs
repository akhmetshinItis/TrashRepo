internal class Product : IComparable
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }


    public override string ToString()
    {
        return $"{Id} {Name} {Price}";
    }

    public int CompareTo(object? obj)
    {
        var p = obj as Product;
        if (obj == null)
            throw new ArgumentException("Нельзя сравнить с продуктом");
            
        if (this.Price > p.Price)
            return 1;
        if (this.Price < p.Price)
            return -1;
        return 0;
             
    }
}