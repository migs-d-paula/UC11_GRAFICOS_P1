using System;

namespace UC11_GRAFICOS
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxNOME = new System.Windows.Forms.TextBox();
            this.labelNOME = new System.Windows.Forms.Label();
            this.buttonCALCULAR = new System.Windows.Forms.Button();
            this.labelNUMERO1 = new System.Windows.Forms.Label();
            this.labelNUMERO2 = new System.Windows.Forms.Label();
            this.labelPLUS = new System.Windows.Forms.Label();
            this.labelCALCULADORA = new System.Windows.Forms.Label();
            this.textBoxNUMERO = new System.Windows.Forms.TextBox();
            this.textBoxNUMERO2 = new System.Windows.Forms.TextBox();
            this.buttonCADASTRAR = new System.Windows.Forms.Button();
            this.textBoxALTURA = new System.Windows.Forms.TextBox();
            this.textBoxPESO = new System.Windows.Forms.TextBox();
            this.labelALTURA = new System.Windows.Forms.Label();
            this.labelPESO = new System.Windows.Forms.Label();
            this.buttonIMC = new System.Windows.Forms.Button();
            this.labelCADASTRO = new System.Windows.Forms.Label();
            this.labelIINDICEMC = new System.Windows.Forms.Label();
            this.labelIMC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUSUARIO = new System.Windows.Forms.TextBox();
            this.textBoxSENHA = new System.Windows.Forms.TextBox();
            this.buttonENTRAR = new System.Windows.Forms.Button();
            this.buttonLIMPAR = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPASSWORD = new System.Windows.Forms.Label();
            this.textBoxPASSWORD = new System.Windows.Forms.TextBox();
            this.labelLOGIN = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNOME
            // 
            this.textBoxNOME.Location = new System.Drawing.Point(172, 79);
            this.textBoxNOME.Name = "textBoxNOME";
            this.textBoxNOME.Size = new System.Drawing.Size(279, 20);
            this.textBoxNOME.TabIndex = 0;
            // 
            // labelNOME
            // 
            this.labelNOME.AutoSize = true;
            this.labelNOME.Location = new System.Drawing.Point(99, 86);
            this.labelNOME.Name = "labelNOME";
            this.labelNOME.Size = new System.Drawing.Size(45, 13);
            this.labelNOME.TabIndex = 4;
            this.labelNOME.Text = "NOME :";
            // 
            // buttonCALCULAR
            // 
            this.buttonCALCULAR.Location = new System.Drawing.Point(761, 217);
            this.buttonCALCULAR.Name = "buttonCALCULAR";
            this.buttonCALCULAR.Size = new System.Drawing.Size(75, 23);
            this.buttonCALCULAR.TabIndex = 7;
            this.buttonCALCULAR.Text = "CALCULAR";
            this.buttonCALCULAR.UseVisualStyleBackColor = true;
            this.buttonCALCULAR.Click += new System.EventHandler(this.buttonCALCULAR_Click);
            // 
            // labelNUMERO1
            // 
            this.labelNUMERO1.AutoSize = true;
            this.labelNUMERO1.Location = new System.Drawing.Point(641, 86);
            this.labelNUMERO1.Name = "labelNUMERO1";
            this.labelNUMERO1.Size = new System.Drawing.Size(61, 13);
            this.labelNUMERO1.TabIndex = 8;
            this.labelNUMERO1.Text = "NÚMERO :";
            // 
            // labelNUMERO2
            // 
            this.labelNUMERO2.AutoSize = true;
            this.labelNUMERO2.Location = new System.Drawing.Point(641, 173);
            this.labelNUMERO2.Name = "labelNUMERO2";
            this.labelNUMERO2.Size = new System.Drawing.Size(61, 13);
            this.labelNUMERO2.TabIndex = 9;
            this.labelNUMERO2.Text = "NÚMERO :";
            // 
            // labelPLUS
            // 
            this.labelPLUS.AutoSize = true;
            this.labelPLUS.Location = new System.Drawing.Point(799, 128);
            this.labelPLUS.Name = "labelPLUS";
            this.labelPLUS.Size = new System.Drawing.Size(13, 13);
            this.labelPLUS.TabIndex = 10;
            this.labelPLUS.Text = "+";
            // 
            // labelCALCULADORA
            // 
            this.labelCALCULADORA.AutoSize = true;
            this.labelCALCULADORA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCALCULADORA.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelCALCULADORA.Location = new System.Drawing.Point(723, 31);
            this.labelCALCULADORA.Name = "labelCALCULADORA";
            this.labelCALCULADORA.Size = new System.Drawing.Size(174, 25);
            this.labelCALCULADORA.TabIndex = 11;
            this.labelCALCULADORA.Text = "CALCULADORA";
            // 
            // textBoxNUMERO
            // 
            this.textBoxNUMERO.Location = new System.Drawing.Point(708, 79);
            this.textBoxNUMERO.Name = "textBoxNUMERO";
            this.textBoxNUMERO.Size = new System.Drawing.Size(206, 20);
            this.textBoxNUMERO.TabIndex = 12;
            // 
            // textBoxNUMERO2
            // 
            this.textBoxNUMERO2.Location = new System.Drawing.Point(708, 166);
            this.textBoxNUMERO2.Name = "textBoxNUMERO2";
            this.textBoxNUMERO2.Size = new System.Drawing.Size(206, 20);
            this.textBoxNUMERO2.TabIndex = 13;
            // 
            // buttonCADASTRAR
            // 
            this.buttonCADASTRAR.Location = new System.Drawing.Point(268, 217);
            this.buttonCADASTRAR.Name = "buttonCADASTRAR";
            this.buttonCADASTRAR.Size = new System.Drawing.Size(85, 23);
            this.buttonCADASTRAR.TabIndex = 14;
            this.buttonCADASTRAR.Text = "CADASTRAR";
            this.buttonCADASTRAR.UseVisualStyleBackColor = true;
            this.buttonCADASTRAR.Click += new System.EventHandler(this.buttonCADASTRAR_Click_1);
            // 
            // textBoxALTURA
            // 
            this.textBoxALTURA.Location = new System.Drawing.Point(245, 433);
            this.textBoxALTURA.Name = "textBoxALTURA";
            this.textBoxALTURA.Size = new System.Drawing.Size(128, 20);
            this.textBoxALTURA.TabIndex = 15;
            // 
            // textBoxPESO
            // 
            this.textBoxPESO.Location = new System.Drawing.Point(245, 500);
            this.textBoxPESO.Name = "textBoxPESO";
            this.textBoxPESO.Size = new System.Drawing.Size(128, 20);
            this.textBoxPESO.TabIndex = 16;
            // 
            // labelALTURA
            // 
            this.labelALTURA.AutoSize = true;
            this.labelALTURA.Location = new System.Drawing.Point(172, 440);
            this.labelALTURA.Name = "labelALTURA";
            this.labelALTURA.Size = new System.Drawing.Size(56, 13);
            this.labelALTURA.TabIndex = 17;
            this.labelALTURA.Text = "ALTURA :";
            // 
            // labelPESO
            // 
            this.labelPESO.AutoSize = true;
            this.labelPESO.Location = new System.Drawing.Point(175, 506);
            this.labelPESO.Name = "labelPESO";
            this.labelPESO.Size = new System.Drawing.Size(42, 13);
            this.labelPESO.TabIndex = 18;
            this.labelPESO.Text = "PESO :";
            // 
            // buttonIMC
            // 
            this.buttonIMC.Location = new System.Drawing.Point(268, 551);
            this.buttonIMC.Name = "buttonIMC";
            this.buttonIMC.Size = new System.Drawing.Size(75, 23);
            this.buttonIMC.TabIndex = 19;
            this.buttonIMC.Text = "CALCULAR";
            this.buttonIMC.UseVisualStyleBackColor = true;
            this.buttonIMC.Click += new System.EventHandler(this.buttonIMC_Click);
            // 
            // labelCADASTRO
            // 
            this.labelCADASTRO.AutoSize = true;
            this.labelCADASTRO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCADASTRO.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelCADASTRO.Location = new System.Drawing.Point(240, 31);
            this.labelCADASTRO.Name = "labelCADASTRO";
            this.labelCADASTRO.Size = new System.Drawing.Size(133, 25);
            this.labelCADASTRO.TabIndex = 20;
            this.labelCADASTRO.Text = "CADASTRO";
            // 
            // labelIINDICEMC
            // 
            this.labelIINDICEMC.AutoSize = true;
            this.labelIINDICEMC.BackColor = System.Drawing.SystemColors.Control;
            this.labelIINDICEMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIINDICEMC.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelIINDICEMC.Location = new System.Drawing.Point(285, 375);
            this.labelIINDICEMC.Name = "labelIINDICEMC";
            this.labelIINDICEMC.Size = new System.Drawing.Size(49, 25);
            this.labelIINDICEMC.TabIndex = 21;
            this.labelIINDICEMC.Text = "IMC";
            // 
            // labelIMC
            // 
            this.labelIMC.AutoSize = true;
            this.labelIMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIMC.Location = new System.Drawing.Point(267, 595);
            this.labelIMC.Name = "labelIMC";
            this.labelIMC.Size = new System.Drawing.Size(52, 17);
            this.labelIMC.TabIndex = 22;
            this.labelIMC.Text = "label1";
            this.labelIMC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(631, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "USUÁRIO :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(647, 506);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "SENHA :";
            // 
            // textBoxUSUARIO
            // 
            this.textBoxUSUARIO.Location = new System.Drawing.Point(699, 432);
            this.textBoxUSUARIO.Name = "textBoxUSUARIO";
            this.textBoxUSUARIO.Size = new System.Drawing.Size(215, 20);
            this.textBoxUSUARIO.TabIndex = 25;
            // 
            // textBoxSENHA
            // 
            this.textBoxSENHA.Location = new System.Drawing.Point(699, 499);
            this.textBoxSENHA.Name = "textBoxSENHA";
            this.textBoxSENHA.PasswordChar = '*';
            this.textBoxSENHA.Size = new System.Drawing.Size(215, 20);
            this.textBoxSENHA.TabIndex = 26;
            // 
            // buttonENTRAR
            // 
            this.buttonENTRAR.Location = new System.Drawing.Point(699, 550);
            this.buttonENTRAR.Name = "buttonENTRAR";
            this.buttonENTRAR.Size = new System.Drawing.Size(75, 23);
            this.buttonENTRAR.TabIndex = 27;
            this.buttonENTRAR.Text = "ENTRAR";
            this.buttonENTRAR.UseVisualStyleBackColor = true;
            this.buttonENTRAR.Click += new System.EventHandler(this.buttonENTRAR_Click);
            // 
            // buttonLIMPAR
            // 
            this.buttonLIMPAR.Location = new System.Drawing.Point(822, 549);
            this.buttonLIMPAR.Name = "buttonLIMPAR";
            this.buttonLIMPAR.Size = new System.Drawing.Size(75, 23);
            this.buttonLIMPAR.TabIndex = 28;
            this.buttonLIMPAR.Text = "LIMPAR";
            this.buttonLIMPAR.UseVisualStyleBackColor = true;
            this.buttonLIMPAR.Click += new System.EventHandler(this.buttonLIMPAR_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(758, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "LOGIN";
            // 
            // labelPASSWORD
            // 
            this.labelPASSWORD.AutoSize = true;
            this.labelPASSWORD.Location = new System.Drawing.Point(94, 176);
            this.labelPASSWORD.Name = "labelPASSWORD";
            this.labelPASSWORD.Size = new System.Drawing.Size(50, 13);
            this.labelPASSWORD.TabIndex = 30;
            this.labelPASSWORD.Text = "SENHA :";
            // 
            // textBoxPASSWORD
            // 
            this.textBoxPASSWORD.Location = new System.Drawing.Point(172, 173);
            this.textBoxPASSWORD.Name = "textBoxPASSWORD";
            this.textBoxPASSWORD.PasswordChar = '*';
            this.textBoxPASSWORD.Size = new System.Drawing.Size(278, 20);
            this.textBoxPASSWORD.TabIndex = 31;
            // 
            // labelLOGIN
            // 
            this.labelLOGIN.AutoSize = true;
            this.labelLOGIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLOGIN.Location = new System.Drawing.Point(702, 607);
            this.labelLOGIN.Name = "labelLOGIN";
            this.labelLOGIN.Size = new System.Drawing.Size(106, 17);
            this.labelLOGIN.TabIndex = 32;
            this.labelLOGIN.Text = "respostalogin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 689);
            this.Controls.Add(this.labelLOGIN);
            this.Controls.Add(this.textBoxPASSWORD);
            this.Controls.Add(this.labelPASSWORD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonLIMPAR);
            this.Controls.Add(this.buttonENTRAR);
            this.Controls.Add(this.textBoxSENHA);
            this.Controls.Add(this.textBoxUSUARIO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelIMC);
            this.Controls.Add(this.labelIINDICEMC);
            this.Controls.Add(this.labelCADASTRO);
            this.Controls.Add(this.buttonIMC);
            this.Controls.Add(this.labelPESO);
            this.Controls.Add(this.labelALTURA);
            this.Controls.Add(this.textBoxPESO);
            this.Controls.Add(this.textBoxALTURA);
            this.Controls.Add(this.buttonCADASTRAR);
            this.Controls.Add(this.textBoxNUMERO2);
            this.Controls.Add(this.textBoxNUMERO);
            this.Controls.Add(this.labelCALCULADORA);
            this.Controls.Add(this.labelPLUS);
            this.Controls.Add(this.labelNUMERO2);
            this.Controls.Add(this.labelNUMERO1);
            this.Controls.Add(this.buttonCALCULAR);
            this.Controls.Add(this.labelNOME);
            this.Controls.Add(this.textBoxNOME);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBoxNUMERO_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void buttonCADASTRAR_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNOME;
        private System.Windows.Forms.Label labelNOME;
        private System.Windows.Forms.Button buttonCALCULAR;
        private System.Windows.Forms.Label labelNUMERO1;
        private System.Windows.Forms.Label labelNUMERO2;
        private System.Windows.Forms.Label labelPLUS;
        private System.Windows.Forms.Label labelCALCULADORA;
        private System.Windows.Forms.TextBox textBoxNUMERO;
        private System.Windows.Forms.TextBox textBoxNUMERO2;
        private System.Windows.Forms.Button buttonCADASTRAR;
        private System.Windows.Forms.TextBox textBoxALTURA;
        private System.Windows.Forms.TextBox textBoxPESO;
        private System.Windows.Forms.Label labelALTURA;
        private System.Windows.Forms.Label labelPESO;
        private System.Windows.Forms.Button buttonIMC;
        private System.Windows.Forms.Label labelCADASTRO;
        private System.Windows.Forms.Label labelIINDICEMC;
        private System.Windows.Forms.Label labelIMC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUSUARIO;
        private System.Windows.Forms.TextBox textBoxSENHA;
        private System.Windows.Forms.Button buttonENTRAR;
        private System.Windows.Forms.Button buttonLIMPAR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPASSWORD;
        private System.Windows.Forms.TextBox textBoxPASSWORD;
        private System.Windows.Forms.Label labelLOGIN;
    }
}

