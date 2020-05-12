using System;

namespace shape_sorter_cli
{
  class RegularOctagon : Shape
  {
    private readonly double side;

    public RegularOctagon(double side)
    {
      this.side = side;
    }

    public override sealed double Area()
    {
      return 2 * (1 + Math.Sqrt(2)) * side * side;
    }

    public override sealed double Perimeter()
    {
      return side * 8;
    }

    public override string ToString()
    {
      return "Regular Octagon -- Side: " + side + ",               Area: "
                + String.Format("%.1f", Area()) + ", Perimeter: "
                + String.Format("%.1f", Perimeter());
    }
  }
}
