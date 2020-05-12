using System;
using System.Collections.Generic;

namespace shape_sorter_cli
{
  class ReverseComparer<T> : IComparer<T>
  {
    private IComparer<T> comparer;

    public ReverseComparer(IComparer<T> comparer)
    {
      this.comparer = comparer;
    }

    public int Compare(T lhs, T rhs)
    {
      return -(comparer.Compare(lhs, rhs));
    }
  }
}
