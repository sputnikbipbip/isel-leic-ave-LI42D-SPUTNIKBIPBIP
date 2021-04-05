public class Point{


    [ToLogAttribute("(field) x")] public readonly int x;
    [ToLogAttribute("(field) y")] public readonly int y;
    public Point(int x, int y) {
        this.x = x;
        this.y = y;
    }
    public double GetModule() {
            return System.Math.Sqrt(x*x + y*y);
    }

    [ToLogAttribute("(method) Point Add")]
     public Point Add(Point other) {
            return new Point(x + other.x, y + other.y);
    }
    
}
