namespace ExPolimorfismo.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee()
        {

        }
        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalcharge)
            : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalcharge;
        }

        public override double Payment()     // "override" é colocado para poder sobrescrever o método da superclasse
        {
            return base.Payment()+ 1.1 * AdditionalCharge;
        }

    }
}