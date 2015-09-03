namespace Control_Flow__Conditional_Statements_and_Loops_HW.Items
{
    using System;

    public abstract class Vegie
    {
        //initialize vegie type
         public Vegie()
        {
            this.IsRotten = false;
            this.IsPeeled = false;
            this.IsCut = false;
            this.IsCooked = false;
        }

        public bool IsRotten { get; set; }

        public bool IsPeeled { get; set; }

        public bool IsCut { get; set; }

        public bool IsCooked { get; set; }

        public void Cut()
        {
            this.IsCut = true;
        }

        public void Peel()
        {
            this.IsPeeled = true;
        }

        public void Cook()
        {
            this.IsCooked = true;
        }
    }
}
