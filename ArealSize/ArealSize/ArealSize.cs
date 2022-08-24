namespace ArealSize
{
    public static class ArealSize
    {
        private static double _area = 0;
        private static string? input;
        private static List<double> dataDoubles;
        public static void Area()
        {
            Console.WriteLine("Enter the parameters via ; as 4;6;7");
            Console.WriteLine("* one number will be considered the radius of a circle");
            Console.WriteLine("* three numbers will be considered the sides of a triangle");
            Console.WriteLine("* an even number greater than or equal to six will be considered an arbitrary figure with the X H coordinates of each vertex");
            input= Console.ReadLine();
            

        }
        
        public static void testInput(string testInput)
        {
            input = testInput;
        }

        private List<double> GetParam(string input)
        {
            string[] words = input.Split(';');
            
        }
    }
}