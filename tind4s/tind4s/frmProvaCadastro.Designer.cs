﻿namespace tind4s
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
            this.txtQtd = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblQuestao = new System.Windows.Forms.Label();
            this.btnInserirMateria = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnExcluirMateria = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dgvMateria = new System.Windows.Forms.DataGridView();
            this.btnSair = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateria)).BeginInit();
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
            this.lblTitulo.Size = new System.Drawing.Size(60, 22);
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
            // txtQtd
            // 
            this.txtQtd.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.txtQtd.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtQtd.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.txtQtd.BorderThickness = 1;
            this.txtQtd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQtd.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtQtd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtQtd.isPassword = false;
            this.txtQtd.Location = new System.Drawing.Point(136, 154);
            this.txtQtd.Margin = new System.Windows.Forms.Padding(4);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(53, 29);
            this.txtQtd.TabIndex = 88;
            this.txtQtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtQtd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numerico);
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
            // btnInserirMateria
            // 
            this.btnInserirMateria.ActiveBorderThickness = 1;
            this.btnInserirMateria.ActiveCornerRadius = 20;
            this.btnInserirMateria.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.btnInserirMateria.ActiveForecolor = System.Drawing.Color.White;
            this.btnInserirMateria.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.btnInserirMateria.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.btnInserirMateria.Click += new System.EventHandler(this.BtnInserirMateria_Click);
            // 
            // btnExcluirMateria
            // 
            this.btnExcluirMateria.ActiveBorderThickness = 1;
            this.btnExcluirMateria.ActiveCornerRadius = 20;
            this.btnExcluirMateria.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.btnExcluirMateria.ActiveForecolor = System.Drawing.Color.White;
            this.btnExcluirMateria.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
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
            this.btnExcluirMateria.Location = new System.Drawing.Point(332, 194);
            this.btnExcluirMateria.Margin = new System.Windows.Forms.Padding(5);
            this.btnExcluirMateria.Name = "btnExcluirMateria";
            this.btnExcluirMateria.Size = new System.Drawing.Size(163, 36);
            this.btnExcluirMateria.TabIndex = 91;
            this.btnExcluirMateria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExcluirMateria.Click += new System.EventHandler(this.BtnExcluirMateria_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
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
            this.bunifuThinButton21.Location = new System.Drawing.Point(9, 194);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(305, 78);
            this.bunifuThinButton21.TabIndex = 92;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.BunifuThinButton21_Click);
            // 
            // dgvMateria
            // 
            this.dgvMateria.AllowUserToAddRows = false;
            this.dgvMateria.AllowUserToDeleteRows = false;
            this.dgvMateria.AllowUserToOrderColumns = true;
            this.dgvMateria.AllowUserToResizeColumns = false;
            this.dgvMateria.AllowUserToResizeRows = false;
            this.dgvMateria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMateria.BackgroundColor = System.Drawing.Color.White;
            this.dgvMateria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMateria.EnableHeadersVisualStyles = false;
            this.dgvMateria.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvMateria.Location = new System.Drawing.Point(332, 12);
            this.dgvMateria.MultiSelect = false;
            this.dgvMateria.Name = "dgvMateria";
            this.dgvMateria.ReadOnly = true;
            this.dgvMateria.RowHeadersVisible = false;
            this.dgvMateria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMateria.Size = new System.Drawing.Size(165, 174);
            this.dgvMateria.TabIndex = 93;
            // 
            // btnSair
            // 
            this.btnSair.ActiveBorderThickness = 1;
            this.btnSair.ActiveCornerRadius = 20;
            this.btnSair.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.btnSair.ActiveForecolor = System.Drawing.Color.White;
            this.btnSair.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.btnSair.BackColor = System.Drawing.Color.White;
            this.btnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSair.BackgroundImage")));
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSair.ButtonText = "Sair";
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.btnSair.IdleBorderThickness = 1;
            this.btnSair.IdleCornerRadius = 20;
            this.btnSair.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.btnSair.IdleForecolor = System.Drawing.Color.White;
            this.btnSair.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.btnSair.Location = new System.Drawing.Point(424, 236);
            this.btnSair.Margin = new System.Windows.Forms.Padding(5);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(73, 36);
            this.btnSair.TabIndex = 94;
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // frmProvaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(509, 274);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.dgvMateria);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.btnExcluirMateria);
            this.Controls.Add(this.btnInserirMateria);
            this.Controls.Add(this.txtQtd);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmProvaCadastro";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateria)).EndInit();
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
        private Bunifu.Framework.UI.BunifuMetroTextbox txtQtd;
        private System.Windows.Forms.Label lblQuestao;
        private Bunifu.Framework.UI.BunifuThinButton2 btnInserirMateria;
        private Bunifu.Framework.UI.BunifuThinButton2 btnExcluirMateria;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.DataGridView dgvMateria;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSair;
    }
}