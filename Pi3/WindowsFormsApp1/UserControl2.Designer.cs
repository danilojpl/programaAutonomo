namespace WindowsFormsApp1
{
    partial class UserControl2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl2));
            this.txtNomeJ = new System.Windows.Forms.TextBox();
            this.lblNomeJ = new System.Windows.Forms.Label();
            this.lblLogarP = new System.Windows.Forms.Label();
            this.cmbPartidas = new System.Windows.Forms.ComboBox();
            this.txtSenhaJogador = new System.Windows.Forms.TextBox();
            this.txtSenhaJ = new System.Windows.Forms.TextBox();
            this.txtListarJ = new System.Windows.Forms.TextBox();
            this.txtIdJogador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnListarP = new System.Windows.Forms.Button();
            this.btnListarJ = new System.Windows.Forms.Button();
            this.btnLogar = new System.Windows.Forms.Button();
            this.btnComecar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNomeJ
            // 
            this.txtNomeJ.Location = new System.Drawing.Point(437, 321);
            this.txtNomeJ.Name = "txtNomeJ";
            this.txtNomeJ.Size = new System.Drawing.Size(100, 20);
            this.txtNomeJ.TabIndex = 122;
            // 
            // lblNomeJ
            // 
            this.lblNomeJ.AutoSize = true;
            this.lblNomeJ.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeJ.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeJ.ForeColor = System.Drawing.Color.White;
            this.lblNomeJ.Location = new System.Drawing.Point(309, 321);
            this.lblNomeJ.Name = "lblNomeJ";
            this.lblNomeJ.Size = new System.Drawing.Size(122, 17);
            this.lblNomeJ.TabIndex = 120;
            this.lblNomeJ.Text = "nome Jogador";
            // 
            // lblLogarP
            // 
            this.lblLogarP.AutoSize = true;
            this.lblLogarP.BackColor = System.Drawing.Color.Transparent;
            this.lblLogarP.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogarP.ForeColor = System.Drawing.Color.White;
            this.lblLogarP.Location = new System.Drawing.Point(308, 367);
            this.lblLogarP.Name = "lblLogarP";
            this.lblLogarP.Size = new System.Drawing.Size(123, 17);
            this.lblLogarP.TabIndex = 121;
            this.lblLogarP.Text = "senha Partida";
            // 
            // cmbPartidas
            // 
            this.cmbPartidas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPartidas.FormattingEnabled = true;
            this.cmbPartidas.Location = new System.Drawing.Point(187, 3);
            this.cmbPartidas.Name = "cmbPartidas";
            this.cmbPartidas.Size = new System.Drawing.Size(142, 21);
            this.cmbPartidas.TabIndex = 117;
            // 
            // txtSenhaJogador
            // 
            this.txtSenhaJogador.Location = new System.Drawing.Point(543, 367);
            this.txtSenhaJogador.Name = "txtSenhaJogador";
            this.txtSenhaJogador.Size = new System.Drawing.Size(100, 20);
            this.txtSenhaJogador.TabIndex = 129;
            // 
            // txtSenhaJ
            // 
            this.txtSenhaJ.Location = new System.Drawing.Point(437, 367);
            this.txtSenhaJ.Name = "txtSenhaJ";
            this.txtSenhaJ.Size = new System.Drawing.Size(100, 20);
            this.txtSenhaJ.TabIndex = 123;
            // 
            // txtListarJ
            // 
            this.txtListarJ.BackColor = System.Drawing.SystemColors.Window;
            this.txtListarJ.Location = new System.Drawing.Point(490, 32);
            this.txtListarJ.Multiline = true;
            this.txtListarJ.Name = "txtListarJ";
            this.txtListarJ.Size = new System.Drawing.Size(153, 179);
            this.txtListarJ.TabIndex = 119;
            // 
            // txtIdJogador
            // 
            this.txtIdJogador.Location = new System.Drawing.Point(543, 321);
            this.txtIdJogador.Name = "txtIdJogador";
            this.txtIdJogador.Size = new System.Drawing.Size(100, 20);
            this.txtIdJogador.TabIndex = 128;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(562, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 126;
            this.label1.Text = "id Jogador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(551, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 127;
            this.label2.Text = "Senha Jogador";
            // 
            // btnListarP
            // 
            this.btnListarP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnListarP.BackgroundImage")));
            this.btnListarP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnListarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarP.Font = new System.Drawing.Font("Ravie", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarP.ForeColor = System.Drawing.Color.Chocolate;
            this.btnListarP.Location = new System.Drawing.Point(6, 1);
            this.btnListarP.Name = "btnListarP";
            this.btnListarP.Size = new System.Drawing.Size(175, 23);
            this.btnListarP.TabIndex = 116;
            this.btnListarP.Text = "LISTAR PARTIDAS";
            this.btnListarP.UseVisualStyleBackColor = true;
            this.btnListarP.Click += new System.EventHandler(this.btnListarP_Click);
            // 
            // btnListarJ
            // 
            this.btnListarJ.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnListarJ.BackgroundImage")));
            this.btnListarJ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnListarJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarJ.Font = new System.Drawing.Font("Ravie", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarJ.ForeColor = System.Drawing.Color.Chocolate;
            this.btnListarJ.Location = new System.Drawing.Point(346, 45);
            this.btnListarJ.Name = "btnListarJ";
            this.btnListarJ.Size = new System.Drawing.Size(127, 61);
            this.btnListarJ.TabIndex = 118;
            this.btnListarJ.Text = "LISTAR JOGADORES";
            this.btnListarJ.UseVisualStyleBackColor = true;
            this.btnListarJ.Click += new System.EventHandler(this.btnListarJ_Click);
            // 
            // btnLogar
            // 
            this.btnLogar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogar.BackgroundImage")));
            this.btnLogar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogar.Font = new System.Drawing.Font("Ravie", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogar.ForeColor = System.Drawing.Color.Chocolate;
            this.btnLogar.Location = new System.Drawing.Point(446, 393);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(75, 23);
            this.btnLogar.TabIndex = 124;
            this.btnLogar.Text = "Logar";
            this.btnLogar.UseVisualStyleBackColor = true;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // btnComecar
            // 
            this.btnComecar.BackColor = System.Drawing.SystemColors.Control;
            this.btnComecar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnComecar.BackgroundImage")));
            this.btnComecar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnComecar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComecar.Font = new System.Drawing.Font("Ravie", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComecar.ForeColor = System.Drawing.Color.Chocolate;
            this.btnComecar.Location = new System.Drawing.Point(543, 393);
            this.btnComecar.Name = "btnComecar";
            this.btnComecar.Size = new System.Drawing.Size(89, 23);
            this.btnComecar.TabIndex = 125;
            this.btnComecar.Text = "comecar ";
            this.btnComecar.UseVisualStyleBackColor = false;
            this.btnComecar.Click += new System.EventHandler(this.btnComecar_Click);
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.txtNomeJ);
            this.Controls.Add(this.lblNomeJ);
            this.Controls.Add(this.lblLogarP);
            this.Controls.Add(this.cmbPartidas);
            this.Controls.Add(this.txtSenhaJogador);
            this.Controls.Add(this.btnListarP);
            this.Controls.Add(this.txtSenhaJ);
            this.Controls.Add(this.txtListarJ);
            this.Controls.Add(this.txtIdJogador);
            this.Controls.Add(this.btnListarJ);
            this.Controls.Add(this.btnLogar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnComecar);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(817, 562);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeJ;
        private System.Windows.Forms.Label lblNomeJ;
        private System.Windows.Forms.Label lblLogarP;
        private System.Windows.Forms.ComboBox cmbPartidas;
        private System.Windows.Forms.TextBox txtSenhaJogador;
        private System.Windows.Forms.Button btnListarP;
        private System.Windows.Forms.TextBox txtSenhaJ;
        private System.Windows.Forms.TextBox txtListarJ;
        private System.Windows.Forms.TextBox txtIdJogador;
        private System.Windows.Forms.Button btnListarJ;
        private System.Windows.Forms.Button btnLogar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnComecar;
    }
}
