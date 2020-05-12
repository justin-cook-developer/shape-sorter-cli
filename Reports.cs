using System.Collections.Generic;

namespace shape_sorter_cli
{
  public class Reports
  {
    public static void SortAndPrintShapes<T>(List<T> shapes, IComparer<Shape> comparer, string message) where T : Shape
    {
      Utils.Shellsort<T, Shape>(shapes, comparer);
      System.Console.WriteLine("\n" + message);
      Utils.PrintAll<T>(shapes);
    }

    public static void SortAndPrintShapesByType(List<Shape> shapes, IComparer<Shape> comparer, string ordering)
    {
      var circles = new List<Circle>();
      var rectangles = new List<Rectangle>();
      var squares = new List<Square>();
      var regularHexagons = new List<RegularHexagon>();
      var regularOctagons = new List<RegularOctagon>();

      foreach (Shape shape in shapes)
      {
        if (shape is Circle c)
          circles.Add(c);
        if (shape is Rectangle r)
          rectangles.Add(r);
        if (shape is Square s)
          squares.Add(s);
        if (shape is RegularHexagon rh)
          regularHexagons.Add(rh);
        if (shape is RegularOctagon ro)
          regularOctagons.Add(ro);
      }

      if (circles.Count > 0)
        SortAndPrintShapes(circles, comparer, "All circles, in order of " + ordering + ":");
      if (rectangles.Count > 0)
        SortAndPrintShapes(rectangles, comparer, "All rectangles, in order of " + ordering + ":");
      if (rectangles.Count > 0)
        SortAndPrintShapes(squares, comparer, "All squares, in order of " + ordering + ":");
      if (regularHexagons.Count > 0)
        SortAndPrintShapes(regularHexagons, comparer, "All regular hexagons, in order of " + ordering + ":");
      if (regularOctagons.Count > 0)
        SortAndPrintShapes(regularOctagons, comparer, "All regular octagons, in order of " + ordering + ":");
    }
  }
}
