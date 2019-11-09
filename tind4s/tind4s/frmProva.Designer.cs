namespace tind4s
{
    partial class frmProva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProva));
            this.griProva = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnEditar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnNovo = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnDeletar = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.griProva)).BeginInit();
            this.SuspendLayout();
            // 
            // griProva
            // 
            this.griProva.AllowUserToAddRows = false;
            this.griProva.AllowUserToDeleteRows = false;
            this.griProva.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.griProva.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.griProva.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.griProva.BackgroundColor = System.Drawing.Color.White;
            this.griProva.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.griProva.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.griProva.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.griProva.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.griProva.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.griProva.DefaultCellStyle = dataGridViewCellStyle3;
            this.griProva.DoubleBuffered = true;
            this.griProva.EnableHeadersVisualStyles = false;
            this.griProva.GridColor = System.Drawing.Color.White;
            this.griProva.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.griProva.HeaderForeColor = System.Drawing.Color.White;
            this.griProva.Location = new System.Drawing.Point(15, 11);
            this.griProva.Margin = new System.Windows.Forms.Padding(2);
            this.griProva.Name = "griProva";
            this.griProva.ReadOnly = true;
            this.griProva.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.griProva.RowHeadersVisible = false;
            this.griProva.RowTemplate.DividerHeight = 1;
            this.griProva.RowTemplate.Height = 30;
            this.griProva.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.griProva.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.griProva.Size = new System.Drawing.Size(774, 373);
            this.griProva.TabIndex = 77;
            // 
            // btnEditar
            // 
            this.btnEditar.ActiveBorderThickness = 1;
            this.btnEditar.ActiveCornerRadius = 20;
            this.btnEditar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.btnEditar.ActiveForecolor = System.Drawing.Color.Silver;
            this.btnEditar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.Color.White;
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditar.ButtonText = "Editar";
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.btnEditar.IdleBorderThickness = 1;
            this.btnEditar.IdleCornerRadius = 20;
            this.btnEditar.IdleFillColor = System.Drawing.Color.White;
            this.btnEditar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.btnEditar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.btnEditar.Location = new System.Drawing.Point(439, 391);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(110, 45);
            this.btnEditar.TabIndex = 75;
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnNovo.Location = new System.Drawing.Point(679, 391);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(5);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(110, 45);
            this.btnNovo.TabIndex = 73;
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnDeletar.Location = new System.Drawing.Point(559, 391);
            this.btnDeletar.Margin = new System.Windows.Forms.Padding(5);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(110, 42);
            this.btnDeletar.TabIndex = 74;
            this.btnDeletar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmProva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.griProva);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnDeletar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProva";
            this.Text = "frmProva";
            ((System.ComponentModel.ISupportInitialize)(this.griProva)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 btnEditar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnNovo;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDeletar;
        private Bunifu.Framework.UI.BunifuCustomDataGrid griProva;
    }
}