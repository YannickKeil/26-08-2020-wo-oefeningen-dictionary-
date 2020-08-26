namespace _26_08_2020_wo_oefeningen__dictionary_
{
    partial class oefening_1
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
            this.cbGetal = new System.Windows.Forms.ComboBox();
            this.lGetal = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // cbGetal
            // 
            this.cbGetal.FormattingEnabled = true;
            this.cbGetal.Location = new System.Drawing.Point(130, 59);
            this.cbGetal.Name = "cbGetal";
            this.cbGetal.Size = new System.Drawing.Size(121, 28);
            this.cbGetal.TabIndex = 0;
            this.cbGetal.SelectedIndexChanged += new System.EventHandler(this.cbGetal_SelectedIndexChanged);
            // 
            // lGetal
            // 
            this.lGetal.AutoSize = true;
            this.lGetal.Location = new System.Drawing.Point(331, 59);
            this.lGetal.Name = "lGetal";
            this.lGetal.Size = new System.Drawing.Size(51, 20);
            this.lGetal.TabIndex = 1;
            this.lGetal.Text = "label1";
            // 
            // oefening_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lGetal);
            this.Controls.Add(this.cbGetal);
            this.Name = "oefening_1";
            this.Text = "oefening_1";
            this.Load += new System.EventHandler(this.oefening_1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbGetal;
        private System.Windows.Forms.Label lGetal;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}