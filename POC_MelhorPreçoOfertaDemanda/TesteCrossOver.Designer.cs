namespace AlgoritimoGenetico
{
    partial class TesteCrossOver
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
            this.txtInd1 = new System.Windows.Forms.TextBox();
            this.txtInd2 = new System.Windows.Forms.TextBox();
            this.txtIndCross1 = new System.Windows.Forms.TextBox();
            this.txtIndCross2 = new System.Windows.Forms.TextBox();
            this.btnCrossOver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPopulation = new System.Windows.Forms.RichTextBox();
            this.lbMedia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInd1
            // 
            this.txtInd1.Location = new System.Drawing.Point(12, 40);
            this.txtInd1.Name = "txtInd1";
            this.txtInd1.Size = new System.Drawing.Size(737, 20);
            this.txtInd1.TabIndex = 0;
            // 
            // txtInd2
            // 
            this.txtInd2.Location = new System.Drawing.Point(12, 87);
            this.txtInd2.Name = "txtInd2";
            this.txtInd2.Size = new System.Drawing.Size(737, 20);
            this.txtInd2.TabIndex = 1;
            // 
            // txtIndCross1
            // 
            this.txtIndCross1.Location = new System.Drawing.Point(12, 153);
            this.txtIndCross1.Name = "txtIndCross1";
            this.txtIndCross1.Size = new System.Drawing.Size(737, 20);
            this.txtIndCross1.TabIndex = 2;
            // 
            // txtIndCross2
            // 
            this.txtIndCross2.Location = new System.Drawing.Point(12, 192);
            this.txtIndCross2.Name = "txtIndCross2";
            this.txtIndCross2.Size = new System.Drawing.Size(737, 20);
            this.txtIndCross2.TabIndex = 3;
            // 
            // btnCrossOver
            // 
            this.btnCrossOver.Location = new System.Drawing.Point(12, 476);
            this.btnCrossOver.Name = "btnCrossOver";
            this.btnCrossOver.Size = new System.Drawing.Size(148, 38);
            this.btnCrossOver.TabIndex = 4;
            this.btnCrossOver.Text = "Gerar Cross Over";
            this.btnCrossOver.UseVisualStyleBackColor = true;
            this.btnCrossOver.Click += new System.EventHandler(this.BtnCrossOver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Individuo 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Individuo 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cross Over 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cross Over 2";
            // 
            // txtPopulation
            // 
            this.txtPopulation.Location = new System.Drawing.Point(12, 236);
            this.txtPopulation.Name = "txtPopulation";
            this.txtPopulation.Size = new System.Drawing.Size(1135, 225);
            this.txtPopulation.TabIndex = 9;
            this.txtPopulation.Text = "";
            // 
            // lbMedia
            // 
            this.lbMedia.AutoSize = true;
            this.lbMedia.Location = new System.Drawing.Point(197, 486);
            this.lbMedia.Name = "lbMedia";
            this.lbMedia.Size = new System.Drawing.Size(96, 13);
            this.lbMedia.TabIndex = 10;
            this.lbMedia.Text = "Média População: ";
            // 
            // TesteCrossOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 526);
            this.Controls.Add(this.lbMedia);
            this.Controls.Add(this.txtPopulation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCrossOver);
            this.Controls.Add(this.txtIndCross2);
            this.Controls.Add(this.txtIndCross1);
            this.Controls.Add(this.txtInd2);
            this.Controls.Add(this.txtInd1);
            this.Name = "TesteCrossOver";
            this.Text = "TesteCrossOver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInd1;
        private System.Windows.Forms.TextBox txtInd2;
        private System.Windows.Forms.TextBox txtIndCross1;
        private System.Windows.Forms.TextBox txtIndCross2;
        private System.Windows.Forms.Button btnCrossOver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtPopulation;
        private System.Windows.Forms.Label lbMedia;
    }
}