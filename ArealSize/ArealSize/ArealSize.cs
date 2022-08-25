using System.Globalization;

namespace ArealSize
{
    public class ArealSize
    {

        private double _area; 
        private  string? input;
        private  List<double>? dataDoubles;
        private  Circle ? circle;
        public void Area()
        {
            Console.WriteLine("Enter the parameters via ; as 4;6;7");
            Console.WriteLine("* one number will be considered the radius of a circle");
            Console.WriteLine("* three numbers will be considered the sides of a triangle");
            Console.WriteLine("* an even number greater than or equal to eight will be considered an arbitrary figure with the X Y coordinates of each vertex");
            input = ConsoleInput();
            if (input != null) Input(input);
        }

        public virtual string? ConsoleInput()
        {
            return Console.ReadLine();
        }

        private void Input(string? testInput)
        {
            input = testInput;
            dataDoubles = GetParam(input);
            ParamValidation();
        }

        private List<double>? GetParam(string? input)
        {
            List<double>? tempDoubles = new List<double>();
            string[] words = input.Split(';');
            foreach (var word in words)
            {
                tempDoubles.Add(Double.Parse(word));
            }

            return tempDoubles;
        }
        private void PrintArea(double inputArea)
        {
            inputArea = Math.Round(inputArea, 2);
            Console.WriteLine(" Area is "+inputArea.ToString(CultureInfo.InvariantCulture));
        }

        private void ParamValidation()
        {
            if (dataDoubles != null)
            {
                int paramCount = dataDoubles.Count;
                if (paramCount > 0)
                {
                    if (paramCount == 1)
                    {
                        Circle circle = new Circle(dataDoubles[0]);
                        _area = circle.Area();
                        PrintArea(_area);
                    }
                    if (paramCount == 3)
                    {
                        _area = new Triangle(dataDoubles[0], dataDoubles[1], dataDoubles[2]).Area();
                        PrintArea(_area);
                    }
                    if (paramCount >= 8 && paramCount%2 == 0)
                    {
                        CalculationAlgorithm calculation = new CalculationAlgorithm(dataDoubles);
                        if (circle != null) _area = calculation.AreaCalculation();
                        PrintArea(_area);
                    }
                }
                else
                {
                    Console.WriteLine("There are no parameters to calculate");
                }
            }
        }
    }
   
}