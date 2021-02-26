using System;

namespace Box
{
    public class Program
    {
        static void Main(string[] args)
        {


            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            try
            {
                var box = new Box(length, width, height);
                box.SurfaceArea();
                box.LateralSurfaceArea();
                box.Volume();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



        }
    }
}
