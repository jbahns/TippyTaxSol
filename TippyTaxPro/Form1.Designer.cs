
namespace TippyTaxPro
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labSubtotal = new System.Windows.Forms.Label();
            this.labTipRate = new System.Windows.Forms.Label();
            this.labTipAmt = new System.Windows.Forms.Label();
            this.labTaxRate = new System.Windows.Forms.Label();
            this.labTaxAmt = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtTipAmt = new System.Windows.Forms.TextBox();
            this.txtTaxAmt = new System.Windows.Forms.TextBox();
            this.labTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.comboTipRate = new System.Windows.Forms.ComboBox();
            this.txtTaxRate = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labSubtotal
            // 
            this.labSubtotal.AutoSize = true;
            this.labSubtotal.Location = new System.Drawing.Point(122, 67);
            this.labSubtotal.Name = "labSubtotal";
            this.labSubtotal.Size = new System.Drawing.Size(79, 25);
            this.labSubtotal.TabIndex = 0;
            this.labSubtotal.Text = "&Subtotal";
            // 
            // labTipRate
            // 
            this.labTipRate.AutoSize = true;
            this.labTipRate.Location = new System.Drawing.Point(122, 114);
            this.labTipRate.Name = "labTipRate";
            this.labTipRate.Size = new System.Drawing.Size(76, 25);
            this.labTipRate.TabIndex = 1;
            this.labTipRate.Text = "Tip Rate";
            // 
            // labTipAmt
            // 
            this.labTipAmt.AutoSize = true;
            this.labTipAmt.Location = new System.Drawing.Point(119, 161);
            this.labTipAmt.Name = "labTipAmt";
            this.labTipAmt.Size = new System.Drawing.Size(106, 25);
            this.labTipAmt.TabIndex = 2;
            this.labTipAmt.Text = "Tip Amount";
            // 
            // labTaxRate
            // 
            this.labTaxRate.AutoSize = true;
            this.labTaxRate.Location = new System.Drawing.Point(118, 208);
            this.labTaxRate.Name = "labTaxRate";
            this.labTaxRate.Size = new System.Drawing.Size(76, 25);
            this.labTaxRate.TabIndex = 3;
            this.labTaxRate.Text = "Tax Rate";
            // 
            // labTaxAmt
            // 
            this.labTaxAmt.AutoSize = true;
            this.labTaxAmt.Location = new System.Drawing.Point(115, 257);
            this.labTaxAmt.Name = "labTaxAmt";
            this.labTaxAmt.Size = new System.Drawing.Size(106, 25);
            this.labTaxAmt.TabIndex = 4;
            this.labTaxAmt.Text = "Tax Amount";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(262, 64);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(101, 31);
            this.txtSubtotal.TabIndex = 5;
            // 
            // txtTipAmt
            // 
            this.txtTipAmt.Location = new System.Drawing.Point(262, 161);
            this.txtTipAmt.Name = "txtTipAmt";
            this.txtTipAmt.ReadOnly = true;
            this.txtTipAmt.Size = new System.Drawing.Size(101, 31);
            this.txtTipAmt.TabIndex = 7;
            // 
            // txtTaxAmt
            // 
            this.txtTaxAmt.Location = new System.Drawing.Point(262, 254);
            this.txtTaxAmt.Name = "txtTaxAmt";
            this.txtTaxAmt.ReadOnly = true;
            this.txtTaxAmt.Size = new System.Drawing.Size(101, 31);
            this.txtTaxAmt.TabIndex = 9;
            // 
            // labTotal
            // 
            this.labTotal.AutoSize = true;
            this.labTotal.Location = new System.Drawing.Point(123, 305);
            this.labTotal.Name = "labTotal";
            this.labTotal.Size = new System.Drawing.Size(49, 25);
            this.labTotal.TabIndex = 10;
            this.labTotal.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(262, 299);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(99, 31);
            this.txtTotal.TabIndex = 11;
            // 
            // comboTipRate
            // 
            this.comboTipRate.FormattingEnabled = true;
            this.comboTipRate.Items.AddRange(new object[] {
            "15",
            "20",
            "25"});
            this.comboTipRate.Location = new System.Drawing.Point(262, 111);
            this.comboTipRate.Name = "comboTipRate";
            this.comboTipRate.Size = new System.Drawing.Size(97, 33);
            this.comboTipRate.TabIndex = 12;
            // 
            // txtTaxRate
            // 
            this.txtTaxRate.Location = new System.Drawing.Point(262, 205);
            this.txtTaxRate.Name = "txtTaxRate";
            this.txtTaxRate.ReadOnly = true;
            this.txtTaxRate.Size = new System.Drawing.Size(99, 31);
            this.txtTaxRate.TabIndex = 13;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(80, 376);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(120, 41);
            this.btnCalc.TabIndex = 14;
            this.btnCalc.Text = "&Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(256, 377);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(153, 39);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCalc;
            this.ClientSize = new System.Drawing.Size(446, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtTaxRate);
            this.Controls.Add(this.comboTipRate);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.labTotal);
            this.Controls.Add(this.txtTaxAmt);
            this.Controls.Add(this.txtTipAmt);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.labTaxAmt);
            this.Controls.Add(this.labTaxRate);
            this.Controls.Add(this.labTipAmt);
            this.Controls.Add(this.labTipRate);
            this.Controls.Add(this.labSubtotal);
            this.Name = "Form1";
            this.Text = "Tip and Tax Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labSubtotal;
        private System.Windows.Forms.Label labTipRate;
        private System.Windows.Forms.Label labTipAmt;
        private System.Windows.Forms.Label labTaxRate;
        private System.Windows.Forms.Label labTaxAmt;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtTipAmt;
        private System.Windows.Forms.TextBox txtTaxAmt;
        private System.Windows.Forms.Label labTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.ComboBox comboTipRate;
        private System.Windows.Forms.TextBox txtTaxRate;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnExit;
    }
}

