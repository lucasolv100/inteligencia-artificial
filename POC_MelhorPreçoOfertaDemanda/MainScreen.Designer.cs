namespace AlgoritimoGenetico
{
    partial class MainScreen
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
            this.zedPopulation = new ZedGraph.ZedGraphControl();
            this.zedPopulationAverage = new ZedGraph.ZedGraphControl();
            this.txtBestIndividuals = new System.Windows.Forms.RichTextBox();
            this.txtWorstIndividuals = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCrossOverMask = new System.Windows.Forms.MaskedTextBox();
            this.txtEvolution = new System.Windows.Forms.MaskedTextBox();
            this.btnPopulationGenerate = new System.Windows.Forms.Button();
            this.btnAGBegin = new System.Windows.Forms.Button();
            this.txtPriceOffer = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPopulationSize = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRange = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // zedPopulation
            // 
            this.zedPopulation.Location = new System.Drawing.Point(11, 115);
            this.zedPopulation.Name = "zedPopulation";
            this.zedPopulation.ScrollGrace = 0D;
            this.zedPopulation.ScrollMaxX = 0D;
            this.zedPopulation.ScrollMaxY = 0D;
            this.zedPopulation.ScrollMaxY2 = 0D;
            this.zedPopulation.ScrollMinX = 0D;
            this.zedPopulation.ScrollMinY = 0D;
            this.zedPopulation.ScrollMinY2 = 0D;
            this.zedPopulation.Size = new System.Drawing.Size(483, 348);
            this.zedPopulation.TabIndex = 0;
            // 
            // zedPopulationAverage
            // 
            this.zedPopulationAverage.Location = new System.Drawing.Point(500, 115);
            this.zedPopulationAverage.Name = "zedPopulationAverage";
            this.zedPopulationAverage.ScrollGrace = 0D;
            this.zedPopulationAverage.ScrollMaxX = 0D;
            this.zedPopulationAverage.ScrollMaxY = 0D;
            this.zedPopulationAverage.ScrollMaxY2 = 0D;
            this.zedPopulationAverage.ScrollMinX = 0D;
            this.zedPopulationAverage.ScrollMinY = 0D;
            this.zedPopulationAverage.ScrollMinY2 = 0D;
            this.zedPopulationAverage.Size = new System.Drawing.Size(482, 348);
            this.zedPopulationAverage.TabIndex = 1;
            // 
            // txtBestIndividuals
            // 
            this.txtBestIndividuals.Location = new System.Drawing.Point(12, 490);
            this.txtBestIndividuals.Name = "txtBestIndividuals";
            this.txtBestIndividuals.Size = new System.Drawing.Size(482, 96);
            this.txtBestIndividuals.TabIndex = 2;
            this.txtBestIndividuals.Text = "";
            // 
            // txtWorstIndividuals
            // 
            this.txtWorstIndividuals.Location = new System.Drawing.Point(500, 490);
            this.txtWorstIndividuals.Name = "txtWorstIndividuals";
            this.txtWorstIndividuals.Size = new System.Drawing.Size(482, 96);
            this.txtWorstIndividuals.TabIndex = 3;
            this.txtWorstIndividuals.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 470);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Melhores individuos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(497, 474);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Piores individuos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Taxa Cross Over";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Evoluções";
            // 
            // txtCrossOverMask
            // 
            this.txtCrossOverMask.Location = new System.Drawing.Point(104, 6);
            this.txtCrossOverMask.Mask = "0.00";
            this.txtCrossOverMask.Name = "txtCrossOverMask";
            this.txtCrossOverMask.Size = new System.Drawing.Size(44, 20);
            this.txtCrossOverMask.TabIndex = 12;
            this.txtCrossOverMask.Text = "08";
            // 
            // txtEvolution
            // 
            this.txtEvolution.Location = new System.Drawing.Point(104, 39);
            this.txtEvolution.Mask = "0000000";
            this.txtEvolution.Name = "txtEvolution";
            this.txtEvolution.Size = new System.Drawing.Size(44, 20);
            this.txtEvolution.TabIndex = 14;
            this.txtEvolution.Text = "5";
            // 
            // btnPopulationGenerate
            // 
            this.btnPopulationGenerate.Location = new System.Drawing.Point(169, 4);
            this.btnPopulationGenerate.Name = "btnPopulationGenerate";
            this.btnPopulationGenerate.Size = new System.Drawing.Size(165, 48);
            this.btnPopulationGenerate.TabIndex = 15;
            this.btnPopulationGenerate.Text = "Gerar População";
            this.btnPopulationGenerate.UseVisualStyleBackColor = true;
            this.btnPopulationGenerate.Click += new System.EventHandler(this.BtnPopulationGenerate_Click);
            // 
            // btnAGBegin
            // 
            this.btnAGBegin.Location = new System.Drawing.Point(169, 58);
            this.btnAGBegin.Name = "btnAGBegin";
            this.btnAGBegin.Size = new System.Drawing.Size(165, 33);
            this.btnAGBegin.TabIndex = 16;
            this.btnAGBegin.Text = "Iniciar Algoritmo Genético";
            this.btnAGBegin.UseVisualStyleBackColor = true;
            this.btnAGBegin.Click += new System.EventHandler(this.BtnAGBegin_Click);
            // 
            // txtPriceOffer
            // 
            this.txtPriceOffer.Location = new System.Drawing.Point(582, 10);
            this.txtPriceOffer.Mask = "0000000";
            this.txtPriceOffer.Name = "txtPriceOffer";
            this.txtPriceOffer.Size = new System.Drawing.Size(75, 20);
            this.txtPriceOffer.TabIndex = 18;
            this.txtPriceOffer.Text = "2000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Preço da Oferta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(404, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Area de pesquisa (%)";
            // 
            // txtPopulationSize
            // 
            this.txtPopulationSize.Location = new System.Drawing.Point(584, 65);
            this.txtPopulationSize.Mask = "0000000";
            this.txtPopulationSize.Name = "txtPopulationSize";
            this.txtPopulationSize.Size = new System.Drawing.Size(73, 20);
            this.txtPopulationSize.TabIndex = 22;
            this.txtPopulationSize.Text = "3000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(404, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Qtd. Demandas Não Match (Min 20)";
            // 
            // txtRange
            // 
            this.txtRange.Location = new System.Drawing.Point(613, 39);
            this.txtRange.Mask = "0.00";
            this.txtRange.Name = "txtRange";
            this.txtRange.Size = new System.Drawing.Size(44, 20);
            this.txtRange.TabIndex = 23;
            this.txtRange.Text = "005";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 598);
            this.Controls.Add(this.txtRange);
            this.Controls.Add(this.txtPopulationSize);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPriceOffer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAGBegin);
            this.Controls.Add(this.btnPopulationGenerate);
            this.Controls.Add(this.txtEvolution);
            this.Controls.Add(this.txtCrossOverMask);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtWorstIndividuals);
            this.Controls.Add(this.txtBestIndividuals);
            this.Controls.Add(this.zedPopulationAverage);
            this.Controls.Add(this.zedPopulation);
            this.Name = "MainScreen";
            this.Text = "MainScreen";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl zedPopulation;
        private ZedGraph.ZedGraphControl zedPopulationAverage;
        private System.Windows.Forms.RichTextBox txtBestIndividuals;
        private System.Windows.Forms.RichTextBox txtWorstIndividuals;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtCrossOverMask;
        private System.Windows.Forms.MaskedTextBox txtEvolution;
        private System.Windows.Forms.Button btnPopulationGenerate;
        private System.Windows.Forms.Button btnAGBegin;
        private System.Windows.Forms.MaskedTextBox txtPriceOffer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtPopulationSize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtRange;
    }
}