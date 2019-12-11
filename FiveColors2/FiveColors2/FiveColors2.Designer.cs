namespace FiveColors2
{
    partial class FiveColors2
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
            this.radColorOne = new System.Windows.Forms.RadioButton();
            this.radColorTwo = new System.Windows.Forms.RadioButton();
            this.radColorThree = new System.Windows.Forms.RadioButton();
            this.radColorFour = new System.Windows.Forms.RadioButton();
            this.radColorFive = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // radColorOne
            // 
            this.radColorOne.AutoSize = true;
            this.radColorOne.Location = new System.Drawing.Point(13, 13);
            this.radColorOne.Name = "radColorOne";
            this.radColorOne.Size = new System.Drawing.Size(46, 17);
            this.radColorOne.TabIndex = 0;
            this.radColorOne.TabStop = true;
            this.radColorOne.Text = "Blue";
            this.radColorOne.UseVisualStyleBackColor = true;
            this.radColorOne.CheckedChanged += new System.EventHandler(this.radColorOne_CheckedChanged);
            // 
            // radColorTwo
            // 
            this.radColorTwo.AutoSize = true;
            this.radColorTwo.Location = new System.Drawing.Point(13, 37);
            this.radColorTwo.Name = "radColorTwo";
            this.radColorTwo.Size = new System.Drawing.Size(52, 17);
            this.radColorTwo.TabIndex = 1;
            this.radColorTwo.TabStop = true;
            this.radColorTwo.Text = "Black";
            this.radColorTwo.UseVisualStyleBackColor = true;
            this.radColorTwo.CheckedChanged += new System.EventHandler(this.radColorTwo_CheckedChanged);
            // 
            // radColorThree
            // 
            this.radColorThree.AutoSize = true;
            this.radColorThree.Location = new System.Drawing.Point(13, 61);
            this.radColorThree.Name = "radColorThree";
            this.radColorThree.Size = new System.Drawing.Size(45, 17);
            this.radColorThree.TabIndex = 2;
            this.radColorThree.TabStop = true;
            this.radColorThree.Text = "Red";
            this.radColorThree.UseVisualStyleBackColor = true;
            this.radColorThree.CheckedChanged += new System.EventHandler(this.radColorThree_CheckedChanged);
            // 
            // radColorFour
            // 
            this.radColorFour.AutoSize = true;
            this.radColorFour.Location = new System.Drawing.Point(13, 85);
            this.radColorFour.Name = "radColorFour";
            this.radColorFour.Size = new System.Drawing.Size(55, 17);
            this.radColorFour.TabIndex = 3;
            this.radColorFour.TabStop = true;
            this.radColorFour.Text = "Brown";
            this.radColorFour.UseVisualStyleBackColor = true;
            this.radColorFour.CheckedChanged += new System.EventHandler(this.radColorFour_CheckedChanged);
            // 
            // radColorFive
            // 
            this.radColorFive.AutoSize = true;
            this.radColorFive.Location = new System.Drawing.Point(13, 109);
            this.radColorFive.Name = "radColorFive";
            this.radColorFive.Size = new System.Drawing.Size(53, 17);
            this.radColorFive.TabIndex = 4;
            this.radColorFive.TabStop = true;
            this.radColorFive.Text = "White";
            this.radColorFive.UseVisualStyleBackColor = true;
            this.radColorFive.CheckedChanged += new System.EventHandler(this.radColorFive_CheckedChanged);
            // 
            // FiveColors2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radColorFive);
            this.Controls.Add(this.radColorFour);
            this.Controls.Add(this.radColorThree);
            this.Controls.Add(this.radColorTwo);
            this.Controls.Add(this.radColorOne);
            this.Name = "FiveColors2";
            this.Text = "FiveColors2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radColorOne;
        private System.Windows.Forms.RadioButton radColorTwo;
        private System.Windows.Forms.RadioButton radColorThree;
        private System.Windows.Forms.RadioButton radColorFour;
        private System.Windows.Forms.RadioButton radColorFive;
    }
}

