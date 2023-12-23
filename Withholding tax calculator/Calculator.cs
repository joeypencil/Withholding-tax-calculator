namespace Withholding_tax_calculator
{
    public struct Result
    {
        public TaxPackage TaxPackage;
        public double TotalAnnualTax;
        public double TaxPerCutoff;

        public Result(TaxPackage taxPackage, double totalAnnualTax, double taxPerCutoff)
        {
            TaxPackage = taxPackage;
            TotalAnnualTax = totalAnnualTax;
            TaxPerCutoff = taxPerCutoff;
        }
    }

    public class Calculator
    {
        public Constants reference = new Constants();

        public Calculator() {}

        public TaxPackage GetMatchingTaxPackage(int basicPay)
        {
            int yearlyBasicPay = basicPay * ConstNums.CUTOFFS_IN_YEAR;

            foreach (TaxPackage package in reference.TaxPackages)
            {
                if (yearlyBasicPay > package.MinSalaryExclusive
                    && yearlyBasicPay <= package.MaxSalaryInclusive)
                    return package;
            }

            return new TaxPackage();
        }

        public Result ComputeTaxes(int basicPay)
        {
            TaxPackage taxPackage = GetMatchingTaxPackage(basicPay);
            int yearlyBasicPay = basicPay * ConstNums.CUTOFFS_IN_YEAR;

            double taxPerCutoff = (taxPackage.BaseTax / ConstNums.MONTHS) +
                ((taxPackage.ExcessPercentage * (yearlyBasicPay - taxPackage.MinSalaryExclusive)) / ConstNums.MONTHS);
            double totalAnnualTax = taxPerCutoff * ConstNums.CUTOFFS_IN_YEAR;

            return new Result(taxPackage, totalAnnualTax, taxPerCutoff);
        }
    }
}
