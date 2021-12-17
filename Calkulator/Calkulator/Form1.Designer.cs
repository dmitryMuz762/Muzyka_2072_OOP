
namespace Calkulator
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
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.umnozh = new System.Windows.Forms.Button();
            this.delenie = new System.Windows.Forms.Button();
            this.ravno = new System.Windows.Forms.Button();
            this.znamenatel1 = new System.Windows.Forms.TextBox();
            this.znamenatel2 = new System.Windows.Forms.TextBox();
            this.chislitel1 = new System.Windows.Forms.TextBox();
            this.chislitel2 = new System.Windows.Forms.TextBox();
            this.sign1 = new System.Windows.Forms.Label();
            this.ravnoL = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // plus
            // 
            this.plus.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.plus.Location = new System.Drawing.Point(12, 350);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(97, 88);
            this.plus.TabIndex = 0;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // minus
            // 
            this.minus.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minus.Location = new System.Drawing.Point(153, 350);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(97, 88);
            this.minus.TabIndex = 1;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // umnozh
            // 
            this.umnozh.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.umnozh.Location = new System.Drawing.Point(290, 350);
            this.umnozh.Name = "umnozh";
            this.umnozh.Size = new System.Drawing.Size(97, 88);
            this.umnozh.TabIndex = 2;
            this.umnozh.Text = "*";
            this.umnozh.UseVisualStyleBackColor = true;
            this.umnozh.Click += new System.EventHandler(this.umnozh_Click);
            // 
            // delenie
            // 
            this.delenie.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.delenie.Location = new System.Drawing.Point(432, 350);
            this.delenie.Name = "delenie";
            this.delenie.Size = new System.Drawing.Size(97, 88);
            this.delenie.TabIndex = 3;
            this.delenie.Text = ":";
            this.delenie.UseVisualStyleBackColor = true;
            this.delenie.Click += new System.EventHandler(this.delenie_Click);
            // 
            // ravno
            // 
            this.ravno.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ravno.Location = new System.Drawing.Point(604, 350);
            this.ravno.Name = "ravno";
            this.ravno.Size = new System.Drawing.Size(172, 88);
            this.ravno.TabIndex = 4;
            this.ravno.Text = "=";
            this.ravno.UseVisualStyleBackColor = true;
            this.ravno.Click += new System.EventHandler(this.ravno_Click);
            // 
            // znamenatel1
            // 
            this.znamenatel1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.znamenatel1.Location = new System.Drawing.Point(40, 161);
            this.znamenatel1.Multiline = true;
            this.znamenatel1.Name = "znamenatel1";
            this.znamenatel1.Size = new System.Drawing.Size(86, 85);
            this.znamenatel1.TabIndex = 5;
            // 
            // znamenatel2
            // 
            this.znamenatel2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.znamenatel2.Location = new System.Drawing.Point(261, 161);
            this.znamenatel2.Multiline = true;
            this.znamenatel2.Name = "znamenatel2";
            this.znamenatel2.Size = new System.Drawing.Size(86, 85);
            this.znamenatel2.TabIndex = 6;
            // 
            // chislitel1
            // 
            this.chislitel1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chislitel1.Location = new System.Drawing.Point(40, 39);
            this.chislitel1.Multiline = true;
            this.chislitel1.Name = "chislitel1";
            this.chislitel1.Size = new System.Drawing.Size(86, 85);
            this.chislitel1.TabIndex = 7;
            // 
            // chislitel2
            // 
            this.chislitel2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chislitel2.Location = new System.Drawing.Point(261, 39);
            this.chislitel2.Multiline = true;
            this.chislitel2.Name = "chislitel2";
            this.chislitel2.Size = new System.Drawing.Size(86, 85);
            this.chislitel2.TabIndex = 8;
            // 
            // sign1
            // 
            this.sign1.AutoSize = true;
            this.sign1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sign1.Location = new System.Drawing.Point(153, 116);
            this.sign1.Name = "sign1";
            this.sign1.Size = new System.Drawing.Size(0, 46);
            this.sign1.TabIndex = 10;
            // 
            // ravnoL
            // 
            this.ravnoL.AutoSize = true;
            this.ravnoL.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ravnoL.Location = new System.Drawing.Point(407, 98);
            this.ravnoL.Name = "ravnoL";
            this.ravnoL.Size = new System.Drawing.Size(63, 67);
            this.ravnoL.TabIndex = 11;
            this.ravnoL.Text = "=";
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.result.Location = new System.Drawing.Point(510, 59);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(133, 147);
            this.result.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.result);
            this.Controls.Add(this.ravnoL);
            this.Controls.Add(this.sign1);
            this.Controls.Add(this.chislitel2);
            this.Controls.Add(this.chislitel1);
            this.Controls.Add(this.znamenatel2);
            this.Controls.Add(this.znamenatel1);
            this.Controls.Add(this.ravno);
            this.Controls.Add(this.delenie);
            this.Controls.Add(this.umnozh);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button umnozh;
        private System.Windows.Forms.Button delenie;
        private System.Windows.Forms.Button ravno;
        private System.Windows.Forms.TextBox znamenatel1;
        private System.Windows.Forms.TextBox znamenatel2;
        private System.Windows.Forms.TextBox chislitel1;
        private System.Windows.Forms.TextBox chislitel2;
        private System.Windows.Forms.Label sign1;
        private System.Windows.Forms.Label ravnoL;
        private System.Windows.Forms.TextBox result;
    }
}

