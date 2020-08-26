namespace _26_08_2020_wo_oefeningen__dictionary_
{
    partial class Oef2_Woordenboek
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
            this.components = new System.ComponentModel.Container();
            this.tbNederlands = new System.Windows.Forms.TextBox();
            this.tbEngels = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.epText = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epText)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNederlands
            // 
            this.tbNederlands.Location = new System.Drawing.Point(138, 97);
            this.tbNederlands.Name = "tbNederlands";
            this.tbNederlands.Size = new System.Drawing.Size(100, 26);
            this.tbNederlands.TabIndex = 0;
            this.tbNederlands.TextChanged += new System.EventHandler(this.tbNederlands_TextChanged);
            // 
            // tbEngels
            // 
            this.tbEngels.Location = new System.Drawing.Point(352, 96);
            this.tbEngels.Name = "tbEngels";
            this.tbEngels.Size = new System.Drawing.Size(100, 26);
            this.tbEngels.TabIndex = 1;
            this.tbEngels.TextChanged += new System.EventHandler(this.tbEngels_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(138, 179);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 45);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(352, 179);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 45);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nederlands";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Engels";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // epText
            // 
            this.epText.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epText.ContainerControl = this;
            // 
            // Oef2_Woordenboek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbEngels);
            this.Controls.Add(this.tbNederlands);
            this.Name = "Oef2_Woordenboek";
            this.Text = "Oef2_Woordenboek";
            this.Load += new System.EventHandler(this.Oef2_Woordenboek_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNederlands;
        private System.Windows.Forms.TextBox tbEngels;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider epText;
    }
}