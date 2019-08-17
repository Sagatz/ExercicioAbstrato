namespace ExercicioAbstract.Entities
{
    class IndividualTaxPayer : TaxPayer
    {
        public double HealthSpend { get; set; }

        public IndividualTaxPayer(string name, double anualIncome, double healthSpend) : base(name, anualIncome)
        {
            HealthSpend = healthSpend;
        }

        public override double Income()
        {
            double value = 0.0;
            if (AnualIncome < 20000.0)
            {
                value = AnualIncome * 0.15 - HealthSpend * 0.5;
            }
            else if (AnualIncome >= 20000.0)
            {
                value = AnualIncome * 0.25 - HealthSpend * 0.5;
            }
            return value;
        }

        public override string ToString()
        {
            return Name + ": $ " + Income().ToString("F2");
        }
    }
}
