namespace WinFormsApp1
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
            this.boxRegion = new System.Windows.Forms.ComboBox();
            this.boxCity = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // boxRegion
            // 
            this.boxRegion.FormattingEnabled = true;
            this.boxRegion.Location = new System.Drawing.Point(78, 171);
            this.boxRegion.Name = "boxRegion";
            this.boxRegion.Size = new System.Drawing.Size(151, 28);
            this.boxRegion.TabIndex = 0;
            this.boxRegion.SelectedIndexChanged += new System.EventHandler(this.boxRegion_SelectedIndexChanged);
            // 
            // boxCity
            // 
            this.boxCity.FormattingEnabled = true;
            this.boxCity.Location = new System.Drawing.Point(456, 171);
            this.boxCity.Name = "boxCity";
            this.boxCity.Size = new System.Drawing.Size(151, 28);
            this.boxCity.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "region";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(515, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "city";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(344, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(161, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(481, 46);
            this.label3.TabIndex = 5;
            this.label3.Text = "Basic Winform Implementation";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 458);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxCity);
            this.Controls.Add(this.boxRegion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox boxRegion;
        private ComboBox boxCity;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
    }
}