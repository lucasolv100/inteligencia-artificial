namespace TSP
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.lbDistance = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbEvolucoes = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnExecute = new System.Windows.Forms.Button();
            this.btnPopulationGenerate = new System.Windows.Forms.Button();
            this.gbMutation = new System.Windows.Forms.GroupBox();
            this.rbGenePopulation = new System.Windows.Forms.RadioButton();
            this.rbPopulation = new System.Windows.Forms.RadioButton();
            this.rbNewInd = new System.Windows.Forms.RadioButton();
            this.txtFight = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQtyElitsm = new System.Windows.Forms.MaskedTextBox();
            this.chElitsm = new System.Windows.Forms.CheckBox();
            this.txtEvolution = new System.Windows.Forms.MaskedTextBox();
            this.txtMutationTax = new System.Windows.Forms.MaskedTextBox();
            this.txtCrossOverTax = new System.Windows.Forms.MaskedTextBox();
            this.txtPopulationSize = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbQtyCities = new System.Windows.Forms.Label();
            this.lbDifficulty = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gbMutation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.zedGraphControl1);
            this.panel1.Controls.Add(this.lbDistance);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lbEvolucoes);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnClean);
            this.panel1.Controls.Add(this.btnExecute);
            this.panel1.Controls.Add(this.btnPopulationGenerate);
            this.panel1.Controls.Add(this.gbMutation);
            this.panel1.Controls.Add(this.txtFight);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtQtyElitsm);
            this.panel1.Controls.Add(this.chElitsm);
            this.panel1.Controls.Add(this.txtEvolution);
            this.panel1.Controls.Add(this.txtMutationTax);
            this.panel1.Controls.Add(this.txtCrossOverTax);
            this.panel1.Controls.Add(this.txtPopulationSize);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 575);
            this.panel1.TabIndex = 0;
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(15, 365);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(399, 190);
            this.zedGraphControl1.TabIndex = 21;
            // 
            // lbDistance
            // 
            this.lbDistance.AutoSize = true;
            this.lbDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDistance.Location = new System.Drawing.Point(169, 327);
            this.lbDistance.Name = "lbDistance";
            this.lbDistance.Size = new System.Drawing.Size(30, 24);
            this.lbDistance.TabIndex = 20;
            this.lbDistance.Text = "00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 327);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 24);
            this.label8.TabIndex = 19;
            this.label8.Text = "Menor Distancia:";
            // 
            // lbEvolucoes
            // 
            this.lbEvolucoes.AutoSize = true;
            this.lbEvolucoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEvolucoes.Location = new System.Drawing.Point(117, 303);
            this.lbEvolucoes.Name = "lbEvolucoes";
            this.lbEvolucoes.Size = new System.Drawing.Size(30, 24);
            this.lbEvolucoes.TabIndex = 18;
            this.lbEvolucoes.Text = "00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 24);
            this.label7.TabIndex = 17;
            this.label7.Text = "Evoluções: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "label6";
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClean.Enabled = false;
            this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.Location = new System.Drawing.Point(243, 239);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(171, 61);
            this.btnClean.TabIndex = 15;
            this.btnClean.Text = "Limpar";
            this.btnClean.UseVisualStyleBackColor = false;
            // 
            // btnExecute
            // 
            this.btnExecute.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExecute.Enabled = false;
            this.btnExecute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecute.Location = new System.Drawing.Point(243, 172);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(171, 61);
            this.btnExecute.TabIndex = 14;
            this.btnExecute.Text = "Executar / Continuar";
            this.btnExecute.UseVisualStyleBackColor = false;
            // 
            // btnPopulationGenerate
            // 
            this.btnPopulationGenerate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPopulationGenerate.Enabled = false;
            this.btnPopulationGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPopulationGenerate.Location = new System.Drawing.Point(243, 105);
            this.btnPopulationGenerate.Name = "btnPopulationGenerate";
            this.btnPopulationGenerate.Size = new System.Drawing.Size(171, 61);
            this.btnPopulationGenerate.TabIndex = 13;
            this.btnPopulationGenerate.Text = "Gerar População";
            this.btnPopulationGenerate.UseVisualStyleBackColor = false;
            this.btnPopulationGenerate.Click += new System.EventHandler(this.BtnPopulationGenerate_Click);
            // 
            // gbMutation
            // 
            this.gbMutation.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbMutation.Controls.Add(this.rbGenePopulation);
            this.gbMutation.Controls.Add(this.rbPopulation);
            this.gbMutation.Controls.Add(this.rbNewInd);
            this.gbMutation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMutation.Location = new System.Drawing.Point(15, 145);
            this.gbMutation.Name = "gbMutation";
            this.gbMutation.Size = new System.Drawing.Size(213, 155);
            this.gbMutation.TabIndex = 12;
            this.gbMutation.TabStop = false;
            this.gbMutation.Text = "Mutação";
            // 
            // rbGenePopulation
            // 
            this.rbGenePopulation.AutoSize = true;
            this.rbGenePopulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGenePopulation.Location = new System.Drawing.Point(22, 100);
            this.rbGenePopulation.Name = "rbGenePopulation";
            this.rbGenePopulation.Size = new System.Drawing.Size(154, 24);
            this.rbGenePopulation.TabIndex = 2;
            this.rbGenePopulation.Text = "Genes População";
            this.rbGenePopulation.UseVisualStyleBackColor = true;
            // 
            // rbPopulation
            // 
            this.rbPopulation.AutoSize = true;
            this.rbPopulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPopulation.Location = new System.Drawing.Point(22, 70);
            this.rbPopulation.Name = "rbPopulation";
            this.rbPopulation.Size = new System.Drawing.Size(145, 24);
            this.rbPopulation.TabIndex = 1;
            this.rbPopulation.Text = "População Geral";
            this.rbPopulation.UseVisualStyleBackColor = true;
            // 
            // rbNewInd
            // 
            this.rbNewInd.AutoSize = true;
            this.rbNewInd.Checked = true;
            this.rbNewInd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNewInd.Location = new System.Drawing.Point(22, 40);
            this.rbNewInd.Name = "rbNewInd";
            this.rbNewInd.Size = new System.Drawing.Size(130, 24);
            this.rbNewInd.TabIndex = 0;
            this.rbNewInd.TabStop = true;
            this.rbNewInd.Text = "Novo Individuo";
            this.rbNewInd.UseVisualStyleBackColor = true;
            // 
            // txtFight
            // 
            this.txtFight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFight.Location = new System.Drawing.Point(332, 57);
            this.txtFight.Mask = "0";
            this.txtFight.Name = "txtFight";
            this.txtFight.Size = new System.Drawing.Size(82, 26);
            this.txtFight.TabIndex = 11;
            this.txtFight.Text = "4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(239, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Torneio:";
            // 
            // txtQtyElitsm
            // 
            this.txtQtyElitsm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtyElitsm.Location = new System.Drawing.Point(332, 12);
            this.txtQtyElitsm.Mask = "0";
            this.txtQtyElitsm.Name = "txtQtyElitsm";
            this.txtQtyElitsm.Size = new System.Drawing.Size(82, 26);
            this.txtQtyElitsm.TabIndex = 9;
            this.txtQtyElitsm.Text = "3";
            // 
            // chElitsm
            // 
            this.chElitsm.AutoSize = true;
            this.chElitsm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chElitsm.Location = new System.Drawing.Point(243, 15);
            this.chElitsm.Name = "chElitsm";
            this.chElitsm.Size = new System.Drawing.Size(83, 24);
            this.chElitsm.TabIndex = 8;
            this.chElitsm.Text = "Elitismo";
            this.chElitsm.UseVisualStyleBackColor = true;
            // 
            // txtEvolution
            // 
            this.txtEvolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEvolution.Location = new System.Drawing.Point(146, 102);
            this.txtEvolution.Mask = "00000";
            this.txtEvolution.Name = "txtEvolution";
            this.txtEvolution.Size = new System.Drawing.Size(82, 26);
            this.txtEvolution.TabIndex = 7;
            this.txtEvolution.Text = "100";
            // 
            // txtMutationTax
            // 
            this.txtMutationTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMutationTax.Location = new System.Drawing.Point(146, 70);
            this.txtMutationTax.Mask = "0.000";
            this.txtMutationTax.Name = "txtMutationTax";
            this.txtMutationTax.Size = new System.Drawing.Size(82, 26);
            this.txtMutationTax.TabIndex = 6;
            this.txtMutationTax.Text = "0001";
            // 
            // txtCrossOverTax
            // 
            this.txtCrossOverTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrossOverTax.Location = new System.Drawing.Point(146, 39);
            this.txtCrossOverTax.Mask = "0.000";
            this.txtCrossOverTax.Name = "txtCrossOverTax";
            this.txtCrossOverTax.Size = new System.Drawing.Size(82, 26);
            this.txtCrossOverTax.TabIndex = 5;
            this.txtCrossOverTax.Text = "06";
            // 
            // txtPopulationSize
            // 
            this.txtPopulationSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPopulationSize.Location = new System.Drawing.Point(146, 9);
            this.txtPopulationSize.Mask = "00000";
            this.txtPopulationSize.Name = "txtPopulationSize";
            this.txtPopulationSize.Size = new System.Drawing.Size(82, 26);
            this.txtPopulationSize.TabIndex = 4;
            this.txtPopulationSize.Text = "50";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Evoluções:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tax. Mutação:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tax. Cruzamento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tam. População:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(448, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(180, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Quantidade de Cidades:";
            // 
            // lbQtyCities
            // 
            this.lbQtyCities.AutoSize = true;
            this.lbQtyCities.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQtyCities.Location = new System.Drawing.Point(634, 6);
            this.lbQtyCities.Name = "lbQtyCities";
            this.lbQtyCities.Size = new System.Drawing.Size(19, 20);
            this.lbQtyCities.TabIndex = 23;
            this.lbQtyCities.Text = "--";
            // 
            // lbDifficulty
            // 
            this.lbDifficulty.AutoSize = true;
            this.lbDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDifficulty.Location = new System.Drawing.Point(634, 26);
            this.lbDifficulty.Name = "lbDifficulty";
            this.lbDifficulty.Size = new System.Drawing.Size(18, 20);
            this.lbDifficulty.TabIndex = 25;
            this.lbDifficulty.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(448, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "Complexidade:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1033, 564);
            this.Controls.Add(this.lbDifficulty);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbQtyCities);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbMutation.ResumeLayout(false);
            this.gbMutation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox txtEvolution;
        private System.Windows.Forms.MaskedTextBox txtMutationTax;
        private System.Windows.Forms.MaskedTextBox txtCrossOverTax;
        private System.Windows.Forms.MaskedTextBox txtPopulationSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Label lbDistance;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbEvolucoes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Button btnPopulationGenerate;
        private System.Windows.Forms.GroupBox gbMutation;
        private System.Windows.Forms.RadioButton rbGenePopulation;
        private System.Windows.Forms.RadioButton rbPopulation;
        private System.Windows.Forms.RadioButton rbNewInd;
        private System.Windows.Forms.MaskedTextBox txtFight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtQtyElitsm;
        private System.Windows.Forms.CheckBox chElitsm;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbQtyCities;
        private System.Windows.Forms.Label lbDifficulty;
        private System.Windows.Forms.Label label11;
    }
}

