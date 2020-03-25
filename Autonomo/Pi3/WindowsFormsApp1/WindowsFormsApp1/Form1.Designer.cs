namespace WindowsFormsApp1
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
            this.btnListarP = new System.Windows.Forms.Button();
            this.txtListarJ = new System.Windows.Forms.TextBox();
            this.cmbPartidas = new System.Windows.Forms.ComboBox();
            this.lblNomeJ = new System.Windows.Forms.Label();
            this.lblLogarP = new System.Windows.Forms.Label();
            this.txtNomeJ = new System.Windows.Forms.TextBox();
            this.txtSenhaJ = new System.Windows.Forms.TextBox();
            this.btnLogar = new System.Windows.Forms.Button();
            this.txtNomeP = new System.Windows.Forms.TextBox();
            this.txtSenhaP = new System.Windows.Forms.TextBox();
            this.lblSenhaP = new System.Windows.Forms.Label();
            this.btnCriarP = new System.Windows.Forms.Button();
            this.btnComecar = new System.Windows.Forms.Button();
            this.btnListarJ = new System.Windows.Forms.Button();
            this.lblNomeP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnListarP
            // 
            this.btnListarP.Location = new System.Drawing.Point(390, 21);
            this.btnListarP.Name = "btnListarP";
            this.btnListarP.Size = new System.Drawing.Size(75, 23);
            this.btnListarP.TabIndex = 0;
            this.btnListarP.Text = "listar";
            this.btnListarP.UseVisualStyleBackColor = true;
            this.btnListarP.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtListarJ
            // 
            this.txtListarJ.Location = new System.Drawing.Point(635, 21);
            this.txtListarJ.Multiline = true;
            this.txtListarJ.Name = "txtListarJ";
            this.txtListarJ.Size = new System.Drawing.Size(153, 179);
            this.txtListarJ.TabIndex = 1;
            this.txtListarJ.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cmbPartidas
            // 
            this.cmbPartidas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPartidas.FormattingEnabled = true;
            this.cmbPartidas.Location = new System.Drawing.Point(495, 21);
            this.cmbPartidas.Name = "cmbPartidas";
            this.cmbPartidas.Size = new System.Drawing.Size(121, 21);
            this.cmbPartidas.TabIndex = 2;
            this.cmbPartidas.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblNomeJ
            // 
            this.lblNomeJ.AutoSize = true;
            this.lblNomeJ.Location = new System.Drawing.Point(6, 265);
            this.lblNomeJ.Name = "lblNomeJ";
            this.lblNomeJ.Size = new System.Drawing.Size(74, 13);
            this.lblNomeJ.TabIndex = 4;
            this.lblNomeJ.Text = "nome Jogador";
            this.lblNomeJ.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblLogarP
            // 
            this.lblLogarP.AutoSize = true;
            this.lblLogarP.Location = new System.Drawing.Point(6, 315);
            this.lblLogarP.Name = "lblLogarP";
            this.lblLogarP.Size = new System.Drawing.Size(72, 13);
            this.lblLogarP.TabIndex = 5;
            this.lblLogarP.Text = "senha Partida";
            this.lblLogarP.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNomeJ
            // 
            this.txtNomeJ.Location = new System.Drawing.Point(95, 262);
            this.txtNomeJ.Name = "txtNomeJ";
            this.txtNomeJ.Size = new System.Drawing.Size(100, 20);
            this.txtNomeJ.TabIndex = 6;
            this.txtNomeJ.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtSenhaJ
            // 
            this.txtSenhaJ.Location = new System.Drawing.Point(95, 308);
            this.txtSenhaJ.Name = "txtSenhaJ";
            this.txtSenhaJ.Size = new System.Drawing.Size(100, 20);
            this.txtSenhaJ.TabIndex = 7;
            // 
            // btnLogar
            // 
            this.btnLogar.Location = new System.Drawing.Point(110, 334);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(75, 23);
            this.btnLogar.TabIndex = 8;
            this.btnLogar.Text = "Logar";
            this.btnLogar.UseVisualStyleBackColor = true;
            this.btnLogar.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtNomeP
            // 
            this.txtNomeP.Location = new System.Drawing.Point(95, 110);
            this.txtNomeP.Name = "txtNomeP";
            this.txtNomeP.Size = new System.Drawing.Size(100, 20);
            this.txtNomeP.TabIndex = 9;
            this.txtNomeP.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtSenhaP
            // 
            this.txtSenhaP.Location = new System.Drawing.Point(95, 146);
            this.txtSenhaP.Name = "txtSenhaP";
            this.txtSenhaP.Size = new System.Drawing.Size(100, 20);
            this.txtSenhaP.TabIndex = 10;
            // 
            // lblSenhaP
            // 
            this.lblSenhaP.AutoSize = true;
            this.lblSenhaP.Location = new System.Drawing.Point(44, 153);
            this.lblSenhaP.Name = "lblSenhaP";
            this.lblSenhaP.Size = new System.Drawing.Size(36, 13);
            this.lblSenhaP.TabIndex = 11;
            this.lblSenhaP.Text = "senha";
            this.lblSenhaP.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnCriarP
            // 
            this.btnCriarP.Location = new System.Drawing.Point(110, 177);
            this.btnCriarP.Name = "btnCriarP";
            this.btnCriarP.Size = new System.Drawing.Size(75, 23);
            this.btnCriarP.TabIndex = 12;
            this.btnCriarP.Text = "Criar Partida";
            this.btnCriarP.UseVisualStyleBackColor = true;
            this.btnCriarP.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnComecar
            // 
            this.btnComecar.Location = new System.Drawing.Point(380, 262);
            this.btnComecar.Name = "btnComecar";
            this.btnComecar.Size = new System.Drawing.Size(75, 23);
            this.btnComecar.TabIndex = 13;
            this.btnComecar.Text = "comecar ";
            this.btnComecar.UseVisualStyleBackColor = true;
            this.btnComecar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnListarJ
            // 
            this.btnListarJ.Location = new System.Drawing.Point(531, 88);
            this.btnListarJ.Name = "btnListarJ";
            this.btnListarJ.Size = new System.Drawing.Size(75, 42);
            this.btnListarJ.TabIndex = 14;
            this.btnListarJ.Text = "Listar Jogadores";
            this.btnListarJ.UseVisualStyleBackColor = true;
            this.btnListarJ.Click += new System.EventHandler(this.button5_Click);
            // 
            // lblNomeP
            // 
            this.lblNomeP.AutoSize = true;
            this.lblNomeP.Location = new System.Drawing.Point(47, 113);
            this.lblNomeP.Name = "lblNomeP";
            this.lblNomeP.Size = new System.Drawing.Size(33, 13);
            this.lblNomeP.TabIndex = 15;
            this.lblNomeP.Text = "nome";
            this.lblNomeP.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNomeP);
            this.Controls.Add(this.btnListarJ);
            this.Controls.Add(this.btnComecar);
            this.Controls.Add(this.btnCriarP);
            this.Controls.Add(this.lblSenhaP);
            this.Controls.Add(this.txtSenhaP);
            this.Controls.Add(this.txtNomeP);
            this.Controls.Add(this.btnLogar);
            this.Controls.Add(this.txtSenhaJ);
            this.Controls.Add(this.txtNomeJ);
            this.Controls.Add(this.lblLogarP);
            this.Controls.Add(this.lblNomeJ);
            this.Controls.Add(this.cmbPartidas);
            this.Controls.Add(this.txtListarJ);
            this.Controls.Add(this.btnListarP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListarP;
        private System.Windows.Forms.TextBox txtListarJ;
        private System.Windows.Forms.ComboBox cmbPartidas;
        private System.Windows.Forms.Label lblNomeJ;
        private System.Windows.Forms.Label lblLogarP;
        private System.Windows.Forms.TextBox txtNomeJ;
        private System.Windows.Forms.TextBox txtSenhaJ;
        private System.Windows.Forms.Button btnLogar;
        private System.Windows.Forms.TextBox txtNomeP;
        private System.Windows.Forms.TextBox txtSenhaP;
        private System.Windows.Forms.Label lblSenhaP;
        private System.Windows.Forms.Button btnCriarP;
        private System.Windows.Forms.Button btnComecar;
        private System.Windows.Forms.Button btnListarJ;
        private System.Windows.Forms.Label lblNomeP;
    }
}

