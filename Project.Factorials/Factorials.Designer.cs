namespace Factorials
{
    partial class frmFactorialCalculator
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
            this.NumberLabel = new System.Windows.Forms.Label();
            this.FactorialLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.NumberTextBox = new System.Windows.Forms.TextBox();
            this.FactorialTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Location = new System.Drawing.Point(33, 52);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(44, 13);
            this.NumberLabel.TabIndex = 0;
            this.NumberLabel.Text = "Number";
            // 
            // FactorialLabel
            // 
            this.FactorialLabel.AutoSize = true;
            this.FactorialLabel.Location = new System.Drawing.Point(33, 93);
            this.FactorialLabel.Name = "FactorialLabel";
            this.FactorialLabel.Size = new System.Drawing.Size(47, 13);
            this.FactorialLabel.TabIndex = 1;
            this.FactorialLabel.Text = "Factorial";
            this.FactorialLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(36, 144);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 2;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.Location = new System.Drawing.Point(152, 144);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.Location = new System.Drawing.Point(152, 44);
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.NumberTextBox.TabIndex = 4;
            // 
            // FactorialTextBox
            // 
            this.FactorialTextBox.Location = new System.Drawing.Point(152, 86);
            this.FactorialTextBox.Name = "FactorialTextBox";
            this.FactorialTextBox.ReadOnly = true;
            this.FactorialTextBox.Size = new System.Drawing.Size(100, 20);
            this.FactorialTextBox.TabIndex = 5;
            // 
            // frmFactorialCalculator
            // 
            this.AcceptButton = this.CalculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ExitButton;
            this.ClientSize = new System.Drawing.Size(284, 194);
            this.Controls.Add(this.FactorialTextBox);
            this.Controls.Add(this.NumberTextBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.FactorialLabel);
            this.Controls.Add(this.NumberLabel);
            this.Name = "frmFactorialCalculator";
            this.Text = "Factorial Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NumberLabel;
        private System.Windows.Forms.Label FactorialLabel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TextBox NumberTextBox;
        private System.Windows.Forms.TextBox FactorialTextBox;
    }
}

