namespace Control_Flow__Conditional_Statements_and_Loops_HW.Items
{
    using System;
    using System.Collections.Generic;

    public class Bowl
    {
        public Bowl()
        {
            this.Ingredients = new List<Vegie>();
        }

        public List<Vegie> Ingredients { get; set; }

        public void Add(Vegie vegetable)
        {
            this.Ingredients.Add(vegetable);
        }

        public void Cook()
        {
            foreach (var vehgitable in this.Ingredients)
            {
                vehgitable.Cook();
            }
        }

    }

}
