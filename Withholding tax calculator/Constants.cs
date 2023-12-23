using System.Collections.Generic;

namespace Withholding_tax_calculator
{
    public struct TaxPackage
    {
        public int MinSalaryExclusive;
        public int MaxSalaryInclusive;
        public int BaseTax;
        public double ExcessPercentage;

        public TaxPackage(int minSalaryExclusive, int maxSalaryInclusive,
            int baseTax, double excessPercentage)
        {
            MinSalaryExclusive = minSalaryExclusive;
            MaxSalaryInclusive = maxSalaryInclusive;
            BaseTax = baseTax;
            ExcessPercentage = excessPercentage;
        }
    };

    public class Constants
    {
        public List<TaxPackage> TaxPackages = new List<TaxPackage>();

        public Constants()
        {
            TaxPackages.Add(new TaxPackage(0, 250_000, 0, 0));
            TaxPackages.Add(new TaxPackage(250_000, 400_000, 0, 0.15));
            TaxPackages.Add(new TaxPackage(400_000, 800_000, 22_500, 0.2));
            TaxPackages.Add(new TaxPackage(800_000, 2_000_000, 102_500, 0.25));
            TaxPackages.Add(new TaxPackage(2_000_000, 8_000_000, 402_500, 0.3));
            TaxPackages.Add(new TaxPackage(8_000_000, 2_000_000_000, 2_202_500, 0.35));
        }
    }

    static class ConstNums
    {
        public const int CUTOFFS_IN_YEAR = 24;
        public const int MONTHS = 12;
    }
}
