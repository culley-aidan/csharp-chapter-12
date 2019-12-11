namespace FontSelector
{
    partial class FontSelector
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
            this.lstFonts = new System.Windows.Forms.ListBox();
            this.lstSize = new System.Windows.Forms.ListBox();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnFinish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstFonts
            // 
            this.lstFonts.FormattingEnabled = true;
            this.lstFonts.Items.AddRange(new object[] {
            "Microsoft Sans Serif",
            "Arial",
            "Comic Sans MS",
            "Calibri"});
            this.lstFonts.Location = new System.Drawing.Point(13, 13);
            this.lstFonts.Name = "lstFonts";
            this.lstFonts.Size = new System.Drawing.Size(120, 95);
            this.lstFonts.TabIndex = 0;
            // 
            // lstSize
            // 
            this.lstSize.FormattingEnabled = true;
            this.lstSize.Items.AddRange(new object[] {
            "8",
            "12",
            "16",
            "20"});
            this.lstSize.Location = new System.Drawing.Point(139, 13);
            this.lstSize.Name = "lstSize";
            this.lstSize.Size = new System.Drawing.Size(120, 95);
            this.lstSize.TabIndex = 1;
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Location = new System.Drawing.Point(113, 152);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(31, 13);
            this.lblDisplay.TabIndex = 2;
            this.lblDisplay.Text = "Hello";
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(94, 114);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(75, 23);
            this.btnFinish.TabIndex = 3;
            this.btnFinish.Text = "finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // FontSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.lstSize);
            this.Controls.Add(this.lstFonts);
            this.Name = "FontSelector";
            this.Text = "FontSelector";
            this.Load += new System.EventHandler(this.FontSelector_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstFonts;
        private System.Windows.Forms.ListBox lstSize;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btnFinish;
    }
}

