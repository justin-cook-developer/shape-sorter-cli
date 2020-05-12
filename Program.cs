using System;
using System.Collections.Generic;

namespace shape_sorter_cli
{
  class Program
  {
    private static IComparer<Shape> areaAscending = new AreaAscending();
    private static IComparer<Shape> perimeterAscending = new PerimeterAscending();
    private static IComparer<Shape> areaDescending = new ReverseComparer<Shape>(areaAscending);
    private static IComparer<Shape> perimeterDescending = new ReverseComparer<Shape>(perimeterAscending);

    private static string[] VALID_SHAPE_INPUTS = new string[] { "C", "H", "O", "Q", "R", "S" };
    private static string[] VALID_MAIN_MENU_INPUTS = new string[] { "Q", "R", "S" };
    private static string[] VALID_REPORT_MENU_INPUTS = new string[] { "Q", "SA", "SGA", "SGP", "SP" };
    private static string[] VALID_ORDERING_MENU_INPUTS = new string[] { "A", "D" };


    // private static IComparer<Shape> AreaAscending =
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }
  }
}
