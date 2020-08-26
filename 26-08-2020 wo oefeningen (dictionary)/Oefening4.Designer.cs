namespace _26_08_2020_wo_oefeningen__dictionary_
{
    partial class Oefening4
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
            this.nudGetal = new System.Windows.Forms.NumericUpDown();
            this.lGetal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudGetal)).BeginInit();
            this.SuspendLayout();
            // 
            // nudGetal
            // 
            this.nudGetal.Location = new System.Drawing.Point(123, 101);
            this.nudGetal.Maximum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            0});
            this.nudGetal.Name = "nudGetal";
            this.nudGetal.Size = new System.Drawing.Size(120, 26);
            this.nudGetal.TabIndex = 0;
            this.nudGetal.ValueChanged += new System.EventHandler(this.nudGetal_ValueChanged);
            // 
            // lGetal
            // 
            this.lGetal.AutoSize = true;
            this.lGetal.Location = new System.Drawing.Point(345, 101);
            this.lGetal.Name = "lGetal";
            this.lGetal.Size = new System.Drawing.Size(51, 20);
            this.lGetal.TabIndex = 1;
            this.lGetal.Text = "label1";
            // 
            // Oefening4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lGetal);
            this.Controls.Add(this.nudGetal);
            this.Name = "Oefening4";
            this.Text = "Oefening4";
            this.Load += new System.EventHandler(this.Oefening4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudGetal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudGetal;
        private System.Windows.Forms.Label lGetal;
    }
}