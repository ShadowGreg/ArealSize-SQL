namespace ArealSize
{
    public static class ArealSize
    {
        
        private static double _area = 0;
        private static string? input;
        private static List<double>? dataDoubles;
        private static Circle ? circle;
        public static void Area()
        {
            Console.WriteLine("Enter the parameters via ; as 4;6;7");
            Console.WriteLine("* one number will be considered the radius of a circle");
            Console.WriteLine("* three numbers will be considered the sides of a triangle");
            Console.WriteLine("* an even number greater than or equal to eight will be considered an arbitrary figure with the X Y coordinates of each vertex");
            input= Console.ReadLine();
            if (input != null) dataDoubles = GetParam(input);
            ParamValidation();
        }
        
        public static void testInput(string testInput)
        {
            input = testInput;
            dataDoubles = GetParam(input);
            ParamValidation();
        }

        private static List<double>? GetParam(string input)
        {
            List<double>? tempDoubles = new List<double>();
            string[] words = input.Split(';');
            foreach (var word in words)
            {
                tempDoubles.Add(Double.Parse(word));
            }

            return tempDoubles;
        }

        private static void ParamValidation()
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
                    }
                    if (paramCount == 3)
                    {
                        Triangle triangle = new Triangle(dataDoubles[0], dataDoubles[1], dataDoubles[2]);
                        if (circle != null) _area = circle.Area();
                    }
                    if (paramCount >= 8 && paramCount%2 == 0)
                    {
                        CalculationAlgorithm triangle = new CalculationAlgorithm(dataDoubles);
                        if (circle != null) _area = circle.Area();
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