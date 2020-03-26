namespace WindowsFormsApp1
{
    partial class Form2
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
            this.lblNomeP = new System.Windows.Forms.Label();
            this.btnListarJ = new System.Windows.Forms.Button();
            this.btnComecar = new System.Windows.Forms.Button();
            this.btnCriarP = new System.Windows.Forms.Button();
            this.lblSenhaP = new System.Windows.Forms.Label();
            this.txtSenhaP = new System.Windows.Forms.TextBox();
            this.txtNomeP = new System.Windows.Forms.TextBox();
            this.btnLogar = new System.Windows.Forms.Button();
            this.txtSenhaJ = new System.Windows.Forms.TextBox();
            this.txtNomeJ = new System.Windows.Forms.TextBox();
            this.lblLogarP = new System.Windows.Forms.Label();
            this.lblNomeJ = new System.Windows.Forms.Label();
            this.cmbPartidas = new System.Windows.Forms.ComboBox();
            this.txtListarJ = new System.Windows.Forms.TextBox();
            this.btnListarP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNomeP
            // 
            this.lblNomeP.AutoSize = true;
            this.lblNomeP.Location = new System.Drawing.Point(50, 149);
            this.lblNomeP.Name = "lblNomeP";
            this.lblNomeP.Size = new System.Drawing.Size(33, 13);
            this.lblNomeP.TabIndex = 30;
            this.lblNomeP.Text = "nome";
            // 
            // btnListarJ
            // 
            this.btnListarJ.Location = new System.Drawing.Point(534, 124);
            this.btnListarJ.Name = "btnListarJ";
            this.btnListarJ.Size = new System.Drawing.Size(75, 42);
            this.btnListarJ.TabIndex = 29;
            this.btnListarJ.Text = "Listar Jogadores";
            this.btnListarJ.UseVisualStyleBackColor = true;
            this.btnListarJ.Click += new System.EventHandler(this.btnListarJ_Click);
            // 
            // btnComecar
            // 
            this.btnComecar.Location = new System.Drawing.Point(383, 298);
            this.btnComecar.Name = "btnComecar";
            this.btnComecar.Size = new System.Drawing.Size(75, 23);
            this.btnComecar.TabIndex = 28;
            this.btnComecar.Text = "comecar ";
            this.btnComecar.UseVisualStyleBackColor = true;
            this.btnComecar.Click += new System.EventHandler(this.btnComecar_Click);
            // 
            // btnCriarP
            // 
            this.btnCriarP.Location = new System.Drawing.Point(113, 213);
            this.btnCriarP.Name = "btnCriarP";
            this.btnCriarP.Size = new System.Drawing.Size(75, 23);
            this.btnCriarP.TabIndex = 27;
            this.btnCriarP.Text = "Criar Partida";
            this.btnCriarP.UseVisualStyleBackColor = true;
            this.btnCriarP.Click += new System.EventHandler(this.btnCriarP_Click);
            // 
            // lblSenhaP
            // 
            this.lblSenhaP.AutoSize = true;
            this.lblSenhaP.Location = new System.Drawing.Point(47, 189);
            this.lblSenhaP.Name = "lblSenhaP";
            this.lblSenhaP.Size = new System.Drawing.Size(36, 13);
            this.lblSenhaP.TabIndex = 26;
            this.lblSenhaP.Text = "senha";
            // 
            // txtSenhaP
            // 
            this.txtSenhaP.Location = new System.Drawing.Point(98, 182);
            this.txtSenhaP.Name = "txtSenhaP";
            this.txtSenhaP.Size = new System.Drawing.Size(100, 20);
            this.txtSenhaP.TabIndex = 25;
            // 
            // txtNomeP
            // 
            this.txtNomeP.Location = new System.Drawing.Point(98, 146);
            this.txtNomeP.Name = "txtNomeP";
            this.txtNomeP.Size = new System.Drawing.Size(100, 20);
            this.txtNomeP.TabIndex = 24;
            this.txtNomeP.TextChanged += new System.EventHandler(this.txtNomeP_TextChanged);
            // 
            // btnLogar
            // 
            this.btnLogar.Location = new System.Drawing.Point(113, 370);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(75, 23);
            this.btnLogar.TabIndex = 23;
            this.btnLogar.Text = "Logar";
            this.btnLogar.UseVisualStyleBackColor = true;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // txtSenhaJ
            // 
            this.txtSenhaJ.Location = new System.Drawing.Point(98, 344);
            this.txtSenhaJ.Name = "txtSenhaJ";
            this.txtSenhaJ.Size = new System.Drawing.Size(100, 20);
            this.txtSenhaJ.TabIndex = 22;
            // 
            // txtNomeJ
            // 
            this.txtNomeJ.Location = new System.Drawing.Point(98, 298);
            this.txtNomeJ.Name = "txtNomeJ";
            this.txtNomeJ.Size = new System.Drawing.Size(100, 20);
            this.txtNomeJ.TabIndex = 21;
            // 
            // lblLogarP
            // 
            this.lblLogarP.AutoSize = true;
            this.lblLogarP.Location = new System.Drawing.Point(9, 351);
            this.lblLogarP.Name = "lblLogarP";
            this.lblLogarP.Size = new System.Drawing.Size(72, 13);
            this.lblLogarP.TabIndex = 20;
            this.lblLogarP.Text = "senha Partida";
            // 
            // lblNomeJ
            // 
            this.lblNomeJ.AutoSize = true;
            this.lblNomeJ.Location = new System.Drawing.Point(9, 301);
            this.lblNomeJ.Name = "lblNomeJ";
            this.lblNomeJ.Size = new System.Drawing.Size(74, 13);
            this.lblNomeJ.TabIndex = 19;
            this.lblNomeJ.Text = "nome Jogador";
            // 
            // cmbPartidas
            // 
            this.cmbPartidas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPartidas.FormattingEnabled = true;
            this.cmbPartidas.Location = new System.Drawing.Point(498, 57);
            this.cmbPartidas.Name = "cmbPartidas";
            this.cmbPartidas.Size = new System.Drawing.Size(121, 21);
            this.cmbPartidas.TabIndex = 18;
            this.cmbPartidas.SelectedIndexChanged += new System.EventHandler(this.cmbPartidas_SelectedIndexChanged);
            // 
            // txtListarJ
            // 
            this.txtListarJ.Location = new System.Drawing.Point(638, 57);
            this.txtListarJ.Multiline = true;
            this.txtListarJ.Name = "txtListarJ";
            this.txtListarJ.Size = new System.Drawing.Size(153, 179);
            this.txtListarJ.TabIndex = 17;
            // 
            // btnListarP
            // 
            this.btnListarP.Location = new System.Drawing.Point(393, 57);
            this.btnListarP.Name = "btnListarP";
            this.btnListarP.Size = new System.Drawing.Size(75, 23);
            this.btnListarP.TabIndex = 16;
            this.btnListarP.Text = "listar";
            this.btnListarP.UseVisualStyleBackColor = true;
            this.btnListarP.Click += new System.EventHandler(this.btnListarP_Click);
            // 
            // Form2
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
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeP;
        private System.Windows.Forms.Button btnListarJ;
        private System.Windows.Forms.Button btnComecar;
        private System.Windows.Forms.Button btnCriarP;
        private System.Windows.Forms.Label lblSenhaP;
        private System.Windows.Forms.TextBox txtSenhaP;
        private System.Windows.Forms.TextBox txtNomeP;
        private System.Windows.Forms.Button btnLogar;
        private System.Windows.Forms.TextBox txtSenhaJ;
        private System.Windows.Forms.TextBox txtNomeJ;
        private System.Windows.Forms.Label lblLogarP;
        private System.Windows.Forms.Label lblNomeJ;
        private System.Windows.Forms.ComboBox cmbPartidas;
        private System.Windows.Forms.TextBox txtListarJ;
        private System.Windows.Forms.Button btnListarP;
    }
}