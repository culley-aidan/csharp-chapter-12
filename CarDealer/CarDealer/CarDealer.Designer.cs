namespace CarDealer
{
    partial class CarDealer
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
            this.radCarOne = new System.Windows.Forms.RadioButton();
            this.radCarTwo = new System.Windows.Forms.RadioButton();
            this.radCarThree = new System.Windows.Forms.RadioButton();
            this.btnSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radCarOne
            // 
            this.radCarOne.AutoSize = true;
            this.radCarOne.Location = new System.Drawing.Point(13, 13);
            this.radCarOne.Name = "radCarOne";
            this.radCarOne.Size = new System.Drawing.Size(64, 17);
            this.radCarOne.TabIndex = 0;
            this.radCarOne.TabStop = true;
            this.radCarOne.Text = "Car One";
            this.radCarOne.UseVisualStyleBackColor = true;
            // 
            // radCarTwo
            // 
            this.radCarTwo.AutoSize = true;
            this.radCarTwo.Location = new System.Drawing.Point(13, 37);
            this.radCarTwo.Name = "radCarTwo";
            this.radCarTwo.Size = new System.Drawing.Size(65, 17);
            this.radCarTwo.TabIndex = 1;
            this.radCarTwo.TabStop = true;
            this.radCarTwo.Text = "Car Two";
            this.radCarTwo.UseVisualStyleBackColor = true;
            // 
            // radCarThree
            // 
            this.radCarThree.AutoSize = true;
            this.radCarThree.Location = new System.Drawing.Point(13, 61);
            this.radCarThree.Name = "radCarThree";
            this.radCarThree.Size = new System.Drawing.Size(72, 17);
            this.radCarThree.TabIndex = 2;
            this.radCarThree.TabStop = true;
            this.radCarThree.Text = "Car Three";
            this.radCarThree.UseVisualStyleBackColor = true;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(116, 31);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "Info";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // CarDealer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.radCarThree);
            this.Controls.Add(this.radCarTwo);
            this.Controls.Add(this.radCarOne);
            this.Name = "CarDealer";
            this.Text = "CarDealer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radCarOne;
        private System.Windows.Forms.RadioButton radCarTwo;
        private System.Windows.Forms.RadioButton radCarThree;
        private System.Windows.Forms.Button btnSelect;
    }
}

