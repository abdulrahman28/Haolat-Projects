namespace AreaPerimeter
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
            this.areaTextBox = new System.Windows.Forms.TextBox();
            this.PerimeterTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radiusBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lengthBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(600, 144);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Area :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(428, 273);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Circumference :";
            // 
            // areaTextBox
            // 
            this.areaTextBox.Location = new System.Drawing.Point(750, 147);
            this.areaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.areaTextBox.Name = "areaTextBox";
            this.areaTextBox.Size = new System.Drawing.Size(160, 31);
            this.areaTextBox.TabIndex = 2;
            this.areaTextBox.TextChanged += new System.EventHandler(this.areaTextBox_TextChanged);
            // 
            // PerimeterTextBox
            // 
            this.PerimeterTextBox.Location = new System.Drawing.Point(750, 281);
            this.PerimeterTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PerimeterTextBox.Name = "PerimeterTextBox";
            this.PerimeterTextBox.Size = new System.Drawing.Size(160, 31);
            this.PerimeterTextBox.TabIndex = 3;
            this.PerimeterTextBox.TextChanged += new System.EventHandler(this.PerimeterTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(76, 147);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 42);
            this.label3.TabIndex = 5;
            this.label3.Text = "Radius :";
            // 
            // radiusBox
            // 
            this.radiusBox.Location = new System.Drawing.Point(256, 156);
            this.radiusBox.Margin = new System.Windows.Forms.Padding(4);
            this.radiusBox.Name = "radiusBox";
            this.radiusBox.Size = new System.Drawing.Size(136, 31);
            this.radiusBox.TabIndex = 6;
            this.radiusBox.TextChanged += new System.EventHandler(this.radiusBox_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.Lime;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Circle",
            "Rectangle",
            "Square"});
            this.comboBox1.Location = new System.Drawing.Point(83, 567);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(157, 41);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Text = "Circle";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lengthBox
            // 
            this.lengthBox.Location = new System.Drawing.Point(256, 281);
            this.lengthBox.Margin = new System.Windows.Forms.Padding(4);
            this.lengthBox.Name = "lengthBox";
            this.lengthBox.Size = new System.Drawing.Size(136, 31);
            this.lengthBox.TabIndex = 11;
            this.lengthBox.Visible = false;
            this.lengthBox.TextChanged += new System.EventHandler(this.lengthBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(76, 273);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 42);
            this.label4.TabIndex = 10;
            this.label4.Text = "Length :";
            this.label4.Visible = false;
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.clearButton.Location = new System.Drawing.Point(435, 553);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(138, 67);
            this.clearButton.TabIndex = 14;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.backButton.Location = new System.Drawing.Point(83, 37);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(152, 57);
            this.backButton.TabIndex = 15;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.Red;
            this.exitButton.Location = new System.Drawing.Point(813, 27);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(138, 67);
            this.exitButton.TabIndex = 16;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.calculateButton.Location = new System.Drawing.Point(411, 393);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(214, 57);
            this.calculateButton.TabIndex = 17;
            this.calculateButton.Text = "CALCULATE";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Visible = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.nextButton.Location = new System.Drawing.Point(804, 561);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(162, 61);
            this.nextButton.TabIndex = 18;
            this.nextButton.Text = "NEXT";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 690);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.lengthBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.radiusBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PerimeterTextBox);
            this.Controls.Add(this.areaTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Area and Perimeter Calulator for Various Shapes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox areaTextBox;
        private System.Windows.Forms.TextBox PerimeterTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox radiusBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox lengthBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button nextButton;
    }
}

