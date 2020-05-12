using System;

namespace shape_sorter_cli
{
  class RegularHexagon : Shape
  {
    private readonly double side;

    public RegularHexagon(double side)
    {
      this.side = side;
    }

    public override sealed double Area()
    {
      return 3 / 2 * Math.Sqrt(3) * side * side;
    }

    public override sealed double Perimeter()
    {
      return side * 6;
    }

    public override string ToString()
    {
      return "Regular Hexagon -- Side: " + side + ",               Area: "
                + String.Format("%.1f", Area()) + ", Perimeter: "
                + String.Format("%.1f", Perimeter());
    }
  }
}
