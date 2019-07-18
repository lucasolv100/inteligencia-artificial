namespace AlgoritimoGenetico
{
    partial class Form1
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
            this.txtIndividual = new System.Windows.Forms.RichTextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtPopulation = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtIndividual
            // 
            this.txtIndividual.Location = new System.Drawing.Point(12, 12);
            this.txtIndividual.Name = "txtIndividual";
            this.txtIndividual.Size = new System.Drawing.Size(1174, 32);
            this.txtIndividual.TabIndex = 0;
            this.txtIndividual.Text = "";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(1080, 435);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(106, 26);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Gerar";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // txtPopulation
            // 
            this.txtPopulation.Location = new System.Drawing.Point(12, 50);
            this.txtPopulation.Name = "txtPopulation";
            this.txtPopulation.Size = new System.Drawing.Size(1174, 379);
            this.txtPopulation.TabIndex = 2;
            this.txtPopulation.Text = "";
            this.txtPopulation.TextChanged += new System.EventHandler(this.RichTextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 473);
            this.Controls.Add(this.txtPopulation);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtIndividual);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtIndividual;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.RichTextBox txtPopulation;
    }
}

