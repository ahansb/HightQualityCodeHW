namespace Control_Flow__Conditional_Statements_and_Loops_HW
{
    using System;
    using Items;

    public class Chef
    {
        public Bowl Cook()
        {
            Potatoe potato = this.GetPotato();
            this.Peel(potato);
            this.Cut(potato);

            Carrot carrot = this.GetCarrot();
            this.Peel(carrot);
            this.Cut(carrot);

            Bowl bowl = this.GetBowl();
            bowl.Add(potato);
            bowl.Add(carrot);

            return bowl;
        }

        private Bowl GetBowl()
        {
            return new Bowl();
        }

        private Carrot GetCarrot()
        {
            return new Carrot();
        }

        private Potatoe GetPotato()
        {
            return new Potatoe();
        }

        private void Cut(Vegie vegetable)
        {
            vegetable.Cut();
        }

        private void Peel(Vegie vegetable)
        {
            vegetable.Peel();
        }
    }
}
