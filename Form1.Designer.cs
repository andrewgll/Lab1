
namespace lab1_true
{
    partial class Lab1Form
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
            this.NumbersCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonOkay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumbersCountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // NumbersCountNumericUpDown
            // 
            this.NumbersCountNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumbersCountNumericUpDown.Location = new System.Drawing.Point(7, 79);
            this.NumbersCountNumericUpDown.Name = "NumbersCountNumericUpDown";
            this.NumbersCountNumericUpDown.ReadOnly = true;
            this.NumbersCountNumericUpDown.Size = new System.Drawing.Size(922, 62);
            this.NumbersCountNumericUpDown.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(523, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose numbers count";
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultTextBox.Location = new System.Drawing.Point(7, 337);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.Size = new System.Drawing.Size(922, 62);
            this.ResultTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 55);
            this.label2.TabIndex = 3;
            this.label2.Text = "Result";
            // 
            // ButtonOkay
            // 
            this.ButtonOkay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonOkay.Location = new System.Drawing.Point(23, 176);
            this.ButtonOkay.Name = "ButtonOkay";
            this.ButtonOkay.Size = new System.Drawing.Size(892, 79);
            this.ButtonOkay.TabIndex = 6;
            this.ButtonOkay.Text = "Okay";
            this.ButtonOkay.UseVisualStyleBackColor = true;
            this.ButtonOkay.Click += new System.EventHandler(this.ButtonOkay_Click);
            // 
            // Lab1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 428);
            this.Controls.Add(this.ButtonOkay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumbersCountNumericUpDown);
            this.Name = "Lab1Form";
            this.Text = "Lab 1";
            ((System.ComponentModel.ISupportInitialize)(this.NumbersCountNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NumbersCountNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonOkay;
    }
}

