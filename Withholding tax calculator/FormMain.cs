using System;
using System.Windows.Forms;

namespace Withholding_tax_calculator
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void buttonComputeTax_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            Result result = calculator.ComputeTaxes(Int32.Parse(textBasicPay.Text));
            
            textRange.Text = String.Format("{0} - {1}",
                result.TaxPackage.MinSalaryExclusive, result.TaxPackage.MaxSalaryInclusive);
            textBaseTax.Text = result.TaxPackage.BaseTax.ToString();
            textExcessPercentage.Text = result.TaxPackage.ExcessPercentage.ToString();
            textTotalAnnualTax.Text = result.TotalAnnualTax.ToString("F2");
            textTaxPerCutoff.Text = result.TaxPerCutoff.ToString("F2");
        }
    }
}
