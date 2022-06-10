
namespace OlaMundo2
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
            this.btnCliqueAqui = new System.Windows.Forms.Button();
            this.lblTextoBoaVinda = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCliqueAqui
            // 
            this.btnCliqueAqui.AutoSize = true;
            this.btnCliqueAqui.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCliqueAqui.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCliqueAqui.Location = new System.Drawing.Point(358, 252);
            this.btnCliqueAqui.Margin = new System.Windows.Forms.Padding(4, 9, 4, 9);
            this.btnCliqueAqui.Name = "btnCliqueAqui";
            this.btnCliqueAqui.Size = new System.Drawing.Size(184, 64);
            this.btnCliqueAqui.TabIndex = 0;
            this.btnCliqueAqui.Text = "Clique Aqui";
            this.btnCliqueAqui.UseVisualStyleBackColor = false;
            this.btnCliqueAqui.Click += new System.EventHandler(this.btnCliqueAqui_Click);
            this.btnCliqueAqui.MouseEnter += new System.EventHandler(this.btnCliqueAqui_MouseEnter);
            this.btnCliqueAqui.MouseLeave += new System.EventHandler(this.btnCliqueAqui_MouseLeave);
            // 
            // lblTextoBoaVinda
            // 
            this.lblTextoBoaVinda.Location = new System.Drawing.Point(2, 9);
            this.lblTextoBoaVinda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTextoBoaVinda.Name = "lblTextoBoaVinda";
            this.lblTextoBoaVinda.Size = new System.Drawing.Size(896, 112);
            this.lblTextoBoaVinda.TabIndex = 1;
            this.lblTextoBoaVinda.Text = "Aqui vai um texto";
            this.lblTextoBoaVinda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 568);
            this.Controls.Add(this.lblTextoBoaVinda);
            this.Controls.Add(this.btnCliqueAqui);
            this.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 9, 4, 9);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Olá mundo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCliqueAqui;
        private System.Windows.Forms.Label lblTextoBoaVinda;
    }
}

