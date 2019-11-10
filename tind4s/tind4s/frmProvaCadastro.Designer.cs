namespace tind4s
{
    partial class frmProvaCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProvaCadastro));
            this.cbCurso = new System.Windows.Forms.ComboBox();
            this.lblCurso = new System.Windows.Forms.Label();
            this.cbMateria = new System.Windows.Forms.ComboBox();
            this.lblMateria = new System.Windows.Forms.Label();
            this.txtProva = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblIdProva = new System.Windows.Forms.Label();
            this.bunifuMetroTextbox1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblQuestao = new System.Windows.Forms.Label();
            this.lsMateria = new System.Windows.Forms.ListBox();
            this.btnInserirMateria = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnExcluirMateria = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // cbCurso
            // 
            this.cbCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbCurso.FormattingEnabled = true;
            this.cbCurso.Location = new System.Drawing.Point(92, 72);
            this.cbCurso.Margin = new System.Windows.Forms.Padding(8);
            this.cbCurso.Name = "cbCurso";
            this.cbCurso.Size = new System.Drawing.Size(222, 28);
            this.cbCurso.TabIndex = 81;
            this.cbCurso.SelectionChangeCommitted += new System.EventHandler(this.CbCurso_SelectedIndexChanged);
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.BackColor = System.Drawing.Color.Transparent;
            this.lblCurso.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.Location = new System.Drawing.Point(19, 79);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(66, 22);
            this.lblCurso.TabIndex = 80;
            this.lblCurso.Text = "Curso:";
            // 
            // cbMateria
            // 
            this.cbMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbMateria.FormattingEnabled = true;
            this.cbMateria.Location = new System.Drawing.Point(92, 114);
            this.cbMateria.Margin = new System.Windows.Forms.Padding(8);
            this.cbMateria.Name = "cbMateria";
            this.cbMateria.Size = new System.Drawing.Size(222, 28);
            this.cbMateria.TabIndex = 83;
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.BackColor = System.Drawing.Color.Transparent;
            this.lblMateria.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateria.Location = new System.Drawing.Point(9, 121);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(76, 22);
            this.lblMateria.TabIndex = 82;
            this.lblMateria.Text = "Materia:";
            // 
            // txtProva
            // 
            this.txtProva.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.txtProva.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtProva.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.txtProva.BorderThickness = 1;
            this.txtProva.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProva.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtProva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtProva.isPassword = false;
            this.txtProva.Location = new System.Drawing.Point(92, 31);
            this.txtProva.Margin = new System.Windows.Forms.Padding(4);
            this.txtProva.Name = "txtProva";
            this.txtProva.Size = new System.Drawing.Size(222, 29);
            this.txtProva.TabIndex = 85;
            this.txtProva.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(25, 38);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(0, 22);
            this.lblTitulo.TabIndex = 84;
            this.lblTitulo.Text = "Titulo:";
            // 
            // lblIdProva
            // 
            this.lblIdProva.AutoSize = true;
            this.lblIdProva.Location = new System.Drawing.Point(22, 9);
            this.lblIdProva.Name = "lblIdProva";
            this.lblIdProva.Size = new System.Drawing.Size(0, 13);
            this.lblIdProva.TabIndex = 86;
            this.lblIdProva.Visible = false;
            // 
            // bunifuMetroTextbox1
            // 
            this.bunifuMetroTextbox1.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.bunifuMetroTextbox1.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox1.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.bunifuMetroTextbox1.BorderThickness = 1;
            this.bunifuMetroTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMetroTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox1.isPassword = false;
            this.bunifuMetroTextbox1.Location = new System.Drawing.Point(136, 154);
            this.bunifuMetroTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox1.Name = "bunifuMetroTextbox1";
            this.bunifuMetroTextbox1.Size = new System.Drawing.Size(53, 29);
            this.bunifuMetroTextbox1.TabIndex = 88;
            this.bunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblQuestao
            // 
            this.lblQuestao.AutoSize = true;
            this.lblQuestao.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestao.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestao.Location = new System.Drawing.Point(6, 157);
            this.lblQuestao.Name = "lblQuestao";
            this.lblQuestao.Size = new System.Drawing.Size(123, 22);
            this.lblQuestao.TabIndex = 87;
            this.lblQuestao.Text = "Qtd Questão:";
            // 
            // lsMateria
            // 
            this.lsMateria.FormattingEnabled = true;
            this.lsMateria.Location = new System.Drawing.Point(325, 31);
            this.lsMateria.Name = "lsMateria";
            this.lsMateria.Size = new System.Drawing.Size(167, 238);
            this.lsMateria.TabIndex = 89;
            // 
            // btnInserirMateria
            // 
            this.btnInserirMateria.ActiveBorderThickness = 1;
            this.btnInserirMateria.ActiveCornerRadius = 20;
            this.btnInserirMateria.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.btnInserirMateria.ActiveForecolor = System.Drawing.Color.Silver;
            this.btnInserirMateria.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.btnInserirMateria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInserirMateria.BackColor = System.Drawing.Color.White;
            this.btnInserirMateria.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInserirMateria.BackgroundImage")));
            this.btnInserirMateria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInserirMateria.ButtonText = "Inserir";
            this.btnInserirMateria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInserirMateria.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirMateria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.btnInserirMateria.IdleBorderThickness = 1;
            this.btnInserirMateria.IdleCornerRadius = 20;
            this.btnInserirMateria.IdleFillColor = System.Drawing.Color.White;
            this.btnInserirMateria.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.btnInserirMateria.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.btnInserirMateria.Location = new System.Drawing.Point(199, 150);
            this.btnInserirMateria.Margin = new System.Windows.Forms.Padding(5);
            this.btnInserirMateria.Name = "btnInserirMateria";
            this.btnInserirMateria.Size = new System.Drawing.Size(73, 36);
            this.btnInserirMateria.TabIndex = 90;
            this.btnInserirMateria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExcluirMateria
            // 
            this.btnExcluirMateria.ActiveBorderThickness = 1;
            this.btnExcluirMateria.ActiveCornerRadius = 20;
            this.btnExcluirMateria.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.btnExcluirMateria.ActiveForecolor = System.Drawing.Color.Silver;
            this.btnExcluirMateria.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.btnExcluirMateria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluirMateria.BackColor = System.Drawing.Color.White;
            this.btnExcluirMateria.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcluirMateria.BackgroundImage")));
            this.btnExcluirMateria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExcluirMateria.ButtonText = "Excluir";
            this.btnExcluirMateria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirMateria.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirMateria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.btnExcluirMateria.IdleBorderThickness = 1;
            this.btnExcluirMateria.IdleCornerRadius = 20;
            this.btnExcluirMateria.IdleFillColor = System.Drawing.Color.White;
            this.btnExcluirMateria.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.btnExcluirMateria.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.btnExcluirMateria.Location = new System.Drawing.Point(417, 272);
            this.btnExcluirMateria.Margin = new System.Windows.Forms.Padding(5);
            this.btnExcluirMateria.Name = "btnExcluirMateria";
            this.btnExcluirMateria.Size = new System.Drawing.Size(73, 36);
            this.btnExcluirMateria.TabIndex = 91;
            this.btnExcluirMateria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.Silver;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.bunifuThinButton21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuThinButton21.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuThinButton21.ButtonText = "Gerar Prova";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.bunifuThinButton21.Location = new System.Drawing.Point(12, 192);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(305, 78);
            this.bunifuThinButton21.TabIndex = 92;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmProvaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(509, 313);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.btnExcluirMateria);
            this.Controls.Add(this.btnInserirMateria);
            this.Controls.Add(this.lsMateria);
            this.Controls.Add(this.bunifuMetroTextbox1);
            this.Controls.Add(this.lblQuestao);
            this.Controls.Add(this.lblIdProva);
            this.Controls.Add(this.txtProva);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.cbMateria);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.cbCurso);
            this.Controls.Add(this.lblCurso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProvaCadastro";
            this.Text = "frmProvaCadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCurso;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.ComboBox cbMateria;
        private System.Windows.Forms.Label lblMateria;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtProva;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblIdProva;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox1;
        private System.Windows.Forms.Label lblQuestao;
        private System.Windows.Forms.ListBox lsMateria;
        private Bunifu.Framework.UI.BunifuThinButton2 btnInserirMateria;
        private Bunifu.Framework.UI.BunifuThinButton2 btnExcluirMateria;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
    }
}