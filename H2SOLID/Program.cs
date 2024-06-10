using H2SOLID;

// Create a list of shapes
List<Square> shapes = new List<Square> { };

Square square = new Square(5.0);
shapes.Add(square);

Square rectangle = new Rectangle(5.5,8.5);
shapes.Add(rectangle);

Square parallelogram = new Parallelogram(5.5, 8.5, 45);
shapes.Add(parallelogram);

Square trapezoid = new Trapezoid(10,9,8,9);
shapes.Add(trapezoid);

Square rightTriangle = new RightTriangle(5, 12, 13);
shapes.Add(rightTriangle);

// Display the area and perimeter of each shape
foreach(Square shape in shapes)
{
    Console.WriteLine(shape.GetType().Name);
    Console.WriteLine($"Area: {shape.Area()}, perimeter: { shape.Perimeter()}\n");
}

Console.ReadLine();
