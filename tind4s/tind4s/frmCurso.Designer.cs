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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCurso));
            this.gridCurso = new Bunifu.Framework.UI.BunifuCustomDataGrid();
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
            ((System.ComponentModel.ISupportInitialize)(this.gridCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCurso
            // 
            this.gridCurso.AllowUserToAddRows = false;
            this.gridCurso.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.gridCurso.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridCurso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCurso.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gridCurso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridCurso.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridCurso.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCurso.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridCurso.ColumnHeadersHeight = 40;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridCurso.DefaultCellStyle = dataGridViewCellStyle6;
            this.gridCurso.DoubleBuffered = true;
            this.gridCurso.EnableHeadersVisualStyles = false;
            this.gridCurso.GridColor = System.Drawing.Color.WhiteSmoke;
            this.gridCurso.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.gridCurso.HeaderForeColor = System.Drawing.Color.White;
            this.gridCurso.Location = new System.Drawing.Point(12, 11);
            this.gridCurso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridCurso.Name = "gridCurso";
            this.gridCurso.ReadOnly = true;
            this.gridCurso.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridCurso.RowHeadersVisible = false;
            this.gridCurso.RowHeadersWidth = 51;
            this.gridCurso.RowTemplate.DividerHeight = 1;
            this.gridCurso.RowTemplate.Height = 30;
            this.gridCurso.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridCurso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCurso.Size = new System.Drawing.Size(1040, 242);
            this.gridCurso.TabIndex = 75;
            this.gridCurso.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelecionarCurso);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(8, 305);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(86, 17);
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
            this.btnSalvar.Location = new System.Drawing.Point(585, 262);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(147, 55);
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
            this.btnNovo.Location = new System.Drawing.Point(745, 262);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(147, 55);
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
            this.btnDeletar.Location = new System.Drawing.Point(905, 262);
            this.btnDeletar.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(147, 55);
            this.btnDeletar.TabIndex = 71;
            this.btnDeletar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.txtAbrev.Location = new System.Drawing.Point(461, 273);
            this.txtAbrev.Margin = new System.Windows.Forms.Padding(5);
            this.txtAbrev.Name = "txtAbrev";
            this.txtAbrev.Size = new System.Drawing.Size(112, 36);
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
            this.txtCurso.Location = new System.Drawing.Point(117, 273);
            this.txtCurso.Margin = new System.Windows.Forms.Padding(5);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(256, 34);
            this.txtCurso.TabIndex = 67;
            this.txtCurso.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblAbrev
            // 
            this.lblAbrev.AutoSize = true;
            this.lblAbrev.BackColor = System.Drawing.Color.Transparent;
            this.lblAbrev.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbrev.Location = new System.Drawing.Point(376, 277);
            this.lblAbrev.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAbrev.Name = "lblAbrev";
            this.lblAbrev.Size = new System.Drawing.Size(73, 27);
            this.lblAbrev.TabIndex = 64;
            this.lblAbrev.Text = "Sigla:";
            // 
            // lblNmCurso
            // 
            this.lblNmCurso.AutoSize = true;
            this.lblNmCurso.BackColor = System.Drawing.Color.Transparent;
            this.lblNmCurso.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNmCurso.Location = new System.Drawing.Point(22, 277);
            this.lblNmCurso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNmCurso.Name = "lblNmCurso";
            this.lblNmCurso.Size = new System.Drawing.Size(82, 27);
            this.lblNmCurso.TabIndex = 66;
            this.lblNmCurso.Text = "Nome:";
            // 
            // lblId_Curso
            // 
            this.lblId_Curso.AutoSize = true;
            this.lblId_Curso.Location = new System.Drawing.Point(35, 302);
            this.lblId_Curso.Name = "lblId_Curso";
            this.lblId_Curso.Size = new System.Drawing.Size(0, 17);
            this.lblId_Curso.TabIndex = 76;
            // 
            // lblIdCurso
            // 
            this.lblIdCurso.AutoSize = true;
            this.lblIdCurso.Location = new System.Drawing.Point(8, 277);
            this.lblIdCurso.Name = "lblIdCurso";
            this.lblIdCurso.Size = new System.Drawing.Size(0, 17);
            this.lblIdCurso.TabIndex = 77;
            // 
            // frmCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 329);
            this.Controls.Add(this.lblIdCurso);
            this.Controls.Add(this.lblId_Curso);
            this.Controls.Add(this.gridCurso);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.txtAbrev);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.lblAbrev);
            this.Controls.Add(this.lblNmCurso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmCurso";
            this.Load += new System.EventHandler(this.FrmCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCurso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid gridCurso;
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