using System.Collections.Generic;

namespace shape_sorter_cli
{
  class Utils
  {
    public static void Shellsort<T, U>(List<T> list, IComparer<U> comparer) where T : U
    {
      for (int gap = list.Count / 2; gap > 0; gap = gap == 2 ? 1 : (int)(gap / 2.2))
        for (int i = gap; i < list.Count; i++)
        {
          T tmp = list[i];
          int j = i;

          for (; j >= gap && comparer.Compare(tmp, list[j - gap]) < 0; j -= gap)
            list[j] = list[j - gap];

          list[j] = tmp;
        }
    }

    public static void PrintAll<T>(ICollection<T> collection)
    {
      foreach (T elem in collection)
        System.Console.WriteLine(elem);
    }
  }
}
