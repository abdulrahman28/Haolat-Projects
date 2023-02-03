namespace AreaPerimeter
{
    partial class Form3
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
            this.exitButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.bTextBox = new System.Windows.Forms.TextBox();
            this.labelb = new System.Windows.Forms.Label();
            this.aTextBox = new System.Windows.Forms.TextBox();
            this.labela = new System.Windows.Forms.Label();
            this.x2TextBox = new System.Windows.Forms.TextBox();
            this.x1TextBox = new System.Windows.Forms.TextBox();
            this.labelx2 = new System.Windows.Forms.Label();
            this.labelx1 = new System.Windows.Forms.Label();
            this.cTextBox = new System.Windows.Forms.TextBox();
            this.labelc = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.Red;
            this.exitButton.Location = new System.Drawing.Point(68, 38);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(135, 67);
            this.exitButton.TabIndex = 13;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.Red;
            this.backButton.Location = new System.Drawing.Point(68, 546);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(135, 63);
            this.backButton.TabIndex = 12;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.nextButton.Location = new System.Drawing.Point(890, 546);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(137, 61);
            this.nextButton.TabIndex = 11;
            this.nextButton.Text = "NEXT";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.calculateButton.Location = new System.Drawing.Point(425, 473);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(214, 57);
            this.calculateButton.TabIndex = 18;
            this.calculateButton.Text = "CALCULATE";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Visible = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // bTextBox
            // 
            this.bTextBox.Location = new System.Drawing.Point(199, 263);
            this.bTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.bTextBox.Name = "bTextBox";
            this.bTextBox.Size = new System.Drawing.Size(136, 31);
            this.bTextBox.TabIndex = 26;
            this.bTextBox.TextChanged += new System.EventHandler(this.bTextBox_TextChanged);
            // 
            // labelb
            // 
            this.labelb.AutoSize = true;
            this.labelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelb.ForeColor = System.Drawing.Color.Red;
            this.labelb.Location = new System.Drawing.Point(118, 252);
            this.labelb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelb.Name = "labelb";
            this.labelb.Size = new System.Drawing.Size(62, 42);
            this.labelb.TabIndex = 25;
            this.labelb.Text = "b :";
            // 
            // aTextBox
            // 
            this.aTextBox.Location = new System.Drawing.Point(199, 156);
            this.aTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.aTextBox.Name = "aTextBox";
            this.aTextBox.Size = new System.Drawing.Size(136, 31);
            this.aTextBox.TabIndex = 24;
            this.aTextBox.TextChanged += new System.EventHandler(this.aTextBox_TextChanged);
            // 
            // labela
            // 
            this.labela.AutoSize = true;
            this.labela.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labela.ForeColor = System.Drawing.Color.Red;
            this.labela.Location = new System.Drawing.Point(118, 145);
            this.labela.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labela.Name = "labela";
            this.labela.Size = new System.Drawing.Size(62, 42);
            this.labela.TabIndex = 23;
            this.labela.Text = "a :";
            // 
            // x2TextBox
            // 
            this.x2TextBox.Location = new System.Drawing.Point(666, 264);
            this.x2TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.x2TextBox.Name = "x2TextBox";
            this.x2TextBox.Size = new System.Drawing.Size(160, 31);
            this.x2TextBox.TabIndex = 22;
            // 
            // x1TextBox
            // 
            this.x1TextBox.Location = new System.Drawing.Point(666, 160);
            this.x1TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.x1TextBox.Name = "x1TextBox";
            this.x1TextBox.Size = new System.Drawing.Size(160, 31);
            this.x1TextBox.TabIndex = 21;
            // 
            // labelx2
            // 
            this.labelx2.AutoSize = true;
            this.labelx2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelx2.ForeColor = System.Drawing.Color.Red;
            this.labelx2.Location = new System.Drawing.Point(529, 261);
            this.labelx2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelx2.Name = "labelx2";
            this.labelx2.Size = new System.Drawing.Size(88, 42);
            this.labelx2.TabIndex = 20;
            this.labelx2.Text = "X2 :";
            // 
            // labelx1
            // 
            this.labelx1.AutoSize = true;
            this.labelx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelx1.ForeColor = System.Drawing.Color.Red;
            this.labelx1.Location = new System.Drawing.Point(529, 149);
            this.labelx1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelx1.Name = "labelx1";
            this.labelx1.Size = new System.Drawing.Size(77, 42);
            this.labelx1.TabIndex = 19;
            this.labelx1.Text = "X1:";
            // 
            // cTextBox
            // 
            this.cTextBox.Location = new System.Drawing.Point(199, 376);
            this.cTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.cTextBox.Name = "cTextBox";
            this.cTextBox.Size = new System.Drawing.Size(136, 31);
            this.cTextBox.TabIndex = 28;
            this.cTextBox.TextChanged += new System.EventHandler(this.cTextBox_TextChanged);
            // 
            // labelc
            // 
            this.labelc.AutoSize = true;
            this.labelc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelc.ForeColor = System.Drawing.Color.Red;
            this.labelc.Location = new System.Drawing.Point(118, 365);
            this.labelc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelc.Name = "labelc";
            this.labelc.Size = new System.Drawing.Size(60, 42);
            this.labelc.TabIndex = 27;
            this.labelc.Text = "c :";
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.clearButton.Location = new System.Drawing.Point(873, 38);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(154, 67);
            this.clearButton.TabIndex = 29;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 655);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.cTextBox);
            this.Controls.Add(this.labelc);
            this.Controls.Add(this.bTextBox);
            this.Controls.Add(this.labelb);
            this.Controls.Add(this.aTextBox);
            this.Controls.Add(this.labela);
            this.Controls.Add(this.x2TextBox);
            this.Controls.Add(this.x1TextBox);
            this.Controls.Add(this.labelx2);
            this.Controls.Add(this.labelx1);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.nextButton);
            this.Name = "Form3";
            this.Text = "Quadratic Equation Calculator";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox bTextBox;
        private System.Windows.Forms.Label labelb;
        private System.Windows.Forms.TextBox aTextBox;
        private System.Windows.Forms.Label labela;
        private System.Windows.Forms.TextBox x2TextBox;
        private System.Windows.Forms.TextBox x1TextBox;
        private System.Windows.Forms.Label labelx2;
        private System.Windows.Forms.Label labelx1;
        private System.Windows.Forms.TextBox cTextBox;
        private System.Windows.Forms.Label labelc;
        private System.Windows.Forms.Button clearButton;
    }
}