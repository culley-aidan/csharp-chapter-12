namespace MyFlix
{
    partial class MyFlix
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
            this.lstSelections = new System.Windows.Forms.ListBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.btnFinished = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstSelections
            // 
            this.lstSelections.FormattingEnabled = true;
            this.lstSelections.Items.AddRange(new object[] {
            "Movie One",
            "Movie Two",
            "Movie Three",
            "Movie Four",
            "Movie Five",
            "Movie Six"});
            this.lstSelections.Location = new System.Drawing.Point(12, 12);
            this.lstSelections.Name = "lstSelections";
            this.lstSelections.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstSelections.Size = new System.Drawing.Size(120, 82);
            this.lstSelections.TabIndex = 0;
            this.lstSelections.SelectedIndexChanged += new System.EventHandler(this.lstSelections_SelectedIndexChanged);
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(139, 13);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(287, 13);
            this.lblInstructions.TabIndex = 1;
            this.lblInstructions.Text = "Choose as many downloads as you want by holding ctrl key";
            // 
            // btnFinished
            // 
            this.btnFinished.Location = new System.Drawing.Point(142, 70);
            this.btnFinished.Name = "btnFinished";
            this.btnFinished.Size = new System.Drawing.Size(75, 23);
            this.btnFinished.TabIndex = 2;
            this.btnFinished.Text = "Finish";
            this.btnFinished.UseVisualStyleBackColor = true;
            this.btnFinished.Click += new System.EventHandler(this.btnFinished_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(223, 75);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(37, 13);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "$X.XX";
            this.lblPrice.Visible = false;
            // 
            // MyFlix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.btnFinished);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lstSelections);
            this.Name = "MyFlix";
            this.Text = "MyFlix";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSelections;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Button btnFinished;
        private System.Windows.Forms.Label lblPrice;
    }
}

