namespace Variables__Data__Expressions_and_Constants__HW
{
    using System;

    public class Shape
    {
        private double width;
        private double height;

        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Width should not be" + " negative");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Height should not" + " be negative");
                }

                this.height = value;
            }
        }

        /// <summary>
        /// The method calculates the new size after of rotation by N degrees
        /// </summary>
        /// <param name="angleOfRotation">The degrees of rotation</param>
        /// <returns>new object of type Size</returns>
        public Shape GetRotatedSize(double angleOfRotation)
        {
            double width = GetSinAndCosOfDimensions(angleOfRotation, this.Width, this.Height);
            double height = GetSinAndCosOfDimensions(angleOfRotation, this.Height, this.Width);

            Shape sizeAfterRotation = new Shape(width, height);

            return sizeAfterRotation;
        }

        private double GetSinAndCosOfDimensions(double angle, double dimWithCos, double dimWithSin)
        {
            double dimensionWithCos = Math.Abs(Math.Cos(angle)) * dimWithCos;
            double dimensionWithSin = Math.Abs(Math.Sin(angle)) * dimWithSin;

            var result = dimensionWithCos + dimensionWithSin;

            return result;
        }
        
    }
}
