namespace AppGaragem
{
    partial class TelaCarro
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
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.cboMotor = new System.Windows.Forms.ComboBox();
            this.lblMotor = new System.Windows.Forms.Label();
            this.lblAnoModelo = new System.Windows.Forms.Label();
            this.cboAnoModelo = new System.Windows.Forms.ComboBox();
            this.cboAnoFab = new System.Windows.Forms.ComboBox();
            this.lblAnoFab = new System.Windows.Forms.Label();
            this.lblCor = new System.Windows.Forms.Label();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(13, 13);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(16, 30);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(16, 73);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(258, 20);
            this.txtNome.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(13, 56);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(16, 117);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(258, 20);
            this.txtMarca.TabIndex = 5;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(13, 100);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 4;
            this.lblMarca.Text = "Marca";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(13, 140);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(42, 13);
            this.lblModelo.TabIndex = 6;
            this.lblModelo.Text = "Modelo";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(16, 156);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(258, 20);
            this.txtModelo.TabIndex = 7;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(16, 268);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(149, 268);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(270, 268);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 10;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.BtnListar_Click);
            // 
            // cboMotor
            // 
            this.cboMotor.FormattingEnabled = true;
            this.cboMotor.Location = new System.Drawing.Point(16, 231);
            this.cboMotor.Name = "cboMotor";
            this.cboMotor.Size = new System.Drawing.Size(121, 21);
            this.cboMotor.TabIndex = 11;
            this.cboMotor.SelectedIndexChanged += new System.EventHandler(this.CboMotor_SelectedIndexChanged);
            // 
            // lblMotor
            // 
            this.lblMotor.AutoSize = true;
            this.lblMotor.Location = new System.Drawing.Point(16, 217);
            this.lblMotor.Name = "lblMotor";
            this.lblMotor.Size = new System.Drawing.Size(34, 13);
            this.lblMotor.TabIndex = 12;
            this.lblMotor.Text = "Motor";
            // 
            // lblAnoModelo
            // 
            this.lblAnoModelo.AutoSize = true;
            this.lblAnoModelo.Location = new System.Drawing.Point(334, 174);
            this.lblAnoModelo.Name = "lblAnoModelo";
            this.lblAnoModelo.Size = new System.Drawing.Size(64, 13);
            this.lblAnoModelo.TabIndex = 13;
            this.lblAnoModelo.Text = "Ano Modelo";
            // 
            // cboAnoModelo
            // 
            this.cboAnoModelo.FormattingEnabled = true;
            this.cboAnoModelo.Location = new System.Drawing.Point(335, 190);
            this.cboAnoModelo.Name = "cboAnoModelo";
            this.cboAnoModelo.Size = new System.Drawing.Size(121, 21);
            this.cboAnoModelo.TabIndex = 14;
            // 
            // cboAnoFab
            // 
            this.cboAnoFab.FormattingEnabled = true;
            this.cboAnoFab.Location = new System.Drawing.Point(335, 140);
            this.cboAnoFab.Name = "cboAnoFab";
            this.cboAnoFab.Size = new System.Drawing.Size(121, 21);
            this.cboAnoFab.TabIndex = 16;
            // 
            // lblAnoFab
            // 
            this.lblAnoFab.AutoSize = true;
            this.lblAnoFab.Location = new System.Drawing.Point(334, 124);
            this.lblAnoFab.Name = "lblAnoFab";
            this.lblAnoFab.Size = new System.Drawing.Size(82, 13);
            this.lblAnoFab.TabIndex = 15;
            this.lblAnoFab.Text = "Ano Fabricação";
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.Location = new System.Drawing.Point(15, 179);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(23, 13);
            this.lblCor.TabIndex = 17;
            this.lblCor.Text = "Cor";
            // 
            // txtCor
            // 
            this.txtCor.Location = new System.Drawing.Point(16, 195);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(258, 20);
            this.txtCor.TabIndex = 18;
            // 
            // TelaCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 313);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(this.lblCor);
            this.Controls.Add(this.cboAnoFab);
            this.Controls.Add(this.lblAnoFab);
            this.Controls.Add(this.cboAnoModelo);
            this.Controls.Add(this.lblAnoModelo);
            this.Controls.Add(this.lblMotor);
            this.Controls.Add(this.cboMotor);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Name = "TelaCarro";
            this.Text = "Cadastro Carro";
            this.Load += new System.EventHandler(this.TelaCarro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.ComboBox cboMotor;
        private System.Windows.Forms.Label lblMotor;
        private System.Windows.Forms.Label lblAnoModelo;
        private System.Windows.Forms.ComboBox cboAnoModelo;
        private System.Windows.Forms.ComboBox cboAnoFab;
        private System.Windows.Forms.Label lblAnoFab;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.TextBox txtCor;
    }
}