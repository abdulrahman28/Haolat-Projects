namespace TempConversionGUI
{
    partial class MainPage
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
            this.temp_btn = new System.Windows.Forms.Button();
            this.circle_btn = new System.Windows.Forms.Button();
            this.ext_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // temp_btn
            // 
            this.temp_btn.ForeColor = System.Drawing.Color.Red;
            this.temp_btn.Location = new System.Drawing.Point(43, 75);
            this.temp_btn.Name = "temp_btn";
            this.temp_btn.Size = new System.Drawing.Size(98, 66);
            this.temp_btn.TabIndex = 0;
            this.temp_btn.Text = "Temperature";
            this.temp_btn.UseVisualStyleBackColor = true;
            this.temp_btn.Click += new System.EventHandler(this.temp_btn_Click);
            // 
            // circle_btn
            // 
            this.circle_btn.ForeColor = System.Drawing.Color.Blue;
            this.circle_btn.Location = new System.Drawing.Point(211, 75);
            this.circle_btn.Name = "circle_btn";
            this.circle_btn.Size = new System.Drawing.Size(98, 66);
            this.circle_btn.TabIndex = 0;
            this.circle_btn.Text = "Circle";
            this.circle_btn.UseVisualStyleBackColor = true;
            this.circle_btn.Click += new System.EventHandler(this.circle_btn_Click);
            // 
            // ext_btn
            // 
            this.ext_btn.BackColor = System.Drawing.Color.Red;
            this.ext_btn.Location = new System.Drawing.Point(322, 271);
            this.ext_btn.Name = "ext_btn";
            this.ext_btn.Size = new System.Drawing.Size(75, 23);
            this.ext_btn.TabIndex = 1;
            this.ext_btn.Text = "EXIT";
            this.ext_btn.UseVisualStyleBackColor = false;
            this.ext_btn.Click += new System.EventHandler(this.ext_btn_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 293);
            this.Controls.Add(this.ext_btn);
            this.Controls.Add(this.circle_btn);
            this.Controls.Add(this.temp_btn);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button temp_btn;
        private System.Windows.Forms.Button circle_btn;
        private System.Windows.Forms.Button ext_btn;
    }
}