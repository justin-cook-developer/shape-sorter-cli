using System;

namespace shape_sorter_cli
{
  class Rectangle : Shape, IStretchable
  {
    private double length;
    private double width;

    public double Length => length;
    public double Width => width;

    public Rectangle(double length, double width)
    {
      this.length = length;
      this.width = width;
    }

    public override sealed double Area()
    {
      return length * width;
    }

    public override sealed double Perimeter()
    {
      return 2 * length + 2 * width;
    }

    public override string ToString()
    {
      return "Rectangle       -- Length: " + length + ", Width: "
              + width + ", Area: " + String.Format("%.1f", Area())
              + ", Perimeter: " + String.Format("%.1f", Perimeter());
    }

    public void Stretch(double factor)
    {
      if (factor <= 0)
        throw new ArgumentException("In Rectangle.Stretch, factor must be > 0.");

      if (length > width)
        length *= factor;
      else
        width *= factor;
    }
  }
}
