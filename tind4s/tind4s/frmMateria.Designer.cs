﻿namespace tind4s
{
    partial class frmMateria
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMateria));
            this.gridMateria = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtSigla = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtMateria = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblSigla = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.btnSalvar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnNovo = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnDeletar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblIdMateria = new System.Windows.Forms.Label();
            this.cbCurso = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridMateria)).BeginInit();
            this.SuspendLayout();
            // 
            // gridMateria
            // 
            this.gridMateria.AllowUserToAddRows = false;
            this.gridMateria.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.gridMateria.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.gridMateria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridMateria.BackgroundColor = System.Drawing.Color.White;
            this.gridMateria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridMateria.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridMateria.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridMateria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.gridMateria.ColumnHeadersHeight = 40;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridMateria.DefaultCellStyle = dataGridViewCellStyle12;
            this.gridMateria.DoubleBuffered = true;
            this.gridMateria.EnableHeadersVisualStyles = false;
            this.gridMateria.GridColor = System.Drawing.Color.White;
            this.gridMateria.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.gridMateria.HeaderForeColor = System.Drawing.Color.White;
            this.gridMateria.Location = new System.Drawing.Point(11, 11);
            this.gridMateria.Margin = new System.Windows.Forms.Padding(2);
            this.gridMateria.Name = "gridMateria";
            this.gridMateria.ReadOnly = true;
            this.gridMateria.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridMateria.RowHeadersVisible = false;
            this.gridMateria.RowTemplate.DividerHeight = 1;
            this.gridMateria.RowTemplate.Height = 30;
            this.gridMateria.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridMateria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMateria.Size = new System.Drawing.Size(774, 197);
            this.gridMateria.TabIndex = 76;
            this.gridMateria.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelecionaMateria);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(12, 363);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(65, 13);
            this.lblResultado.TabIndex = 73;
            this.lblResultado.Text = "lblResultado";
            this.lblResultado.Visible = false;
            // 
            // txtSigla
            // 
            this.txtSigla.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.txtSigla.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSigla.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.txtSigla.BorderThickness = 1;
            this.txtSigla.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSigla.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSigla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSigla.isPassword = false;
            this.txtSigla.Location = new System.Drawing.Point(87, 276);
            this.txtSigla.Margin = new System.Windows.Forms.Padding(4);
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Size = new System.Drawing.Size(222, 29);
            this.txtSigla.TabIndex = 69;
            this.txtSigla.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtMateria
            // 
            this.txtMateria.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.txtMateria.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMateria.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.txtMateria.BorderThickness = 1;
            this.txtMateria.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMateria.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtMateria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMateria.isPassword = false;
            this.txtMateria.Location = new System.Drawing.Point(87, 231);
            this.txtMateria.Margin = new System.Windows.Forms.Padding(4);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(222, 29);
            this.txtMateria.TabIndex = 67;
            this.txtMateria.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblSigla
            // 
            this.lblSigla.AutoSize = true;
            this.lblSigla.BackColor = System.Drawing.Color.Transparent;
            this.lblSigla.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSigla.Location = new System.Drawing.Point(21, 278);
            this.lblSigla.Name = "lblSigla";
            this.lblSigla.Size = new System.Drawing.Size(57, 22);
            this.lblSigla.TabIndex = 64;
            this.lblSigla.Text = "Sigla:";
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.BackColor = System.Drawing.Color.Transparent;
            this.lblCurso.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.Location = new System.Drawing.Point(323, 233);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(66, 22);
            this.lblCurso.TabIndex = 65;
            this.lblCurso.Text = "Curso:";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.BackColor = System.Drawing.Color.Transparent;
            this.lblMateria.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateria.Location = new System.Drawing.Point(12, 233);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(66, 22);
            this.lblMateria.TabIndex = 66;
            this.lblMateria.Text = "Nome:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.ActiveBorderThickness = 1;
            this.btnSalvar.ActiveCornerRadius = 20;
            this.btnSalvar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.btnSalvar.ActiveForecolor = System.Drawing.Color.Silver;
            this.btnSalvar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.BackColor = System.Drawing.Color.White;
            this.btnSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalvar.BackgroundImage")));
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalvar.ButtonText = "Salvar";
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.btnSalvar.IdleBorderThickness = 1;
            this.btnSalvar.IdleCornerRadius = 20;
            this.btnSalvar.IdleFillColor = System.Drawing.Color.White;
            this.btnSalvar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.btnSalvar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.btnSalvar.Location = new System.Drawing.Point(675, 215);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(5);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(110, 45);
            this.btnSalvar.TabIndex = 72;
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.ActiveBorderThickness = 1;
            this.btnNovo.ActiveCornerRadius = 20;
            this.btnNovo.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.btnNovo.ActiveForecolor = System.Drawing.Color.White;
            this.btnNovo.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovo.BackColor = System.Drawing.Color.White;
            this.btnNovo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNovo.BackgroundImage")));
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNovo.ButtonText = "Novo";
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.btnNovo.IdleBorderThickness = 1;
            this.btnNovo.IdleCornerRadius = 20;
            this.btnNovo.IdleFillColor = System.Drawing.Color.White;
            this.btnNovo.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.btnNovo.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.btnNovo.Location = new System.Drawing.Point(675, 285);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(5);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(110, 45);
            this.btnNovo.TabIndex = 70;
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
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
            this.btnDeletar.Location = new System.Drawing.Point(675, 358);
            this.btnDeletar.Margin = new System.Windows.Forms.Padding(5);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(110, 42);
            this.btnDeletar.TabIndex = 71;
            this.btnDeletar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeletar.Click += new System.EventHandler(this.BtnDeletar_Click);
            // 
            // lblIdMateria
            // 
            this.lblIdMateria.AutoSize = true;
            this.lblIdMateria.Location = new System.Drawing.Point(12, 210);
            this.lblIdMateria.Name = "lblIdMateria";
            this.lblIdMateria.Size = new System.Drawing.Size(0, 13);
            this.lblIdMateria.TabIndex = 77;
            this.lblIdMateria.Visible = false;
            // 
            // cbCurso
            // 
            this.cbCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbCurso.FormattingEnabled = true;
            this.cbCurso.Location = new System.Drawing.Point(388, 232);
            this.cbCurso.Margin = new System.Windows.Forms.Padding(8);
            this.cbCurso.Name = "cbCurso";
            this.cbCurso.Size = new System.Drawing.Size(224, 28);
            this.cbCurso.TabIndex = 79;
            // 
            // frmMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(797, 414);
            this.Controls.Add(this.cbCurso);
            this.Controls.Add(this.lblIdMateria);
            this.Controls.Add(this.gridMateria);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.txtSigla);
            this.Controls.Add(this.txtMateria);
            this.Controls.Add(this.lblSigla);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.lblMateria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMateria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMateria";
            this.Load += new System.EventHandler(this.FrmMateria_Load);
            this.Resize += new System.EventHandler(this.Redimensionar);
            ((System.ComponentModel.ISupportInitialize)(this.gridMateria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid gridMateria;
        private System.Windows.Forms.Label lblResultado;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSalvar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnNovo;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDeletar;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtSigla;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtMateria;
        private System.Windows.Forms.Label lblSigla;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label lblIdMateria;
        private System.Windows.Forms.ComboBox cbCurso;
    }
}