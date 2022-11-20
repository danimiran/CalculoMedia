namespace CalculoMedia
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Exercicio2Nota = new System.Windows.Forms.TextBox();
            this.Exercicio1Nota = new System.Windows.Forms.TextBox();
            this.EnadeNota = new System.Windows.Forms.TextBox();
            this.ProvaNota = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnCalcMedia = new System.Windows.Forms.Button();
            this.BtnLimpaForm = new System.Windows.Forms.Button();
            this.PorfolioNota = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtSituacao = new System.Windows.Forms.Label();
            this.TxtMedia = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // Exercicio2Nota
            // 
            resources.ApplyResources(this.Exercicio2Nota, "Exercicio2Nota");
            this.Exercicio2Nota.Name = "Exercicio2Nota";
            // 
            // Exercicio1Nota
            // 
            resources.ApplyResources(this.Exercicio1Nota, "Exercicio1Nota");
            this.Exercicio1Nota.Name = "Exercicio1Nota";
            // 
            // EnadeNota
            // 
            resources.ApplyResources(this.EnadeNota, "EnadeNota");
            this.EnadeNota.Name = "EnadeNota";
            // 
            // ProvaNota
            // 
            resources.ApplyResources(this.ProvaNota, "ProvaNota");
            this.ProvaNota.Name = "ProvaNota";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Name = "label6";
            // 
            // BtnCalcMedia
            // 
            resources.ApplyResources(this.BtnCalcMedia, "BtnCalcMedia");
            this.BtnCalcMedia.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnCalcMedia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnCalcMedia.Name = "BtnCalcMedia";
            this.BtnCalcMedia.UseVisualStyleBackColor = false;
            this.BtnCalcMedia.Click += new System.EventHandler(this.BtnCalcMedia_Click);
            // 
            // BtnLimpaForm
            // 
            resources.ApplyResources(this.BtnLimpaForm, "BtnLimpaForm");
            this.BtnLimpaForm.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnLimpaForm.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnLimpaForm.FlatAppearance.BorderSize = 2;
            this.BtnLimpaForm.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BtnLimpaForm.Name = "BtnLimpaForm";
            this.BtnLimpaForm.UseVisualStyleBackColor = false;
            this.BtnLimpaForm.Click += new System.EventHandler(this.BtnLimpaForm_Click);
            // 
            // PorfolioNota
            // 
            resources.ApplyResources(this.PorfolioNota, "PorfolioNota");
            this.PorfolioNota.Name = "PorfolioNota";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // TxtSituacao
            // 
            resources.ApplyResources(this.TxtSituacao, "TxtSituacao");
            this.TxtSituacao.Name = "TxtSituacao";
            // 
            // TxtMedia
            // 
            resources.ApplyResources(this.TxtMedia, "TxtMedia");
            this.TxtMedia.Name = "TxtMedia";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtMedia);
            this.Controls.Add(this.TxtSituacao);
            this.Controls.Add(this.PorfolioNota);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnLimpaForm);
            this.Controls.Add(this.BtnCalcMedia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ProvaNota);
            this.Controls.Add(this.EnadeNota);
            this.Controls.Add(this.Exercicio1Nota);
            this.Controls.Add(this.Exercicio2Nota);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private TextBox Exercicio2Nota;
        private TextBox Exercicio1Nota;
        private TextBox EnadeNota;
        private TextBox ProvaNota;
        private Label label6;
        private Button BtnCalcMedia;
        private Button BtnLimpaForm;
        private TextBox PorfolioNota;
        private Label label8;
        private Label TxtSituacao;
        private Label TxtMedia;
        private Label label4;
        private Label label7;
    }
}