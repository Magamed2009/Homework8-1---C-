var rectangle = new Rectangle();
rectangle.width = Convert.ToInt32(Console.ReadLine());
rectangle.height = Convert.ToInt32(Console.ReadLine());
rectangle.color = Console.ReadLine();

System.Console.WriteLine(rectangle.GetArea());

System.Console.WriteLine(rectangle.GetPerimeter());

class Rectangle
{
    public int width;
    public int height;
    public string color;

    public string GetArea()
    {
        return $"Area : {width*height}";
    }
    public string GetPerimeter() 
    {
        return $"Perimetr : {(width+height)*2}";
    }
}