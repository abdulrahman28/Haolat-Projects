namespace TempConversionGUI
{
    partial class Tempeature
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
            this.label3 = new System.Windows.Forms.Label();
            this.far_txt_box = new System.Windows.Forms.TextBox();
            this.cel_txt_box = new System.Windows.Forms.TextBox();
            this.cvt_btn = new System.Windows.Forms.Button();
            this.ext_btn = new System.Windows.Forms.Button();
            this.clr_btn = new System.Windows.Forms.Button();
            this.main_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(95, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temperature Converter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(37, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fahrenheit:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(59, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Celsius:";
            // 
            // far_txt_box
            // 
            this.far_txt_box.Location = new System.Drawing.Point(117, 67);
            this.far_txt_box.Name = "far_txt_box";
            this.far_txt_box.Size = new System.Drawing.Size(100, 20);
            this.far_txt_box.TabIndex = 1;
            this.far_txt_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.far_txt_box.TextChanged += new System.EventHandler(this.far_txt_box_TextChanged);
            // 
            // cel_txt_box
            // 
            this.cel_txt_box.Location = new System.Drawing.Point(117, 104);
            this.cel_txt_box.Name = "cel_txt_box";
            this.cel_txt_box.Size = new System.Drawing.Size(100, 20);
            this.cel_txt_box.TabIndex = 1;
            this.cel_txt_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cel_txt_box.TextChanged += new System.EventHandler(this.cel_txt_box_TextChanged);
            // 
            // cvt_btn
            // 
            this.cvt_btn.ForeColor = System.Drawing.Color.Red;
            this.cvt_btn.Location = new System.Drawing.Point(89, 150);
            this.cvt_btn.Name = "cvt_btn";
            this.cvt_btn.Size = new System.Drawing.Size(128, 41);
            this.cvt_btn.TabIndex = 2;
            this.cvt_btn.Text = "Convert";
            this.cvt_btn.UseVisualStyleBackColor = true;
            this.cvt_btn.Click += new System.EventHandler(this.cvt_btn_Click);
            // 
            // ext_btn
            // 
            this.ext_btn.BackColor = System.Drawing.Color.Red;
            this.ext_btn.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ext_btn.Location = new System.Drawing.Point(292, 217);
            this.ext_btn.Name = "ext_btn";
            this.ext_btn.Size = new System.Drawing.Size(75, 27);
            this.ext_btn.TabIndex = 3;
            this.ext_btn.Text = "EXIT";
            this.ext_btn.UseVisualStyleBackColor = false;
            this.ext_btn.Click += new System.EventHandler(this.ext_btn_Click);
            // 
            // clr_btn
            // 
            this.clr_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.clr_btn.Location = new System.Drawing.Point(243, 79);
            this.clr_btn.Name = "clr_btn";
            this.clr_btn.Size = new System.Drawing.Size(90, 28);
            this.clr_btn.TabIndex = 4;
            this.clr_btn.Text = "Clear";
            this.clr_btn.UseVisualStyleBackColor = true;
            this.clr_btn.Click += new System.EventHandler(this.clr_btn_Click);
            // 
            // main_btn
            // 
            this.main_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.main_btn.Location = new System.Drawing.Point(89, 197);
            this.main_btn.Name = "main_btn";
            this.main_btn.Size = new System.Drawing.Size(128, 37);
            this.main_btn.TabIndex = 5;
            this.main_btn.Text = "Main Page";
            this.main_btn.UseVisualStyleBackColor = true;
            this.main_btn.Click += new System.EventHandler(this.main_btn_Click);
            // 
            // Tempeature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(367, 242);
            this.Controls.Add(this.main_btn);
            this.Controls.Add(this.clr_btn);
            this.Controls.Add(this.ext_btn);
            this.Controls.Add(this.cvt_btn);
            this.Controls.Add(this.cel_txt_box);
            this.Controls.Add(this.far_txt_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Tempeature";
            this.Text = "Temperature Converter";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox far_txt_box;
        private System.Windows.Forms.TextBox cel_txt_box;
        private System.Windows.Forms.Button cvt_btn;
        private System.Windows.Forms.Button ext_btn;
        private System.Windows.Forms.Button clr_btn;
        private System.Windows.Forms.Button main_btn;
    }
}

