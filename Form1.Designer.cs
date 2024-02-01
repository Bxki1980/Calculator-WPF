
namespace Calculator_WindowsForm_
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Number1 = new System.Windows.Forms.NumericUpDown();
            this.Number2 = new System.Windows.Forms.NumericUpDown();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnMultipule = new System.Windows.Forms.Button();
            this.btnDivde = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Number1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Number2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = " Enter the 1 Number :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = " Enter the 2 Number :";
            // 
            // Number1
            // 
            this.Number1.Location = new System.Drawing.Point(126, 50);
            this.Number1.Name = "Number1";
            this.Number1.Size = new System.Drawing.Size(353, 20);
            this.Number1.TabIndex = 2;
            // 
            // Number2
            // 
            this.Number2.Location = new System.Drawing.Point(126, 87);
            this.Number2.Name = "Number2";
            this.Number2.Size = new System.Drawing.Size(353, 20);
            this.Number2.TabIndex = 3;
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(369, 120);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 37);
            this.btnPlus.TabIndex = 4;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click_1);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(288, 120);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(75, 37);
            this.btnMinus.TabIndex = 5;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnMultipule
            // 
            this.btnMultipule.Location = new System.Drawing.Point(207, 120);
            this.btnMultipule.Name = "btnMultipule";
            this.btnMultipule.Size = new System.Drawing.Size(75, 37);
            this.btnMultipule.TabIndex = 6;
            this.btnMultipule.Text = "*";
            this.btnMultipule.UseVisualStyleBackColor = true;
            this.btnMultipule.Click += new System.EventHandler(this.btnMultipule_Click);
            // 
            // btnDivde
            // 
            this.btnDivde.Location = new System.Drawing.Point(126, 120);
            this.btnDivde.Name = "btnDivde";
            this.btnDivde.Size = new System.Drawing.Size(75, 37);
            this.btnDivde.TabIndex = 7;
            this.btnDivde.Text = "/";
            this.btnDivde.UseVisualStyleBackColor = true;
            this.btnDivde.Click += new System.EventHandler(this.btnDivde_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 182);
            this.Controls.Add(this.btnDivde);
            this.Controls.Add(this.btnMultipule);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.Number2);
            this.Controls.Add(this.Number1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Number1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Number2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Number1;
        private System.Windows.Forms.NumericUpDown Number2;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnMultipule;
        private System.Windows.Forms.Button btnDivde;
    }
}

