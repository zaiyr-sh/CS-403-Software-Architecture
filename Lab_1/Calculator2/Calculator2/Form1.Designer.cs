
namespace Calculator2
{
    partial class form1
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
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.secondInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.firstInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.signInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(51, 190);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(184, 20);
            this.txtAnswer.TabIndex = 17;
            // 
            // secondInput
            // 
            this.secondInput.Location = new System.Drawing.Point(52, 88);
            this.secondInput.Name = "secondInput";
            this.secondInput.Size = new System.Drawing.Size(184, 20);
            this.secondInput.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Второе число";
            // 
            // firstInput
            // 
            this.firstInput.Location = new System.Drawing.Point(51, 45);
            this.firstInput.Name = "firstInput";
            this.firstInput.Size = new System.Drawing.Size(184, 20);
            this.firstInput.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Первое число";
            // 
            // signInput
            // 
            this.signInput.Location = new System.Drawing.Point(51, 128);
            this.signInput.Name = "signInput";
            this.signInput.Size = new System.Drawing.Size(184, 20);
            this.signInput.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Знак операции";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(50, 161);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(184, 23);
            this.btnCalculate.TabIndex = 20;
            this.btnCalculate.Text = "Итого";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(283, 254);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.signInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.secondInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstInput);
            this.Controls.Add(this.label1);
            this.Name = "form1";
            this.Text = "Калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.TextBox secondInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox signInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalculate;
    }
}

