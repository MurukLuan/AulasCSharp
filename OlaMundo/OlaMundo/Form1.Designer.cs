<<<<<<< HEAD
﻿using System;
namespace OlaMundo
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tempo = new System.Windows.Forms.Label();
            this.somarEsquerda = new System.Windows.Forms.Label();
            this.somarDireita = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.resSomar = new System.Windows.Forms.NumericUpDown();
            this.resDiv = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.multDireita = new System.Windows.Forms.Label();
            this.multEsquerda = new System.Windows.Forms.Label();
            this.resMult = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.divDireita = new System.Windows.Forms.Label();
            this.divEsquerda = new System.Windows.Forms.Label();
            this.resSub = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.subDireita = new System.Windows.Forms.Label();
            this.subEsquerda = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.resSomar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resDiv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resMult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resSub)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tempo restante";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tempo
            // 
            this.tempo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tempo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempo.Location = new System.Drawing.Point(511, 21);
            this.tempo.Name = "tempo";
            this.tempo.Size = new System.Drawing.Size(179, 37);
            this.tempo.TabIndex = 1;
            this.tempo.Text = "tempo";
            this.tempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // somarEsquerda
            // 
            this.somarEsquerda.AutoSize = true;
            this.somarEsquerda.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.somarEsquerda.Location = new System.Drawing.Point(136, 93);
            this.somarEsquerda.Name = "somarEsquerda";
            this.somarEsquerda.Size = new System.Drawing.Size(89, 36);
            this.somarEsquerda.TabIndex = 2;
            this.somarEsquerda.Text = "num1";
            // 
            // somarDireita
            // 
            this.somarDireita.AutoSize = true;
            this.somarDireita.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.somarDireita.Location = new System.Drawing.Point(327, 93);
            this.somarDireita.Name = "somarDireita";
            this.somarDireita.Size = new System.Drawing.Size(89, 36);
            this.somarDireita.TabIndex = 3;
            this.somarDireita.Text = "num2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(259, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 36);
            this.label5.TabIndex = 4;
            this.label5.Text = "+";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(429, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 36);
            this.label6.TabIndex = 5;
            this.label6.Text = "=";
            // 
            // resSomar
            // 
            this.resSomar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resSomar.Location = new System.Drawing.Point(530, 93);
            this.resSomar.Name = "resSomar";
            this.resSomar.Size = new System.Drawing.Size(136, 38);
            this.resSomar.TabIndex = 6;
            // 
            // resDiv
            // 
            this.resDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resDiv.Location = new System.Drawing.Point(530, 318);
            this.resDiv.Name = "resDiv";
            this.resDiv.Size = new System.Drawing.Size(136, 38);
            this.resDiv.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(427, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 36);
            this.label7.TabIndex = 10;
            this.label7.Text = "=";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(259, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 36);
            this.label8.TabIndex = 9;
            this.label8.Text = "*";
            // 
            // multDireita
            // 
            this.multDireita.AutoSize = true;
            this.multDireita.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multDireita.Location = new System.Drawing.Point(325, 180);
            this.multDireita.Name = "multDireita";
            this.multDireita.Size = new System.Drawing.Size(89, 36);
            this.multDireita.TabIndex = 8;
            this.multDireita.Text = "num2";
            // 
            // multEsquerda
            // 
            this.multEsquerda.AutoSize = true;
            this.multEsquerda.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multEsquerda.Location = new System.Drawing.Point(134, 180);
            this.multEsquerda.Name = "multEsquerda";
            this.multEsquerda.Size = new System.Drawing.Size(89, 36);
            this.multEsquerda.TabIndex = 7;
            this.multEsquerda.Text = "num1";
            // 
            // resMult
            // 
            this.resMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resMult.Location = new System.Drawing.Point(530, 178);
            this.resMult.Name = "resMult";
            this.resMult.Size = new System.Drawing.Size(136, 38);
            this.resMult.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(429, 326);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 36);
            this.label11.TabIndex = 15;
            this.label11.Text = "=";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(259, 326);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 36);
            this.label12.TabIndex = 14;
            this.label12.Text = "/";
            // 
            // divDireita
            // 
            this.divDireita.AutoSize = true;
            this.divDireita.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divDireita.Location = new System.Drawing.Point(327, 326);
            this.divDireita.Name = "divDireita";
            this.divDireita.Size = new System.Drawing.Size(89, 36);
            this.divDireita.TabIndex = 13;
            this.divDireita.Text = "num2";
            // 
            // divEsquerda
            // 
            this.divEsquerda.AutoSize = true;
            this.divEsquerda.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divEsquerda.Location = new System.Drawing.Point(136, 326);
            this.divEsquerda.Name = "divEsquerda";
            this.divEsquerda.Size = new System.Drawing.Size(89, 36);
            this.divEsquerda.TabIndex = 12;
            this.divEsquerda.Text = "num1";
            // 
            // resSub
            // 
            this.resSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resSub.Location = new System.Drawing.Point(530, 253);
            this.resSub.Name = "resSub";
            this.resSub.Size = new System.Drawing.Size(136, 38);
            this.resSub.TabIndex = 21;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(429, 253);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 36);
            this.label15.TabIndex = 20;
            this.label15.Text = "=";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(259, 253);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(25, 36);
            this.label16.TabIndex = 19;
            this.label16.Text = "-";
            // 
            // subDireita
            // 
            this.subDireita.AutoSize = true;
            this.subDireita.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subDireita.Location = new System.Drawing.Point(327, 253);
            this.subDireita.Name = "subDireita";
            this.subDireita.Size = new System.Drawing.Size(89, 36);
            this.subDireita.TabIndex = 18;
            this.subDireita.Text = "num2";
            // 
            // subEsquerda
            // 
            this.subEsquerda.AutoSize = true;
            this.subEsquerda.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subEsquerda.Location = new System.Drawing.Point(136, 253);
            this.subEsquerda.Name = "subEsquerda";
            this.subEsquerda.Size = new System.Drawing.Size(89, 36);
            this.subEsquerda.TabIndex = 17;
            this.subEsquerda.Text = "num1";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(511, 411);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(179, 59);
            this.btnIniciar.TabIndex = 22;
            this.btnIniciar.Text = "Iniciar Teste";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnResposta_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 510);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.resSub);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.subDireita);
            this.Controls.Add(this.subEsquerda);
            this.Controls.Add(this.resMult);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.divDireita);
            this.Controls.Add(this.divEsquerda);
            this.Controls.Add(this.resDiv);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.multDireita);
            this.Controls.Add(this.multEsquerda);
            this.Controls.Add(this.resSomar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.somarDireita);
            this.Controls.Add(this.somarEsquerda);
            this.Controls.Add(this.tempo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Meu Primeiro Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resSomar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resDiv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resMult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resSub)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tempo;
        private System.Windows.Forms.Label somarEsquerda;
        private System.Windows.Forms.Label somarDireita;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown resSomar;
        private System.Windows.Forms.NumericUpDown resDiv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label multDireita;
        private System.Windows.Forms.Label multEsquerda;
        private System.Windows.Forms.NumericUpDown resMult;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label divDireita;
        private System.Windows.Forms.Label divEsquerda;
        private System.Windows.Forms.NumericUpDown resSub;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label subDireita;
        private System.Windows.Forms.Label subEsquerda;
        private System.Windows.Forms.Button btnIniciar;


        Random random = new Random();

        int somar1;
        int somar2;

        int subtrair1;
        int subtrair2;

        int dividir1;
        int dividir2;

        int mult1;
        int mult2;

        int tempoRestante;

        public void StartQ()
        {
            //somar
            somar1 = random.Next(1, 101);
            somar2 = random.Next(1, 101);

            somarEsquerda.Text = somar1.ToString();
            somarDireita.Text = somar2.ToString();

            resSomar.Value = 0;

            //subtração
            subtrair1 = random.Next(1, 101);
            subtrair2 = random.Next(1, 101);

            subEsquerda.Text = subtrair1.ToString();
            subDireita.Text = subtrair2.ToString();

            resSub.Value = 0;

            //div
            dividir1 = random.Next(1, 101);
            dividir2 = random.Next(1, 101);

            divEsquerda.Text = dividir1.ToString();
            divDireita.Text = dividir2.ToString();

            resDiv.Value = 0;

            //multiplicar
            mult1 = random.Next(1, 101);
            mult2 = random.Next(1, 101);

            multEsquerda.Text = mult1.ToString();
            multDireita.Text = mult2.ToString();

            resMult.Value = 0;

            //tempo restante
            tempoRestante = 30;
            tempo.Text = "30 segundos";
            timer1.Start();

             

        }

        bool ChecarAsRespostas()
        {
            if ((somar1 + somar2 == resSomar.Value)
                && (subtrair1 - subtrair2 == resSub.Value)
                && (mult1 * mult2 == resMult.Value)
                && (dividir1 / dividir2 == resDiv.Value))
                return true;
            else
                return false;
        }

        private System.Windows.Forms.Timer timer1;
    }


}

=======
﻿using System;
namespace OlaMundo
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tempo = new System.Windows.Forms.Label();
            this.somarEsquerda = new System.Windows.Forms.Label();
            this.somarDireita = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.resSomar = new System.Windows.Forms.NumericUpDown();
            this.resDiv = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.multDireita = new System.Windows.Forms.Label();
            this.multEsquerda = new System.Windows.Forms.Label();
            this.resMult = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.divDireita = new System.Windows.Forms.Label();
            this.divEsquerda = new System.Windows.Forms.Label();
            this.resSub = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.subDireita = new System.Windows.Forms.Label();
            this.subEsquerda = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.resSomar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resDiv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resMult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resSub)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tempo restante";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tempo
            // 
            this.tempo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tempo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempo.Location = new System.Drawing.Point(511, 21);
            this.tempo.Name = "tempo";
            this.tempo.Size = new System.Drawing.Size(179, 37);
            this.tempo.TabIndex = 1;
            this.tempo.Text = "tempo";
            this.tempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // somarEsquerda
            // 
            this.somarEsquerda.AutoSize = true;
            this.somarEsquerda.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.somarEsquerda.Location = new System.Drawing.Point(136, 93);
            this.somarEsquerda.Name = "somarEsquerda";
            this.somarEsquerda.Size = new System.Drawing.Size(89, 36);
            this.somarEsquerda.TabIndex = 2;
            this.somarEsquerda.Text = "num1";
            // 
            // somarDireita
            // 
            this.somarDireita.AutoSize = true;
            this.somarDireita.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.somarDireita.Location = new System.Drawing.Point(327, 93);
            this.somarDireita.Name = "somarDireita";
            this.somarDireita.Size = new System.Drawing.Size(89, 36);
            this.somarDireita.TabIndex = 3;
            this.somarDireita.Text = "num2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(259, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 36);
            this.label5.TabIndex = 4;
            this.label5.Text = "+";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(429, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 36);
            this.label6.TabIndex = 5;
            this.label6.Text = "=";
            // 
            // resSomar
            // 
            this.resSomar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resSomar.Location = new System.Drawing.Point(530, 93);
            this.resSomar.Name = "resSomar";
            this.resSomar.Size = new System.Drawing.Size(136, 38);
            this.resSomar.TabIndex = 6;
            // 
            // resDiv
            // 
            this.resDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resDiv.Location = new System.Drawing.Point(530, 318);
            this.resDiv.Name = "resDiv";
            this.resDiv.Size = new System.Drawing.Size(136, 38);
            this.resDiv.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(427, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 36);
            this.label7.TabIndex = 10;
            this.label7.Text = "=";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(259, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 36);
            this.label8.TabIndex = 9;
            this.label8.Text = "*";
            // 
            // multDireita
            // 
            this.multDireita.AutoSize = true;
            this.multDireita.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multDireita.Location = new System.Drawing.Point(325, 180);
            this.multDireita.Name = "multDireita";
            this.multDireita.Size = new System.Drawing.Size(89, 36);
            this.multDireita.TabIndex = 8;
            this.multDireita.Text = "num2";
            // 
            // multEsquerda
            // 
            this.multEsquerda.AutoSize = true;
            this.multEsquerda.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multEsquerda.Location = new System.Drawing.Point(134, 180);
            this.multEsquerda.Name = "multEsquerda";
            this.multEsquerda.Size = new System.Drawing.Size(89, 36);
            this.multEsquerda.TabIndex = 7;
            this.multEsquerda.Text = "num1";
            // 
            // resMult
            // 
            this.resMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resMult.Location = new System.Drawing.Point(530, 178);
            this.resMult.Name = "resMult";
            this.resMult.Size = new System.Drawing.Size(136, 38);
            this.resMult.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(429, 326);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 36);
            this.label11.TabIndex = 15;
            this.label11.Text = "=";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(259, 326);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 36);
            this.label12.TabIndex = 14;
            this.label12.Text = "/";
            // 
            // divDireita
            // 
            this.divDireita.AutoSize = true;
            this.divDireita.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divDireita.Location = new System.Drawing.Point(327, 326);
            this.divDireita.Name = "divDireita";
            this.divDireita.Size = new System.Drawing.Size(89, 36);
            this.divDireita.TabIndex = 13;
            this.divDireita.Text = "num2";
            // 
            // divEsquerda
            // 
            this.divEsquerda.AutoSize = true;
            this.divEsquerda.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divEsquerda.Location = new System.Drawing.Point(136, 326);
            this.divEsquerda.Name = "divEsquerda";
            this.divEsquerda.Size = new System.Drawing.Size(89, 36);
            this.divEsquerda.TabIndex = 12;
            this.divEsquerda.Text = "num1";
            // 
            // resSub
            // 
            this.resSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resSub.Location = new System.Drawing.Point(530, 253);
            this.resSub.Name = "resSub";
            this.resSub.Size = new System.Drawing.Size(136, 38);
            this.resSub.TabIndex = 21;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(429, 253);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 36);
            this.label15.TabIndex = 20;
            this.label15.Text = "=";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(259, 253);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(25, 36);
            this.label16.TabIndex = 19;
            this.label16.Text = "-";
            // 
            // subDireita
            // 
            this.subDireita.AutoSize = true;
            this.subDireita.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subDireita.Location = new System.Drawing.Point(327, 253);
            this.subDireita.Name = "subDireita";
            this.subDireita.Size = new System.Drawing.Size(89, 36);
            this.subDireita.TabIndex = 18;
            this.subDireita.Text = "num2";
            // 
            // subEsquerda
            // 
            this.subEsquerda.AutoSize = true;
            this.subEsquerda.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subEsquerda.Location = new System.Drawing.Point(136, 253);
            this.subEsquerda.Name = "subEsquerda";
            this.subEsquerda.Size = new System.Drawing.Size(89, 36);
            this.subEsquerda.TabIndex = 17;
            this.subEsquerda.Text = "num1";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(511, 411);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(179, 59);
            this.btnIniciar.TabIndex = 22;
            this.btnIniciar.Text = "Iniciar Teste";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnResposta_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 510);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.resSub);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.subDireita);
            this.Controls.Add(this.subEsquerda);
            this.Controls.Add(this.resMult);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.divDireita);
            this.Controls.Add(this.divEsquerda);
            this.Controls.Add(this.resDiv);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.multDireita);
            this.Controls.Add(this.multEsquerda);
            this.Controls.Add(this.resSomar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.somarDireita);
            this.Controls.Add(this.somarEsquerda);
            this.Controls.Add(this.tempo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Meu Primeiro Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resSomar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resDiv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resMult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resSub)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tempo;
        private System.Windows.Forms.Label somarEsquerda;
        private System.Windows.Forms.Label somarDireita;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown resSomar;
        private System.Windows.Forms.NumericUpDown resDiv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label multDireita;
        private System.Windows.Forms.Label multEsquerda;
        private System.Windows.Forms.NumericUpDown resMult;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label divDireita;
        private System.Windows.Forms.Label divEsquerda;
        private System.Windows.Forms.NumericUpDown resSub;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label subDireita;
        private System.Windows.Forms.Label subEsquerda;
        private System.Windows.Forms.Button btnIniciar;


        Random random = new Random();

        int somar1;
        int somar2;

        int subtrair1;
        int subtrair2;

        int dividir1;
        int dividir2;

        int mult1;
        int mult2;

        int tempoRestante;

        public void StartQ()
        {
            //somar
            somar1 = random.Next(1, 101);
            somar2 = random.Next(1, 101);

            somarEsquerda.Text = somar1.ToString();
            somarDireita.Text = somar2.ToString();

            resSomar.Value = 0;

            //subtração
            subtrair1 = random.Next(1, 101);
            subtrair2 = random.Next(1, 101);

            subEsquerda.Text = subtrair1.ToString();
            subDireita.Text = subtrair2.ToString();

            resSub.Value = 0;

            //div
            dividir1 = random.Next(1, 101);
            dividir2 = random.Next(1, 101);

            divEsquerda.Text = dividir1.ToString();
            divDireita.Text = dividir2.ToString();

            resDiv.Value = 0;

            //multiplicar
            mult1 = random.Next(1, 101);
            mult2 = random.Next(1, 101);

            multEsquerda.Text = mult1.ToString();
            multDireita.Text = mult2.ToString();

            resMult.Value = 0;

            //tempo restante
            tempoRestante = 30;
            tempo.Text = "30 segundos";
            timer1.Start();

             

        }

        bool ChecarAsRespostas()
        {
            if ((somar1 + somar2 == resSomar.Value)
                && (subtrair1 - subtrair2 == resSub.Value)
                && (mult1 * mult2 == resMult.Value)
                && (dividir1 / dividir2 == resDiv.Value))
                return true;
            else
                return false;
        }

        private System.Windows.Forms.Timer timer1;
    }


}

>>>>>>> 64b6159dd6f7bbe03106492c82cefb0e774ba4f8
