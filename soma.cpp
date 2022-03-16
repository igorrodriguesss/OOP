static void Main(string[] args)
        {
            double p1, p2, media;
            Console.WriteLine("Digite a 1a nota: ");
            p1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a 2a nota: ");
            p2 = double.Parse(Console.ReadLine());
            media = CalcularMedia(p1, p2);
            Console.WriteLine(media);
        }
        static double CalcularMedia (double x, double y)
        {
            return (x + y) / 2;
        }
