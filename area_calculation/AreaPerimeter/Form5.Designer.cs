namespace AreaPerimeter
{
    partial class Form5
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
            this.clearButton = new System.Windows.Forms.Button();
            this.bTextBox = new System.Windows.Forms.TextBox();
            this.labelb = new System.Windows.Forms.Label();
            this.aTextBox = new System.Windows.Forms.TextBox();
            this.labela = new System.Windows.Forms.Label();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.labelAnswer = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.clearButton.Location = new System.Drawing.Point(888, 718);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(154, 67);
            this.clearButton.TabIndex = 44;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // bTextBox
            // 
            this.bTextBox.Location = new System.Drawing.Point(315, 431);
            this.bTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.bTextBox.Name = "bTextBox";
            this.bTextBox.Size = new System.Drawing.Size(136, 31);
            this.bTextBox.TabIndex = 41;
            this.bTextBox.TextChanged += new System.EventHandler(this.bTextBox_TextChanged);
            // 
            // labelb
            // 
            this.labelb.AutoSize = true;
            this.labelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelb.ForeColor = System.Drawing.Color.Red;
            this.labelb.Location = new System.Drawing.Point(234, 420);
            this.labelb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelb.Name = "labelb";
            this.labelb.Size = new System.Drawing.Size(62, 42);
            this.labelb.TabIndex = 40;
            this.labelb.Text = "b :";
            // 
            // aTextBox
            // 
            this.aTextBox.Location = new System.Drawing.Point(315, 192);
            this.aTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.aTextBox.Name = "aTextBox";
            this.aTextBox.Size = new System.Drawing.Size(136, 31);
            this.aTextBox.TabIndex = 39;
            this.aTextBox.TextChanged += new System.EventHandler(this.aTextBox_TextChanged);
            // 
            // labela
            // 
            this.labela.AutoSize = true;
            this.labela.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labela.ForeColor = System.Drawing.Color.Red;
            this.labela.Location = new System.Drawing.Point(234, 181);
            this.labela.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labela.Name = "labela";
            this.labela.Size = new System.Drawing.Size(62, 42);
            this.labela.TabIndex = 38;
            this.labela.Text = "a :";
            // 
            // answerTextBox
            // 
            this.answerTextBox.Location = new System.Drawing.Point(825, 177);
            this.answerTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(160, 31);
            this.answerTextBox.TabIndex = 36;
            this.answerTextBox.TextChanged += new System.EventHandler(this.answerTextBox_TextChanged);
            // 
            // labelAnswer
            // 
            this.labelAnswer.AutoSize = true;
            this.labelAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnswer.ForeColor = System.Drawing.Color.Red;
            this.labelAnswer.Location = new System.Drawing.Point(634, 166);
            this.labelAnswer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.Size = new System.Drawing.Size(171, 42);
            this.labelAnswer.TabIndex = 34;
            this.labelAnswer.Text = "Answer :";
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.calculateButton.Location = new System.Drawing.Point(499, 562);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(214, 57);
            this.calculateButton.TabIndex = 33;
            this.calculateButton.Text = "CALCULATE";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Visible = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.Red;
            this.exitButton.Location = new System.Drawing.Point(68, 25);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(135, 67);
            this.exitButton.TabIndex = 32;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.Red;
            this.backButton.Location = new System.Drawing.Point(68, 720);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(135, 63);
            this.backButton.TabIndex = 31;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.Lime;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.comboBox1.Location = new System.Drawing.Point(335, 317);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(66, 41);
            this.comboBox1.TabIndex = 45;
            this.comboBox1.Text = "+";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 811);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.bTextBox);
            this.Controls.Add(this.labelb);
            this.Controls.Add(this.aTextBox);
            this.Controls.Add(this.labela);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.labelAnswer);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.backButton);
            this.Name = "Form5";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox bTextBox;
        private System.Windows.Forms.Label labelb;
        private System.Windows.Forms.TextBox aTextBox;
        private System.Windows.Forms.Label labela;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.Label labelAnswer;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}