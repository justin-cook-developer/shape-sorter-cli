using System;

namespace shape_sorter_cli
{
  class Circle : Shape
  {
    private readonly double radius;

    public Circle(double radius)
    {
      this.radius = radius;
    }

    public override sealed double Area()
    {
      return Math.PI * radius * radius;
    }

    public override sealed double Perimeter()
    {
      return 2 * Math.PI * radius;
    }

    public override string ToString()
    {
      return "Circle          -- Radius: " + radius
              + ",             Area: " + String.Format("%.1f", Area())
              + ", Perimeter: " + String.Format("%.1f", Perimeter());
    }
  }
}
