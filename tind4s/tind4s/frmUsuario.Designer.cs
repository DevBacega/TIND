namespace tind4s
{
    partial class frmUsuario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAtualizar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnCadastrar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnDeletar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtSenha = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtProfessor = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtUsuario = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblProfessor = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.tBUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tind4sDataSet1 = new tind4s.tind4sDataSet1();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblId_Prontuario = new System.Windows.Forms.Label();
            this.lblInativo = new System.Windows.Forms.Label();
            this.tB_UsuarioTableAdapter = new tind4s.tind4sDataSet1TableAdapters.TB_UsuarioTableAdapter();
            this.gridUsuario = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.tBUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tind4sDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.ActiveBorderThickness = 1;
            this.btnAtualizar.ActiveCornerRadius = 20;
            this.btnAtualizar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.btnAtualizar.ActiveForecolor = System.Drawing.Color.White;
            this.btnAtualizar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.btnAtualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtualizar.BackColor = System.Drawing.Color.White;
            this.btnAtualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.BackgroundImage")));
            this.btnAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAtualizar.ButtonText = "Salvar";
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.btnAtualizar.IdleBorderThickness = 1;
            this.btnAtualizar.IdleCornerRadius = 20;
            this.btnAtualizar.IdleFillColor = System.Drawing.Color.White;
            this.btnAtualizar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.btnAtualizar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.btnAtualizar.Location = new System.Drawing.Point(673, 275);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(5);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(110, 45);
            this.btnAtualizar.TabIndex = 41;
            this.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.ActiveBorderThickness = 1;
            this.btnCadastrar.ActiveCornerRadius = 20;
            this.btnCadastrar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.btnCadastrar.ActiveForecolor = System.Drawing.Color.White;
            this.btnCadastrar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.btnCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastrar.BackColor = System.Drawing.Color.White;
            this.btnCadastrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.BackgroundImage")));
            this.btnCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCadastrar.ButtonText = "Novo";
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.btnCadastrar.IdleBorderThickness = 1;
            this.btnCadastrar.IdleCornerRadius = 20;
            this.btnCadastrar.IdleFillColor = System.Drawing.Color.White;
            this.btnCadastrar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.btnCadastrar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.btnCadastrar.Location = new System.Drawing.Point(675, 317);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(110, 45);
            this.btnCadastrar.TabIndex = 38;
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.ActiveBorderThickness = 1;
            this.btnDeletar.ActiveCornerRadius = 20;
            this.btnDeletar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.btnDeletar.ActiveForecolor = System.Drawing.Color.White;
            this.btnDeletar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.btnDeletar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeletar.BackColor = System.Drawing.Color.White;
            this.btnDeletar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeletar.BackgroundImage")));
            this.btnDeletar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeletar.ButtonText = "Deletar";
            this.btnDeletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.btnDeletar.IdleBorderThickness = 1;
            this.btnDeletar.IdleCornerRadius = 20;
            this.btnDeletar.IdleFillColor = System.Drawing.Color.White;
            this.btnDeletar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.btnDeletar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.btnDeletar.Location = new System.Drawing.Point(675, 361);
            this.btnDeletar.Margin = new System.Windows.Forms.Padding(5);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(110, 45);
            this.btnDeletar.TabIndex = 39;
            this.btnDeletar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.txtSenha.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSenha.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.txtSenha.BorderThickness = 3;
            this.txtSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSenha.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSenha.isPassword = false;
            this.txtSenha.Location = new System.Drawing.Point(194, 75);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(222, 29);
            this.txtSenha.TabIndex = 36;
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtProfessor
            // 
            this.txtProfessor.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.txtProfessor.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtProfessor.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.txtProfessor.BorderThickness = 3;
            this.txtProfessor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProfessor.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtProfessor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtProfessor.isPassword = false;
            this.txtProfessor.Location = new System.Drawing.Point(194, 119);
            this.txtProfessor.Margin = new System.Windows.Forms.Padding(4);
            this.txtProfessor.Name = "txtProfessor";
            this.txtProfessor.Size = new System.Drawing.Size(222, 29);
            this.txtProfessor.TabIndex = 35;
            this.txtProfessor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.txtUsuario.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsuario.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.txtUsuario.BorderThickness = 3;
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsuario.isPassword = false;
            this.txtUsuario.Location = new System.Drawing.Point(194, 32);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(222, 28);
            this.txtUsuario.TabIndex = 34;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSenha.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(115, 75);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(71, 24);
            this.lblSenha.TabIndex = 31;
            this.lblSenha.Text = "Senha:";
            // 
            // lblProfessor
            // 
            this.lblProfessor.AutoSize = true;
            this.lblProfessor.BackColor = System.Drawing.Color.Transparent;
            this.lblProfessor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProfessor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfessor.Location = new System.Drawing.Point(30, 124);
            this.lblProfessor.Name = "lblProfessor";
            this.lblProfessor.Size = new System.Drawing.Size(157, 24);
            this.lblProfessor.TabIndex = 32;
            this.lblProfessor.Text = "Nome Professor:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUsuario.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(106, 32);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(81, 24);
            this.lblUsuario.TabIndex = 33;
            this.lblUsuario.Text = "Usuário:";
            // 
            // tBUsuarioBindingSource
            // 
            this.tBUsuarioBindingSource.DataMember = "TB_Usuario";
            this.tBUsuarioBindingSource.DataSource = this.tind4sDataSet1;
            // 
            // tind4sDataSet1
            // 
            this.tind4sDataSet1.DataSetName = "tind4sDataSet1";
            this.tind4sDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(21, 175);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(65, 13);
            this.lblResultado.TabIndex = 43;
            this.lblResultado.Text = "lblResultado";
            // 
            // lblId_Prontuario
            // 
            this.lblId_Prontuario.AutoSize = true;
            this.lblId_Prontuario.Location = new System.Drawing.Point(30, 32);
            this.lblId_Prontuario.Name = "lblId_Prontuario";
            this.lblId_Prontuario.Size = new System.Drawing.Size(0, 13);
            this.lblId_Prontuario.TabIndex = 44;
            // 
            // lblInativo
            // 
            this.lblInativo.AutoSize = true;
            this.lblInativo.Location = new System.Drawing.Point(191, 163);
            this.lblInativo.Name = "lblInativo";
            this.lblInativo.Size = new System.Drawing.Size(35, 13);
            this.lblInativo.TabIndex = 45;
            this.lblInativo.Text = "label1";
            // 
            // tB_UsuarioTableAdapter
            // 
            this.tB_UsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // gridUsuario
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridUsuario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridUsuario.BackgroundColor = System.Drawing.Color.White;
            this.gridUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridUsuario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridUsuario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridUsuario.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridUsuario.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridUsuario.DoubleBuffered = true;
            this.gridUsuario.EnableHeadersVisualStyles = false;
            this.gridUsuario.GridColor = System.Drawing.Color.WhiteSmoke;
            this.gridUsuario.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.gridUsuario.HeaderForeColor = System.Drawing.Color.White;
            this.gridUsuario.Location = new System.Drawing.Point(23, 208);
            this.gridUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.gridUsuario.Name = "gridUsuario";
            this.gridUsuario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridUsuario.RowHeadersVisible = false;
            this.gridUsuario.RowTemplate.DividerHeight = 1;
            this.gridUsuario.RowTemplate.Height = 30;
            this.gridUsuario.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUsuario.Size = new System.Drawing.Size(562, 197);
            this.gridUsuario.TabIndex = 63;
            this.gridUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(797, 414);
            this.Controls.Add(this.gridUsuario);
            this.Controls.Add(this.lblInativo);
            this.Controls.Add(this.lblId_Prontuario);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtProfessor);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblProfessor);
            this.Controls.Add(this.lblUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUsuario";
            this.Text = "frmUsuario";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tind4sDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 btnAtualizar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCadastrar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDeletar;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtSenha;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtProfessor;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblProfessor;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblId_Prontuario;
        private System.Windows.Forms.Label lblInativo;
        private tind4sDataSet1 tind4sDataSet1;
        private System.Windows.Forms.BindingSource tBUsuarioBindingSource;
        private tind4sDataSet1TableAdapters.TB_UsuarioTableAdapter tB_UsuarioTableAdapter;
        private Bunifu.Framework.UI.BunifuCustomDataGrid gridUsuario;

    }
}