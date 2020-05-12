using System;
using System.Collections.Generic;

namespace shape_sorter_cli
{
  class AreaAscending : IComparer<Shape>
  {
    public int Compare(Shape lhs, Shape rhs)
    {
      double diff = lhs.Area() - rhs.Area();

      if (diff == 0)
        return 0;
      else if (diff < 0)
        return -1;
      else
        return 1;
    }
  }
}
