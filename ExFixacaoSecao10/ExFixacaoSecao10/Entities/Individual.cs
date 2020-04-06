using System;
using System.Collections.Generic;
using System.Text;

namespace ExFixacaoSecao10.Entities
{
    class Individual : TaxPayer
    {
        #region Parameters
        public double HeathExpenditures { get; set; }
        public int CUTVALUE = 20000; // Reference value of anual income for taxes
        private double HIGHTAX = 0.25; // Max value, to be payed in taxes
        private double LOWTAX = 0.15; // Min value, to be payed in taxes
        private double HEATHBONUS = 0.5; // Bonification over the total taxes;



        #endregion

        #region Constructors
        public Individual()
        {
        }

        public Individual(string name, double anualIncome, double heathExpenditures)
            : base(name, anualIncome)
        {
            HeathExpenditures = heathExpenditures;
        }

        #endregion

        #region Methods
        public override double TaxesToPay()
        {

            if (AnualIncome > CUTVALUE)
                return AnualIncome * HIGHTAX + HeathExpenditures * HEATHBONUS;
            else
                return AnualIncome * LOWTAX + HeathExpenditures * HEATHBONUS;
          
        }

        #endregion
    }
}
