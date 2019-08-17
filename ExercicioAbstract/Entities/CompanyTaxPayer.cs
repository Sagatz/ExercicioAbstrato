namespace ExercicioAbstract.Entities
{
    class CompanyTaxPayer : TaxPayer
    {
        public int EmployeeNumber { get; set; }

        public CompanyTaxPayer(string name, double anualIncome, int employeeNumber) : base(name, anualIncome)
        {
            EmployeeNumber = employeeNumber;
        }

        public override double Income()
        {
            double value = 0;
            if (EmployeeNumber <= 10)
            {
                value = AnualIncome * 0.16;
            }
            else
            {
                value = AnualIncome * 0.14;
            }
            return value;
        }

        public override string ToString()
        {
            return Name + ": $ " + Income().ToString("F2");
        }
    }
}
