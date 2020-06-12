namespace WindowsFormsApp1
{
    partial class UserControl1
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.txtNomeP = new System.Windows.Forms.TextBox();
            this.lblNomeP = new System.Windows.Forms.Label();
            this.txtSenhaP = new System.Windows.Forms.TextBox();
            this.lblSenhaP = new System.Windows.Forms.Label();
            this.btnCriarP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNomeP
            // 
            this.txtNomeP.Location = new System.Drawing.Point(345, 242);
            this.txtNomeP.Name = "txtNomeP";
            this.txtNomeP.Size = new System.Drawing.Size(100, 20);
            this.txtNomeP.TabIndex = 109;
            // 
            // lblNomeP
            // 
            this.lblNomeP.AutoSize = true;
            this.lblNomeP.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeP.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeP.ForeColor = System.Drawing.Color.White;
            this.lblNomeP.Location = new System.Drawing.Point(228, 245);
            this.lblNomeP.Name = "lblNomeP";
            this.lblNomeP.Size = new System.Drawing.Size(111, 17);
            this.lblNomeP.TabIndex = 113;
            this.lblNomeP.Text = "Nome Da Sala";
            // 
            // txtSenhaP
            // 
            this.txtSenhaP.Location = new System.Drawing.Point(345, 278);
            this.txtSenhaP.Name = "txtSenhaP";
            this.txtSenhaP.Size = new System.Drawing.Size(100, 20);
            this.txtSenhaP.TabIndex = 110;
            // 
            // lblSenhaP
            // 
            this.lblSenhaP.AutoSize = true;
            this.lblSenhaP.BackColor = System.Drawing.Color.Transparent;
            this.lblSenhaP.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaP.ForeColor = System.Drawing.Color.White;
            this.lblSenhaP.Location = new System.Drawing.Point(256, 278);
            this.lblSenhaP.Name = "lblSenhaP";
            this.lblSenhaP.Size = new System.Drawing.Size(54, 17);
            this.lblSenhaP.TabIndex = 111;
            this.lblSenhaP.Text = "Senha";
            // 
            // btnCriarP
            // 
            this.btnCriarP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCriarP.BackgroundImage")));
            this.btnCriarP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCriarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarP.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarP.ForeColor = System.Drawing.Color.Chocolate;
            this.btnCriarP.Location = new System.Drawing.Point(259, 304);
            this.btnCriarP.Name = "btnCriarP";
            this.btnCriarP.Size = new System.Drawing.Size(162, 30);
            this.btnCriarP.TabIndex = 112;
            this.btnCriarP.Text = "Criar Partida";
            this.btnCriarP.UseVisualStyleBackColor = true;
            this.btnCriarP.Click += new System.EventHandler(this.btnCriarP_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.txtNomeP);
            this.Controls.Add(this.lblNomeP);
            this.Controls.Add(this.txtSenhaP);
            this.Controls.Add(this.lblSenhaP);
            this.Controls.Add(this.btnCriarP);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(548, 466);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeP;
        private System.Windows.Forms.Label lblNomeP;
        private System.Windows.Forms.TextBox txtSenhaP;
        private System.Windows.Forms.Label lblSenhaP;
        private System.Windows.Forms.Button btnCriarP;
    }
}
