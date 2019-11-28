namespace tind4s
{
    partial class frmCurso
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCurso));
            this.dgvCurso = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnSalvar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnNovo = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnDeletar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtAbrev = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtCurso = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblAbrev = new System.Windows.Forms.Label();
            this.lblNmCurso = new System.Windows.Forms.Label();
            this.lblId_Curso = new System.Windows.Forms.Label();
            this.lblIdCurso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCurso
            // 
            this.dgvCurso.AllowUserToAddRows = false;
            this.dgvCurso.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvCurso.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCurso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCurso.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvCurso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCurso.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCurso.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCurso.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCurso.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCurso.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCurso.DoubleBuffered = true;
            this.dgvCurso.EnableHeadersVisualStyles = false;
            this.dgvCurso.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvCurso.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.dgvCurso.HeaderForeColor = System.Drawing.Color.White;
            this.dgvCurso.Location = new System.Drawing.Point(9, 9);
            this.dgvCurso.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCurso.Name = "dgvCurso";
            this.dgvCurso.ReadOnly = true;
            this.dgvCurso.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCurso.RowHeadersVisible = false;
            this.dgvCurso.RowHeadersWidth = 51;
            this.dgvCurso.RowTemplate.DividerHeight = 1;
            this.dgvCurso.RowTemplate.Height = 30;
            this.dgvCurso.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCurso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCurso.Size = new System.Drawing.Size(780, 197);
            this.dgvCurso.TabIndex = 75;
            this.dgvCurso.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelecionarCurso);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(6, 248);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(65, 13);
            this.lblResultado.TabIndex = 73;
            this.lblResultado.Text = "lblResultado";
            // 
            // btnSalvar
            // 
            this.btnSalvar.ActiveBorderThickness = 1;
            this.btnSalvar.ActiveCornerRadius = 20;
            this.btnSalvar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.btnSalvar.ActiveForecolor = System.Drawing.Color.White;
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
            this.btnSalvar.Location = new System.Drawing.Point(454, 213);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(5);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(95, 45);
            this.btnSalvar.TabIndex = 72;
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
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
            this.btnNovo.Location = new System.Drawing.Point(559, 213);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(5);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(110, 45);
            this.btnNovo.TabIndex = 70;
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
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
            this.btnDeletar.Location = new System.Drawing.Point(679, 213);
            this.btnDeletar.Margin = new System.Windows.Forms.Padding(5);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(110, 45);
            this.btnDeletar.TabIndex = 71;
            this.btnDeletar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click_1);
            // 
            // txtAbrev
            // 
            this.txtAbrev.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.txtAbrev.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAbrev.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.txtAbrev.BorderThickness = 1;
            this.txtAbrev.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAbrev.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAbrev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAbrev.isPassword = false;
            this.txtAbrev.Location = new System.Drawing.Point(346, 222);
            this.txtAbrev.Margin = new System.Windows.Forms.Padding(4);
            this.txtAbrev.Name = "txtAbrev";
            this.txtAbrev.Size = new System.Drawing.Size(86, 29);
            this.txtAbrev.TabIndex = 69;
            this.txtAbrev.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtCurso
            // 
            this.txtCurso.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.txtCurso.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCurso.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.txtCurso.BorderThickness = 1;
            this.txtCurso.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCurso.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCurso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCurso.isPassword = false;
            this.txtCurso.Location = new System.Drawing.Point(88, 222);
            this.txtCurso.Margin = new System.Windows.Forms.Padding(4);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(187, 28);
            this.txtCurso.TabIndex = 67;
            this.txtCurso.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblAbrev
            // 
            this.lblAbrev.AutoSize = true;
            this.lblAbrev.BackColor = System.Drawing.Color.Transparent;
            this.lblAbrev.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbrev.Location = new System.Drawing.Point(282, 225);
            this.lblAbrev.Name = "lblAbrev";
            this.lblAbrev.Size = new System.Drawing.Size(57, 22);
            this.lblAbrev.TabIndex = 64;
            this.lblAbrev.Text = "Sigla:";
            // 
            // lblNmCurso
            // 
            this.lblNmCurso.AutoSize = true;
            this.lblNmCurso.BackColor = System.Drawing.Color.Transparent;
            this.lblNmCurso.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNmCurso.Location = new System.Drawing.Point(16, 225);
            this.lblNmCurso.Name = "lblNmCurso";
            this.lblNmCurso.Size = new System.Drawing.Size(66, 22);
            this.lblNmCurso.TabIndex = 66;
            this.lblNmCurso.Text = "Nome:";
            // 
            // lblId_Curso
            // 
            this.lblId_Curso.AutoSize = true;
            this.lblId_Curso.Location = new System.Drawing.Point(26, 245);
            this.lblId_Curso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId_Curso.Name = "lblId_Curso";
            this.lblId_Curso.Size = new System.Drawing.Size(0, 13);
            this.lblId_Curso.TabIndex = 76;
            // 
            // lblIdCurso
            // 
            this.lblIdCurso.AutoSize = true;
            this.lblIdCurso.Location = new System.Drawing.Point(6, 225);
            this.lblIdCurso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdCurso.Name = "lblIdCurso";
            this.lblIdCurso.Size = new System.Drawing.Size(0, 13);
            this.lblIdCurso.TabIndex = 77;
            // 
            // frmCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 267);
            this.Controls.Add(this.lblIdCurso);
            this.Controls.Add(this.lblId_Curso);
            this.Controls.Add(this.dgvCurso);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.txtAbrev);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.lblAbrev);
            this.Controls.Add(this.lblNmCurso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmCurso";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvCurso;
        private System.Windows.Forms.Label lblResultado;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSalvar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnNovo;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDeletar;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtAbrev;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtCurso;
        private System.Windows.Forms.Label lblAbrev;
        private System.Windows.Forms.Label lblNmCurso;
        private System.Windows.Forms.Label lblId_Curso;
        private System.Windows.Forms.Label lblIdCurso;
    }
}