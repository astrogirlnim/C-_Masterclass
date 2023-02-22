using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Box
    {
        // member variable
        private int length = 3;
        //public int width;
        private int height;
        public int volume;

        /*Encapsulaion = building of data with methods that depend on that data
         * Restricting access to a variable except through methods 
         * Can define encapsulation according to access modifiers
         */

        // default property
        public int Width { get; set; }

        // Property
        public int Height 
        {
            // getter and setter
            get
            {
                return height;
            }
            set 
            {
                if (value < 0)
                {
                    height = -value;
                }
                else
                {
                    height = value;
                }
            }
        }

        // constructor
        public Box(int length, int height, int width) 
        {
            this.length = length;
            this.height = height;
            Width = width;
            this.volume = length * width * height;
        }

        // creating a setter to set the private length variable
        /* If this method is made private, only the class or classes
         * that inherit can access.
         */
        public void SetLength(int length) 
        {
            if(length < 0) 
            {
                throw new Exception("Length must be an positive integer value.");
            }
            this.length = length;
        }

        // a "getter" for the private length variable
        public int GetLength() 
        {
            return this.length;
        }

        // Restricting access to volume by not returning it directly.
        public int GetVolume() 
        {
            return this.length * this.Width * this.height;
        }

        // read-only property
        public int FrontSurface() 
        {
            return this.height * this.length;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Length is {0}, height is {1}, width is {2}, volume is {3}.",
                length, height, Width, volume = length * Width * height);
        }
    }
}
