using ArealSize.Abstractions;

namespace ArealSize.Tests {
    public class TestFigure(double area): IFigure {
        public double GetArea() {
            return area;
        }
    }
}