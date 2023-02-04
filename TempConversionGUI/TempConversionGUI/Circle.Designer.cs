namespace TempConversionGUI
{
    partial class Circle
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
            this.rad_txt_box = new System.Windows.Forms.TextBox();
            this.cir_lbl = new System.Windows.Forms.Label();
            this.area_lbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.main_btn = new System.Windows.Forms.Button();
            this.rtext = new System.Windows.Forms.TextBox();
            this.rad = new System.Windows.Forms.Label();
            this.ctext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.areatxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Radius:";
            // 
            // rad_txt_box
            // 
            this.rad_txt_box.ForeColor = System.Drawing.Color.Black;
            this.rad_txt_box.Location = new System.Drawing.Point(95, 37);
            this.rad_txt_box.Name = "rad_txt_box";
            this.rad_txt_box.Size = new System.Drawing.Size(55, 20);
            this.rad_txt_box.TabIndex = 1;
            this.rad_txt_box.TextChanged += new System.EventHandler(this.rad_txt_box_TextChanged);
            // 
            // cir_lbl
            // 
            this.cir_lbl.AutoSize = true;
            this.cir_lbl.ForeColor = System.Drawing.Color.Black;
            this.cir_lbl.Location = new System.Drawing.Point(95, 85);
            this.cir_lbl.Name = "cir_lbl";
            this.cir_lbl.Size = new System.Drawing.Size(35, 13);
            this.cir_lbl.TabIndex = 2;
            this.cir_lbl.Text = "label2";
            // 
            // area_lbl
            // 
            this.area_lbl.AutoSize = true;
            this.area_lbl.Location = new System.Drawing.Point(95, 127);
            this.area_lbl.Name = "area_lbl";
            this.area_lbl.Size = new System.Drawing.Size(35, 13);
            this.area_lbl.TabIndex = 3;
            this.area_lbl.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Circumference:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Area:";
            // 
            // main_btn
            // 
            this.main_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.main_btn.Location = new System.Drawing.Point(60, 174);
            this.main_btn.Name = "main_btn";
            this.main_btn.Size = new System.Drawing.Size(146, 65);
            this.main_btn.TabIndex = 6;
            this.main_btn.Text = "Main Page";
            this.main_btn.UseVisualStyleBackColor = true;
            this.main_btn.Click += new System.EventHandler(this.main_btn_Click);
            // 
            // rtext
            // 
            this.rtext.Location = new System.Drawing.Point(416, 64);
            this.rtext.Name = "rtext";
            this.rtext.Size = new System.Drawing.Size(100, 20);
            this.rtext.TabIndex = 7;
            this.rtext.TextChanged += new System.EventHandler(this.rtext_TextChanged);
            // 
            // rad
            // 
            this.rad.AutoSize = true;
            this.rad.Location = new System.Drawing.Point(367, 67);
            this.rad.Name = "rad";
            this.rad.Size = new System.Drawing.Size(43, 13);
            this.rad.TabIndex = 8;
            this.rad.Text = "Radius:";
            // 
            // ctext
            // 
            this.ctext.Location = new System.Drawing.Point(416, 120);
            this.ctext.Name = "ctext";
            this.ctext.Size = new System.Drawing.Size(100, 20);
            this.ctext.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Circumference:";
            // 
            // areatxt
            // 
            this.areatxt.Location = new System.Drawing.Point(416, 174);
            this.areatxt.Name = "areatxt";
            this.areatxt.Size = new System.Drawing.Size(100, 20);
            this.areatxt.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Area:";
            // 
            // Circle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 297);
            this.Controls.Add(this.areatxt);
            this.Controls.Add(this.ctext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rad);
            this.Controls.Add(this.rtext);
            this.Controls.Add(this.main_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.area_lbl);
            this.Controls.Add(this.cir_lbl);
            this.Controls.Add(this.rad_txt_box);
            this.Controls.Add(this.label1);
            this.Name = "Circle";
            this.Text = "Circle";
            this.Load += new System.EventHandler(this.Circle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rad_txt_box;
        private System.Windows.Forms.Label cir_lbl;
        private System.Windows.Forms.Label area_lbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button main_btn;
        private System.Windows.Forms.TextBox rtext;
        private System.Windows.Forms.Label rad;
        private System.Windows.Forms.TextBox ctext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox areatxt;
        private System.Windows.Forms.Label label3;
    }
}