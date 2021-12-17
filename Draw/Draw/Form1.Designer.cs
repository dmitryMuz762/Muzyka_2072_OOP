
namespace Draw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Circle = new System.Windows.Forms.Button();
            this.Rec = new System.Windows.Forms.Button();
            this.Wagon = new System.Windows.Forms.Button();
            this.Coal = new System.Windows.Forms.Button();
            this.Sand = new System.Windows.Forms.Button();
            this.Train = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Radius = new System.Windows.Forms.TextBox();
            this.Count = new System.Windows.Forms.TextBox();
            this.height = new System.Windows.Forms.TextBox();
            this.width = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Orangered = new System.Windows.Forms.Button();
            this.Lime = new System.Windows.Forms.Button();
            this.DarkViolet = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 494);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // Circle
            // 
            this.Circle.Location = new System.Drawing.Point(844, 21);
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(87, 49);
            this.Circle.TabIndex = 1;
            this.Circle.Text = "Circle";
            this.Circle.UseVisualStyleBackColor = true;
            this.Circle.Click += new System.EventHandler(this.Circle_Click);
            // 
            // Rec
            // 
            this.Rec.Location = new System.Drawing.Point(844, 83);
            this.Rec.Name = "Rec";
            this.Rec.Size = new System.Drawing.Size(87, 49);
            this.Rec.TabIndex = 2;
            this.Rec.Text = "Rectangle";
            this.Rec.UseVisualStyleBackColor = true;
            this.Rec.Click += new System.EventHandler(this.Rec_Click);
            // 
            // Wagon
            // 
            this.Wagon.Location = new System.Drawing.Point(844, 155);
            this.Wagon.Name = "Wagon";
            this.Wagon.Size = new System.Drawing.Size(87, 49);
            this.Wagon.TabIndex = 3;
            this.Wagon.Text = "Wagon";
            this.Wagon.UseVisualStyleBackColor = true;
            this.Wagon.Click += new System.EventHandler(this.Wagon_Click);
            // 
            // Coal
            // 
            this.Coal.Location = new System.Drawing.Point(844, 221);
            this.Coal.Name = "Coal";
            this.Coal.Size = new System.Drawing.Size(87, 49);
            this.Coal.TabIndex = 4;
            this.Coal.Text = "Coal";
            this.Coal.UseVisualStyleBackColor = true;
            this.Coal.Click += new System.EventHandler(this.Coal_Click);
            // 
            // Sand
            // 
            this.Sand.Location = new System.Drawing.Point(844, 285);
            this.Sand.Name = "Sand";
            this.Sand.Size = new System.Drawing.Size(87, 49);
            this.Sand.TabIndex = 5;
            this.Sand.Text = "Sand";
            this.Sand.UseVisualStyleBackColor = true;
            this.Sand.Click += new System.EventHandler(this.Sand_Click);
            // 
            // Train
            // 
            this.Train.Location = new System.Drawing.Point(844, 346);
            this.Train.Name = "Train";
            this.Train.Size = new System.Drawing.Size(87, 49);
            this.Train.TabIndex = 6;
            this.Train.Text = "Train";
            this.Train.UseVisualStyleBackColor = true;
            this.Train.Click += new System.EventHandler(this.Train_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(844, 410);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(87, 49);
            this.Clear.TabIndex = 7;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Radius
            // 
            this.Radius.Location = new System.Drawing.Point(665, 87);
            this.Radius.Name = "Radius";
            this.Radius.Size = new System.Drawing.Size(125, 27);
            this.Radius.TabIndex = 8;
            // 
            // Count
            // 
            this.Count.Location = new System.Drawing.Point(665, 331);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(125, 27);
            this.Count.TabIndex = 9;
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(665, 250);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(125, 27);
            this.height.TabIndex = 10;
            // 
            // width
            // 
            this.width.Location = new System.Drawing.Point(665, 163);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(125, 27);
            this.width.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(701, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Radius";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(702, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(702, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Height";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(704, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Count";
            // 
            // Orangered
            // 
            this.Orangered.BackColor = System.Drawing.Color.OrangeRed;
            this.Orangered.Location = new System.Drawing.Point(671, 397);
            this.Orangered.Name = "Orangered";
            this.Orangered.Size = new System.Drawing.Size(30, 30);
            this.Orangered.TabIndex = 16;
            this.Orangered.UseVisualStyleBackColor = false;
            this.Orangered.Click += new System.EventHandler(this.Orangered_Click);
            // 
            // Lime
            // 
            this.Lime.BackColor = System.Drawing.Color.Lime;
            this.Lime.Location = new System.Drawing.Point(712, 397);
            this.Lime.Name = "Lime";
            this.Lime.Size = new System.Drawing.Size(30, 30);
            this.Lime.TabIndex = 17;
            this.Lime.UseVisualStyleBackColor = false;
            this.Lime.Click += new System.EventHandler(this.Lime_Click);
            // 
            // DarkViolet
            // 
            this.DarkViolet.BackColor = System.Drawing.Color.DarkViolet;
            this.DarkViolet.Location = new System.Drawing.Point(754, 397);
            this.DarkViolet.Name = "DarkViolet";
            this.DarkViolet.Size = new System.Drawing.Size(30, 30);
            this.DarkViolet.TabIndex = 18;
            this.DarkViolet.UseVisualStyleBackColor = false;
            this.DarkViolet.Click += new System.EventHandler(this.DarkViolet_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(704, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Color";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1070, 559);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DarkViolet);
            this.Controls.Add(this.Lime);
            this.Controls.Add(this.Orangered);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.width);
            this.Controls.Add(this.height);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.Radius);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Train);
            this.Controls.Add(this.Sand);
            this.Controls.Add(this.Coal);
            this.Controls.Add(this.Wagon);
            this.Controls.Add(this.Rec);
            this.Controls.Add(this.Circle);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Circle;
        private System.Windows.Forms.Button Rec;
        private System.Windows.Forms.Button Wagon;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Coal;
        private System.Windows.Forms.Button Sand;
        private System.Windows.Forms.Button Train;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.TextBox Radius;
        private System.Windows.Forms.TextBox Count;
        private System.Windows.Forms.TextBox height;
        private System.Windows.Forms.TextBox width;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Orangered;
        private System.Windows.Forms.Button Lime;
        private System.Windows.Forms.Button DarkViolet;
        private System.Windows.Forms.Label label5;
    }
}

