namespace AbstractMethosExec.Entities
{
    class Company : TaxPayer
    {
        public int Employees { get; set; }

        public Company(string name, double annualIncome, int employees) : base(name, annualIncome)
        {
            Employees = employees;
        }

        public override double Tax()
        {
            if (Employees > 0)
            {
                return AnnualIncome * 0.14;
            }
            else
            {
                return AnnualIncome * 0.16;
            }
        }
    }
}
