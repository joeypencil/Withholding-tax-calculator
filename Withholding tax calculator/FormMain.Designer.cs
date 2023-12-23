namespace Withholding_tax_calculator
{
    partial class formMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelBasicPay = new System.Windows.Forms.Label();
            this.textBasicPay = new System.Windows.Forms.TextBox();
            this.buttonComputeTax = new System.Windows.Forms.Button();
            this.labelRange = new System.Windows.Forms.Label();
            this.textRange = new System.Windows.Forms.TextBox();
            this.labelBaseTax = new System.Windows.Forms.Label();
            this.textBaseTax = new System.Windows.Forms.TextBox();
            this.labelExcessPercentage = new System.Windows.Forms.Label();
            this.textExcessPercentage = new System.Windows.Forms.TextBox();
            this.labelTotalAnnualTax = new System.Windows.Forms.Label();
            this.textTotalAnnualTax = new System.Windows.Forms.TextBox();
            this.labelTaxPerCutoff = new System.Windows.Forms.Label();
            this.textTaxPerCutoff = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelBasicPay
            // 
            this.labelBasicPay.AutoSize = true;
            this.labelBasicPay.Location = new System.Drawing.Point(24, 19);
            this.labelBasicPay.Name = "labelBasicPay";
            this.labelBasicPay.Size = new System.Drawing.Size(56, 13);
            this.labelBasicPay.TabIndex = 0;
            this.labelBasicPay.Text = "Basic pay:";
            // 
            // textBasicPay
            // 
            this.textBasicPay.Location = new System.Drawing.Point(86, 16);
            this.textBasicPay.Name = "textBasicPay";
            this.textBasicPay.Size = new System.Drawing.Size(257, 20);
            this.textBasicPay.TabIndex = 1;
            // 
            // buttonComputeTax
            // 
            this.buttonComputeTax.Location = new System.Drawing.Point(349, 16);
            this.buttonComputeTax.Name = "buttonComputeTax";
            this.buttonComputeTax.Size = new System.Drawing.Size(82, 22);
            this.buttonComputeTax.TabIndex = 2;
            this.buttonComputeTax.Text = "Compute tax";
            this.buttonComputeTax.UseVisualStyleBackColor = true;
            this.buttonComputeTax.Click += new System.EventHandler(this.buttonComputeTax_Click);
            // 
            // labelRange
            // 
            this.labelRange.AutoSize = true;
            this.labelRange.Location = new System.Drawing.Point(24, 62);
            this.labelRange.Name = "labelRange";
            this.labelRange.Size = new System.Drawing.Size(169, 13);
            this.labelRange.TabIndex = 3;
            this.labelRange.Text = "Range of Annual Taxable Income:";
            // 
            // textRange
            // 
            this.textRange.Location = new System.Drawing.Point(199, 59);
            this.textRange.Name = "textRange";
            this.textRange.ReadOnly = true;
            this.textRange.Size = new System.Drawing.Size(144, 20);
            this.textRange.TabIndex = 4;
            // 
            // labelBaseTax
            // 
            this.labelBaseTax.AutoSize = true;
            this.labelBaseTax.Location = new System.Drawing.Point(24, 95);
            this.labelBaseTax.Name = "labelBaseTax";
            this.labelBaseTax.Size = new System.Drawing.Size(55, 13);
            this.labelBaseTax.TabIndex = 5;
            this.labelBaseTax.Text = "Base Tax:";
            // 
            // textBaseTax
            // 
            this.textBaseTax.Location = new System.Drawing.Point(199, 92);
            this.textBaseTax.Name = "textBaseTax";
            this.textBaseTax.ReadOnly = true;
            this.textBaseTax.Size = new System.Drawing.Size(144, 20);
            this.textBaseTax.TabIndex = 6;
            // 
            // labelExcessPercentage
            // 
            this.labelExcessPercentage.AutoSize = true;
            this.labelExcessPercentage.Location = new System.Drawing.Point(24, 128);
            this.labelExcessPercentage.Name = "labelExcessPercentage";
            this.labelExcessPercentage.Size = new System.Drawing.Size(102, 13);
            this.labelExcessPercentage.TabIndex = 9;
            this.labelExcessPercentage.Text = "Excess Percentage:";
            // 
            // textExcessPercentage
            // 
            this.textExcessPercentage.Location = new System.Drawing.Point(199, 125);
            this.textExcessPercentage.Name = "textExcessPercentage";
            this.textExcessPercentage.ReadOnly = true;
            this.textExcessPercentage.Size = new System.Drawing.Size(144, 20);
            this.textExcessPercentage.TabIndex = 10;
            // 
            // labelTotalAnnualTax
            // 
            this.labelTotalAnnualTax.AutoSize = true;
            this.labelTotalAnnualTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalAnnualTax.Location = new System.Drawing.Point(24, 211);
            this.labelTotalAnnualTax.Name = "labelTotalAnnualTax";
            this.labelTotalAnnualTax.Size = new System.Drawing.Size(133, 13);
            this.labelTotalAnnualTax.TabIndex = 11;
            this.labelTotalAnnualTax.Text = "TOTAL ANNUAL TAX:";
            // 
            // textTotalAnnualTax
            // 
            this.textTotalAnnualTax.Location = new System.Drawing.Point(199, 208);
            this.textTotalAnnualTax.Name = "textTotalAnnualTax";
            this.textTotalAnnualTax.ReadOnly = true;
            this.textTotalAnnualTax.Size = new System.Drawing.Size(144, 20);
            this.textTotalAnnualTax.TabIndex = 12;
            // 
            // labelTaxPerCutoff
            // 
            this.labelTaxPerCutoff.AutoSize = true;
            this.labelTaxPerCutoff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTaxPerCutoff.Location = new System.Drawing.Point(24, 245);
            this.labelTaxPerCutoff.Name = "labelTaxPerCutoff";
            this.labelTaxPerCutoff.Size = new System.Drawing.Size(116, 13);
            this.labelTaxPerCutoff.TabIndex = 13;
            this.labelTaxPerCutoff.Text = "TAX PER CUTOFF:";
            // 
            // textTaxPerCutoff
            // 
            this.textTaxPerCutoff.Location = new System.Drawing.Point(199, 242);
            this.textTaxPerCutoff.Name = "textTaxPerCutoff";
            this.textTaxPerCutoff.ReadOnly = true;
            this.textTaxPerCutoff.Size = new System.Drawing.Size(144, 20);
            this.textTaxPerCutoff.TabIndex = 14;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 287);
            this.Controls.Add(this.textTaxPerCutoff);
            this.Controls.Add(this.labelTaxPerCutoff);
            this.Controls.Add(this.textTotalAnnualTax);
            this.Controls.Add(this.labelTotalAnnualTax);
            this.Controls.Add(this.textExcessPercentage);
            this.Controls.Add(this.labelExcessPercentage);
            this.Controls.Add(this.textBaseTax);
            this.Controls.Add(this.labelBaseTax);
            this.Controls.Add(this.textRange);
            this.Controls.Add(this.labelRange);
            this.Controls.Add(this.buttonComputeTax);
            this.Controls.Add(this.textBasicPay);
            this.Controls.Add(this.labelBasicPay);
            this.Name = "formMain";
            this.Text = "Withholding tax calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBasicPay;
        private System.Windows.Forms.TextBox textBasicPay;
        private System.Windows.Forms.Button buttonComputeTax;
        private System.Windows.Forms.Label labelRange;
        private System.Windows.Forms.TextBox textRange;
        private System.Windows.Forms.Label labelBaseTax;
        private System.Windows.Forms.TextBox textBaseTax;
        private System.Windows.Forms.Label labelExcessPercentage;
        private System.Windows.Forms.TextBox textExcessPercentage;
        private System.Windows.Forms.Label labelTotalAnnualTax;
        private System.Windows.Forms.TextBox textTotalAnnualTax;
        private System.Windows.Forms.Label labelTaxPerCutoff;
        private System.Windows.Forms.TextBox textTaxPerCutoff;
    }
}

