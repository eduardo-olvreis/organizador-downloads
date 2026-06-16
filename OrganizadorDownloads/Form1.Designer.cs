namespace OrganizadorDownloads
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
            this.btnPrincipal = new System.Windows.Forms.Button();
            this.lblPrincipal = new System.Windows.Forms.Label();
            this.lblSucesso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPrincipal
            // 
            this.btnPrincipal.Location = new System.Drawing.Point(320, 206);
            this.btnPrincipal.Name = "btnPrincipal";
            this.btnPrincipal.Size = new System.Drawing.Size(157, 50);
            this.btnPrincipal.TabIndex = 0;
            this.btnPrincipal.Text = "Organizar";
            this.btnPrincipal.UseVisualStyleBackColor = true;
            this.btnPrincipal.Click += new System.EventHandler(this.btnPrincipal_Click);
            // 
            // lblPrincipal
            // 
            this.lblPrincipal.AutoSize = true;
            this.lblPrincipal.Location = new System.Drawing.Point(228, 152);
            this.lblPrincipal.Name = "lblPrincipal";
            this.lblPrincipal.Size = new System.Drawing.Size(344, 20);
            this.lblPrincipal.TabIndex = 1;
            this.lblPrincipal.Text = "Organize seus downloads com apenas 1 clique!";
            // 
            // lblSucesso
            // 
            this.lblSucesso.AutoSize = true;
            this.lblSucesso.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblSucesso.Location = new System.Drawing.Point(258, 297);
            this.lblSucesso.Name = "lblSucesso";
            this.lblSucesso.Size = new System.Drawing.Size(280, 20);
            this.lblSucesso.TabIndex = 2;
            this.lblSucesso.Text = "Downloads organizados com sucesso!";
            this.lblSucesso.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSucesso);
            this.Controls.Add(this.lblPrincipal);
            this.Controls.Add(this.btnPrincipal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrincipal;
        private System.Windows.Forms.Label lblPrincipal;
        private System.Windows.Forms.Label lblSucesso;
    }
}

