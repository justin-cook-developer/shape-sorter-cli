using System;

namespace shape_sorter_cli
{
  public abstract class Shape : IComparable<Shape>
  {
    public abstract double Area();
    public abstract double Perimeter();

    public int CompareTo(Shape rhs)
    {
      double diff = Area() - rhs.Area();

      if (diff == 0)
        return 0;
      else if (diff < 0)
        return -1;
      else
        return 1;
    }

    public override bool Equals(object obj)
    {
      if (obj is Shape otherShape)
        return CompareTo(otherShape) == 0;
      else
        return false;
    }

    public double Semiperimeter()
    {
      return Perimeter() / 2;
    }
  }
}
