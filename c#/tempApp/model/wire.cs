
class Wire
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Length { get; set; }
    public int Quantity { get; set; }

  

    public void Display()
    {
        Console.WriteLine($"ID: {Id} | Wire: {Name}, Length: {Length}m, Stock: {Quantity}");
    }
    
}