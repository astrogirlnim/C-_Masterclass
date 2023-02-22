using System;

namespace Properties
{
    class Program 
    {
        static void Main(string[] args) 
        {
            Box box = new Box(3,4,5);
            
            box.DisplayInfo();
            Console.WriteLine("Front Surface is + "box.FrontSurface());
            Console.WriteLine("Box length is " + box.GetLength());
            Console.WriteLine("Box volume is " + box.GetVolume());
            Console.WriteLine("Box width is " +  box.Width);
        }
    }
}
