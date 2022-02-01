namespace FishSh_t_Conversion
{
    partial class FishShit
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
            this.GallonsTextBox = new System.Windows.Forms.TextBox();
            this.CalcButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LitersTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(29, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fish Sh!t Conversion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(276, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gallons";
            // 
            // GallonsTextBox
            // 
            this.GallonsTextBox.Location = new System.Drawing.Point(139, 121);
            this.GallonsTextBox.Name = "GallonsTextBox";
            this.GallonsTextBox.Size = new System.Drawing.Size(100, 22);
            this.GallonsTextBox.TabIndex = 2;
            this.GallonsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CalcButton
            // 
            this.CalcButton.Font = new System.Drawing.Font("OCR A Extended", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcButton.Location = new System.Drawing.Point(129, 178);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(225, 65);
            this.CalcButton.TabIndex = 3;
            this.CalcButton.Text = "Calculate";
            this.CalcButton.UseVisualStyleBackColor = true;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(276, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Liters";
            // 
            // LitersTextBox
            // 
            this.LitersTextBox.Location = new System.Drawing.Point(139, 298);
            this.LitersTextBox.Name = "LitersTextBox";
            this.LitersTextBox.Size = new System.Drawing.Size(100, 22);
            this.LitersTextBox.TabIndex = 5;
            this.LitersTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FishShit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 416);
            this.Controls.Add(this.LitersTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CalcButton);
            this.Controls.Add(this.GallonsTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FishShit";
            this.Text = "Gallons to Liters";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox GallonsTextBox;
        private System.Windows.Forms.Button CalcButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LitersTextBox;
    }
}

