namespace Week2Assignment2
{
    partial class Form1
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
            this.txtNumOne = new System.Windows.Forms.TextBox();
            this.lblMultiply = new System.Windows.Forms.Label();
            this.txtNumTwo = new System.Windows.Forms.TextBox();
            this.lstProduct = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstNumOne = new System.Windows.Forms.ListBox();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lstNumTwo = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtNumOne
            // 
            this.txtNumOne.Location = new System.Drawing.Point(12, 21);
            this.txtNumOne.Name = "txtNumOne";
            this.txtNumOne.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNumOne.Size = new System.Drawing.Size(71, 20);
            this.txtNumOne.TabIndex = 0;
            this.txtNumOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblMultiply
            // 
            this.lblMultiply.AutoSize = true;
            this.lblMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMultiply.Location = new System.Drawing.Point(89, 23);
            this.lblMultiply.Name = "lblMultiply";
            this.lblMultiply.Size = new System.Drawing.Size(15, 18);
            this.lblMultiply.TabIndex = 1;
            this.lblMultiply.Text = "*";
            // 
            // txtNumTwo
            // 
            this.txtNumTwo.Location = new System.Drawing.Point(110, 21);
            this.txtNumTwo.Name = "txtNumTwo";
            this.txtNumTwo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNumTwo.Size = new System.Drawing.Size(71, 20);
            this.txtNumTwo.TabIndex = 2;
            this.txtNumTwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lstProduct
            // 
            this.lstProduct.FormattingEnabled = true;
            this.lstProduct.Location = new System.Drawing.Point(214, 51);
            this.lstProduct.Name = "lstProduct";
            this.lstProduct.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lstProduct.Size = new System.Drawing.Size(76, 212);
            this.lstProduct.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "=";
            // 
            // lstNumOne
            // 
            this.lstNumOne.FormattingEnabled = true;
            this.lstNumOne.Location = new System.Drawing.Point(13, 51);
            this.lstNumOne.Name = "lstNumOne";
            this.lstNumOne.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lstNumOne.Size = new System.Drawing.Size(70, 212);
            this.lstNumOne.TabIndex = 5;
            // 
            // btnMultiply
            // 
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.Location = new System.Drawing.Point(296, 9);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(75, 32);
            this.btnMultiply.TabIndex = 6;
            this.btnMultiply.Text = "Multiply";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(296, 51);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 32);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lstNumTwo
            // 
            this.lstNumTwo.FormattingEnabled = true;
            this.lstNumTwo.Location = new System.Drawing.Point(111, 51);
            this.lstNumTwo.Name = "lstNumTwo";
            this.lstNumTwo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lstNumTwo.Size = new System.Drawing.Size(70, 212);
            this.lstNumTwo.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 278);
            this.Controls.Add(this.lstNumTwo);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.lstNumOne);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstProduct);
            this.Controls.Add(this.txtNumTwo);
            this.Controls.Add(this.lblMultiply);
            this.Controls.Add(this.txtNumOne);
            this.Name = "Form1";
            this.Text = "Exercise 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumOne;
        private System.Windows.Forms.Label lblMultiply;
        private System.Windows.Forms.TextBox txtNumTwo;
        private System.Windows.Forms.ListBox lstProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstNumOne;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox lstNumTwo;
    }
}

