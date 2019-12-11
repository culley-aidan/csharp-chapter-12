namespace FiveColors
{
    partial class FiveColors
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
            this.btnColorOne = new System.Windows.Forms.Button();
            this.btnColorTwo = new System.Windows.Forms.Button();
            this.btnColorThree = new System.Windows.Forms.Button();
            this.btnColorFour = new System.Windows.Forms.Button();
            this.btnColorFive = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnColorOne
            // 
            this.btnColorOne.Location = new System.Drawing.Point(13, 13);
            this.btnColorOne.Name = "btnColorOne";
            this.btnColorOne.Size = new System.Drawing.Size(75, 23);
            this.btnColorOne.TabIndex = 0;
            this.btnColorOne.Text = "First";
            this.btnColorOne.UseVisualStyleBackColor = true;
            this.btnColorOne.Click += new System.EventHandler(this.btnColorOne_Click);
            // 
            // btnColorTwo
            // 
            this.btnColorTwo.Location = new System.Drawing.Point(13, 43);
            this.btnColorTwo.Name = "btnColorTwo";
            this.btnColorTwo.Size = new System.Drawing.Size(75, 23);
            this.btnColorTwo.TabIndex = 1;
            this.btnColorTwo.Text = "Second";
            this.btnColorTwo.UseVisualStyleBackColor = true;
            this.btnColorTwo.Click += new System.EventHandler(this.btnColorTwo_Click);
            // 
            // btnColorThree
            // 
            this.btnColorThree.Location = new System.Drawing.Point(13, 73);
            this.btnColorThree.Name = "btnColorThree";
            this.btnColorThree.Size = new System.Drawing.Size(75, 23);
            this.btnColorThree.TabIndex = 2;
            this.btnColorThree.Text = "Third";
            this.btnColorThree.UseVisualStyleBackColor = true;
            this.btnColorThree.Click += new System.EventHandler(this.btnColorThree_Click);
            // 
            // btnColorFour
            // 
            this.btnColorFour.Location = new System.Drawing.Point(13, 103);
            this.btnColorFour.Name = "btnColorFour";
            this.btnColorFour.Size = new System.Drawing.Size(75, 23);
            this.btnColorFour.TabIndex = 3;
            this.btnColorFour.Text = "Fourth";
            this.btnColorFour.UseVisualStyleBackColor = true;
            this.btnColorFour.Click += new System.EventHandler(this.btnColorFour_Click);
            // 
            // btnColorFive
            // 
            this.btnColorFive.Location = new System.Drawing.Point(13, 133);
            this.btnColorFive.Name = "btnColorFive";
            this.btnColorFive.Size = new System.Drawing.Size(75, 23);
            this.btnColorFive.TabIndex = 4;
            this.btnColorFive.Text = "Fifth";
            this.btnColorFive.UseVisualStyleBackColor = true;
            this.btnColorFive.Click += new System.EventHandler(this.btnColorFive_Click);
            // 
            // FiveColors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnColorFive);
            this.Controls.Add(this.btnColorFour);
            this.Controls.Add(this.btnColorThree);
            this.Controls.Add(this.btnColorTwo);
            this.Controls.Add(this.btnColorOne);
            this.Name = "FiveColors";
            this.Text = "FiveColors";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnColorOne;
        private System.Windows.Forms.Button btnColorTwo;
        private System.Windows.Forms.Button btnColorThree;
        private System.Windows.Forms.Button btnColorFour;
        private System.Windows.Forms.Button btnColorFive;
    }
}

