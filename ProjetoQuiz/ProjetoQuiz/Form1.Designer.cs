using System;

namespace ProjetoQuiz
{
    partial class AtividadeQuiz
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
            this.label2 = new System.Windows.Forms.Label();
            this.somarDireita = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.resSoma = new System.Windows.Forms.NumericUpDown();
            this.resSub = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.subDireita = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.subEsquerda = new System.Windows.Forms.Label();
            this.resMult = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.multDireita = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.multEsquerda = new System.Windows.Forms.Label();
            this.resDiv = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.divDireita = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.divEsquerda = new System.Windows.Forms.Label();
            this.btnStartTeste = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.resSoma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resSub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resMult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resDiv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tempo Restante";
            // 
            // tempo
            // 
            this.tempo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tempo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempo.Location = new System.Drawing.Point(470, 31);
            this.tempo.Name = "tempo";
            this.tempo.Size = new System.Drawing.Size(162, 41);
            this.tempo.TabIndex = 1;
            this.tempo.Text = "Tempo";
            this.tempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // somarEsquerda
            // 
            this.somarEsquerda.AutoSize = true;
            this.somarEsquerda.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.somarEsquerda.Location = new System.Drawing.Point(148, 155);
            this.somarEsquerda.Name = "somarEsquerda";
            this.somarEsquerda.Size = new System.Drawing.Size(94, 36);
            this.somarEsquerda.TabIndex = 2;
            this.somarEsquerda.Text = "Num1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(270, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "+";
            // 
            // somarDireita
            // 
            this.somarDireita.AutoSize = true;
            this.somarDireita.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.somarDireita.Location = new System.Drawing.Point(330, 155);
            this.somarDireita.Name = "somarDireita";
            this.somarDireita.Size = new System.Drawing.Size(94, 36);
            this.somarDireita.TabIndex = 4;
            this.somarDireita.Text = "Num2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(452, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 36);
            this.label4.TabIndex = 5;
            this.label4.Text = "=";
            // 
            // resSoma
            // 
            this.resSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resSoma.Location = new System.Drawing.Point(512, 153);
            this.resSoma.Name = "resSoma";
            this.resSoma.Size = new System.Drawing.Size(120, 38);
            this.resSoma.TabIndex = 6;
            // 
            // resSub
            // 
            this.resSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resSub.Location = new System.Drawing.Point(512, 230);
            this.resSub.Name = "resSub";
            this.resSub.Size = new System.Drawing.Size(120, 38);
            this.resSub.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(452, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 36);
            this.label3.TabIndex = 10;
            this.label3.Text = "=";
            // 
            // subDireita
            // 
            this.subDireita.AutoSize = true;
            this.subDireita.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subDireita.Location = new System.Drawing.Point(330, 232);
            this.subDireita.Name = "subDireita";
            this.subDireita.Size = new System.Drawing.Size(94, 36);
            this.subDireita.TabIndex = 9;
            this.subDireita.Text = "Num2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(270, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 36);
            this.label6.TabIndex = 8;
            this.label6.Text = "-";
            // 
            // subEsquerda
            // 
            this.subEsquerda.AutoSize = true;
            this.subEsquerda.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subEsquerda.Location = new System.Drawing.Point(148, 232);
            this.subEsquerda.Name = "subEsquerda";
            this.subEsquerda.Size = new System.Drawing.Size(94, 36);
            this.subEsquerda.TabIndex = 7;
            this.subEsquerda.Text = "Num1";
            // 
            // resMult
            // 
            this.resMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resMult.Location = new System.Drawing.Point(512, 302);
            this.resMult.Name = "resMult";
            this.resMult.Size = new System.Drawing.Size(120, 38);
            this.resMult.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(452, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 36);
            this.label8.TabIndex = 15;
            this.label8.Text = "=";
            // 
            // multDireita
            // 
            this.multDireita.AutoSize = true;
            this.multDireita.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multDireita.Location = new System.Drawing.Point(330, 304);
            this.multDireita.Name = "multDireita";
            this.multDireita.Size = new System.Drawing.Size(94, 36);
            this.multDireita.TabIndex = 14;
            this.multDireita.Text = "Num2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(270, 304);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 36);
            this.label10.TabIndex = 13;
            this.label10.Text = "*";
            // 
            // multEsquerda
            // 
            this.multEsquerda.AutoSize = true;
            this.multEsquerda.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multEsquerda.Location = new System.Drawing.Point(148, 304);
            this.multEsquerda.Name = "multEsquerda";
            this.multEsquerda.Size = new System.Drawing.Size(94, 36);
            this.multEsquerda.TabIndex = 12;
            this.multEsquerda.Text = "Num1";
            // 
            // resDiv
            // 
            this.resDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resDiv.Location = new System.Drawing.Point(512, 369);
            this.resDiv.Name = "resDiv";
            this.resDiv.Size = new System.Drawing.Size(120, 38);
            this.resDiv.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(452, 371);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 36);
            this.label12.TabIndex = 20;
            this.label12.Text = "=";
            // 
            // divDireita
            // 
            this.divDireita.AutoSize = true;
            this.divDireita.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divDireita.Location = new System.Drawing.Point(330, 371);
            this.divDireita.Name = "divDireita";
            this.divDireita.Size = new System.Drawing.Size(94, 36);
            this.divDireita.TabIndex = 19;
            this.divDireita.Text = "Num2";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(270, 371);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 36);
            this.label14.TabIndex = 18;
            this.label14.Text = "/";
            // 
            // divEsquerda
            // 
            this.divEsquerda.AutoSize = true;
            this.divEsquerda.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divEsquerda.Location = new System.Drawing.Point(148, 371);
            this.divEsquerda.Name = "divEsquerda";
            this.divEsquerda.Size = new System.Drawing.Size(94, 36);
            this.divEsquerda.TabIndex = 17;
            this.divEsquerda.Text = "Num1";
            // 
            // btnStartTeste
            // 
            this.btnStartTeste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartTeste.Location = new System.Drawing.Point(470, 447);
            this.btnStartTeste.Name = "btnStartTeste";
            this.btnStartTeste.Size = new System.Drawing.Size(162, 55);
            this.btnStartTeste.TabIndex = 22;
            this.btnStartTeste.Text = "Iniciar Teste";
            this.btnStartTeste.UseVisualStyleBackColor = true;
            this.btnStartTeste.Click += new System.EventHandler(this.btnStartTeste_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AtividadeQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 562);
            this.Controls.Add(this.btnStartTeste);
            this.Controls.Add(this.resDiv);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.divDireita);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.divEsquerda);
            this.Controls.Add(this.resMult);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.multDireita);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.multEsquerda);
            this.Controls.Add(this.resSub);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.subDireita);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.subEsquerda);
            this.Controls.Add(this.resSoma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.somarDireita);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.somarEsquerda);
            this.Controls.Add(this.tempo);
            this.Controls.Add(this.label1);
            this.Name = "AtividadeQuiz";
            this.Text = "Atividade Quiz Matemática";
            ((System.ComponentModel.ISupportInitialize)(this.resSoma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resSub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resMult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resDiv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tempo;
        private System.Windows.Forms.Label somarEsquerda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label somarDireita;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown resSoma;
        private System.Windows.Forms.NumericUpDown resSub;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label subDireita;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label subEsquerda;
        private System.Windows.Forms.NumericUpDown resMult;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label multDireita;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label multEsquerda;
        private System.Windows.Forms.NumericUpDown resDiv;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label divDireita;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label divEsquerda;
        private System.Windows.Forms.Button btnStartTeste;

        //começando programar o teste

        Random random = new Random(); //gerar numero randomico

        //variaveis para cada label do form1
        int somar1;
        int somar2;

        int mult1;
        int mult2;

        int div1;
        int div2;

        int sub1;
        int sub2;

        int tempoRestante;

        public void StartQ()
        {
            //numeros randomicos sendo atribuidos a cada label
            //somar
            somar1 = random.Next(1, 31);
            somar2 = random.Next(1, 31);

            somarEsquerda.Text = somar1.ToString();
            somarDireita.Text = somar2.ToString();

            resSoma.Value = 0;

            //multiplicar
            mult1 = random.Next(1, 31);
            mult2 = random.Next(1, 31);

            multEsquerda.Text = mult1.ToString();
            multDireita.Text = mult2.ToString();

            resMult.Value = 0;

            //divisão
            div1 = random.Next(1, 31);
            div2 = random.Next(1, 31);

            divEsquerda.Text = div1.ToString();
            divDireita.Text = div2.ToString();

            resDiv.Value = 0;

            //subtração
            sub1 = random.Next(1, 31);
            sub2 = random.Next(1, 31);

            subEsquerda.Text = sub1.ToString();
            subDireita.Text = sub2.ToString();

            resSub.Value = 0;

            //propriedades de tempo
            tempoRestante = 30;
            tempo.Text = "30 segundos";
            timer1.Start(); //inicia o contador regressivo
        }

        private bool ChecarRespostas()
        {
            if ((somar1 + somar2 == resSoma.Value)
                && (sub1 - sub2 == resSub.Value)
                && (mult1 * mult2 == resMult.Value)
                && (div1 / div2 == resDiv.Value)
                )
                return true;
            else
                return false;
        }
            

        private System.Windows.Forms.Timer timer1;
    }
}

