using System;

namespace shape_sorter_cli
{
  class Square : Shape
  {
    private readonly double side;

    public Square(double side)
    {
      this.side = side;
    }

    public override sealed double Area()
    {
      return side * side;
    }

    public override sealed double Perimeter()
    {
      return side * 4;
    }

    public override string ToString()
    {
      return "Square          -- Side: " + side + ",               Area: "
                + String.Format("%.1f", Area()) + ", Perimeter: "
                + String.Format("%.1f", Perimeter());
    }
  }
}
