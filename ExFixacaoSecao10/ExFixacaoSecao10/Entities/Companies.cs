

namespace ExFixacaoSecao10.Entities
{
    class Companies: TaxPayer
    {
        #region Parameters
        public int Employees { get; set; }
        public int EMPLOYEECUT = 10; // Reference of employees for taxes values
        private double HIGHTAX = 0.16; // Min value, to be payed in taxes
        private double LOWTAX = 0.14;// Max value, to be payed in taxes


        #endregion

        #region Constructors
        public Companies()
        {
        }

        public Companies(string name, double anualIncome, int employees)
            : base(name, anualIncome)
        {
            Employees = employees;
        }

        #endregion

        #region Methods
        public override double TaxesToPay()
        {

            if (Employees > EMPLOYEECUT)
                return AnualIncome * LOWTAX;
            else
                return AnualIncome * HIGHTAX;

        }

        #endregion
    }
}
