
using System;

namespace ProjetoContabilidade
{
    partial class PaginaInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaginaInicio));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LblDataInicial = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedDataInicial = new System.Windows.Forms.MaskedTextBox();
            this.maskedDataFinal = new System.Windows.Forms.MaskedTextBox();
            this.BtnCarregar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.checkBaixa = new System.Windows.Forms.CheckBox();
            this.checkAdiantamentos = new System.Windows.Forms.CheckBox();
            this.lblImagem = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_conectar = new System.Windows.Forms.Button();
            this.checkEventos = new System.Windows.Forms.CheckBox();
            this.checkCheque = new System.Windows.Forms.CheckBox();
            this.btn_Contabilizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblDataInicial
            // 
            this.LblDataInicial.AutoSize = true;
            this.LblDataInicial.BackColor = System.Drawing.Color.PowderBlue;
            this.LblDataInicial.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDataInicial.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblDataInicial.Location = new System.Drawing.Point(-2, 41);
            this.LblDataInicial.Name = "LblDataInicial";
            this.LblDataInicial.Size = new System.Drawing.Size(66, 20);
            this.LblDataInicial.TabIndex = 0;
            this.LblDataInicial.Text = "Data Inicial";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(83, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Final";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // maskedDataInicial
            // 
            this.maskedDataInicial.Location = new System.Drawing.Point(2, 57);
            this.maskedDataInicial.Mask = "00/00/0000";
            this.maskedDataInicial.Name = "maskedDataInicial";
            this.maskedDataInicial.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maskedDataInicial.Size = new System.Drawing.Size(75, 20);
            this.maskedDataInicial.TabIndex = 2;
            this.maskedDataInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedDataInicial.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedDataInicial_MaskInputRejected);
            this.maskedDataInicial.Click += new System.EventHandler(this.maskedDataInicial_Click);
            // 
            // maskedDataFinal
            // 
            this.maskedDataFinal.Location = new System.Drawing.Point(87, 57);
            this.maskedDataFinal.Mask = "00/00/0000";
            this.maskedDataFinal.Name = "maskedDataFinal";
            this.maskedDataFinal.Size = new System.Drawing.Size(80, 20);
            this.maskedDataFinal.TabIndex = 3;
            this.maskedDataFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedDataFinal.ValidatingType = typeof(System.DateTime);
            this.maskedDataFinal.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedDataFinal_MaskInputRejected);
            // 
            // BtnCarregar
            // 
            this.BtnCarregar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCarregar.BackColor = System.Drawing.Color.White;
            this.BtnCarregar.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCarregar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnCarregar.Location = new System.Drawing.Point(173, 55);
            this.BtnCarregar.Name = "BtnCarregar";
            this.BtnCarregar.Size = new System.Drawing.Size(101, 23);
            this.BtnCarregar.TabIndex = 13;
            this.BtnCarregar.Text = "Carregar Tabela";
            this.BtnCarregar.UseVisualStyleBackColor = false;
            this.BtnCarregar.Click += new System.EventHandler(this.BtnCarregar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSair.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(728, 83);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(63, 24);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // checkBaixa
            // 
            this.checkBaixa.AutoSize = true;
            this.checkBaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBaixa.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBaixa.Location = new System.Drawing.Point(111, 83);
            this.checkBaixa.Name = "checkBaixa";
            this.checkBaixa.Size = new System.Drawing.Size(52, 24);
            this.checkBaixa.TabIndex = 5;
            this.checkBaixa.Text = "Baixa";
            this.checkBaixa.UseVisualStyleBackColor = true;
            this.checkBaixa.CheckedChanged += new System.EventHandler(this.checkBaixa_CheckedChanged);
            this.checkBaixa.Click += new System.EventHandler(this.checkBaixa_Click);
            // 
            // checkAdiantamentos
            // 
            this.checkAdiantamentos.AutoSize = true;
            this.checkAdiantamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkAdiantamentos.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkAdiantamentos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkAdiantamentos.Location = new System.Drawing.Point(2, 83);
            this.checkAdiantamentos.Name = "checkAdiantamentos";
            this.checkAdiantamentos.Size = new System.Drawing.Size(103, 24);
            this.checkAdiantamentos.TabIndex = 4;
            this.checkAdiantamentos.Text = "Adiantamentos";
            this.checkAdiantamentos.UseVisualStyleBackColor = true;
            this.checkAdiantamentos.CheckedChanged += new System.EventHandler(this.checkAdiantamentos_CheckedChanged);
            // 
            // lblImagem
            // 
            this.lblImagem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblImagem.Image = ((System.Drawing.Image)(resources.GetObject("lblImagem.Image")));
            this.lblImagem.Location = new System.Drawing.Point(468, 41);
            this.lblImagem.Name = "lblImagem";
            this.lblImagem.Size = new System.Drawing.Size(244, 66);
            this.lblImagem.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(2, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.RowTemplate.DividerHeight = 1;
            this.dataGridView1.Size = new System.Drawing.Size(789, 407);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView1_RowPrePaint);
            // 
            // btn_conectar
            // 
            this.btn_conectar.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
            this.btn_conectar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_conectar.BackColor = System.Drawing.Color.Gray;
            this.btn_conectar.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_conectar.ForeColor = System.Drawing.Color.White;
            this.btn_conectar.Location = new System.Drawing.Point(2, 9);
            this.btn_conectar.Name = "btn_conectar";
            this.btn_conectar.Size = new System.Drawing.Size(75, 23);
            this.btn_conectar.TabIndex = 1;
            this.btn_conectar.Text = "Conectar";
            this.btn_conectar.UseVisualStyleBackColor = false;
            this.btn_conectar.Click += new System.EventHandler(this.btn_conectar_Click);
            // 
            // checkEventos
            // 
            this.checkEventos.AutoSize = true;
            this.checkEventos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkEventos.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEventos.Location = new System.Drawing.Point(169, 83);
            this.checkEventos.Name = "checkEventos";
            this.checkEventos.Size = new System.Drawing.Size(65, 24);
            this.checkEventos.TabIndex = 6;
            this.checkEventos.Text = "Eventos";
            this.checkEventos.UseVisualStyleBackColor = true;
            this.checkEventos.CheckedChanged += new System.EventHandler(this.checkEventos_CheckedChanged);
            // 
            // checkCheque
            // 
            this.checkCheque.AutoSize = true;
            this.checkCheque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkCheque.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkCheque.Location = new System.Drawing.Point(240, 83);
            this.checkCheque.Name = "checkCheque";
            this.checkCheque.Size = new System.Drawing.Size(112, 24);
            this.checkCheque.TabIndex = 7;
            this.checkCheque.Text = "Emissão cheques";
            this.checkCheque.UseVisualStyleBackColor = true;
            this.checkCheque.CheckedChanged += new System.EventHandler(this.checkCheque_CheckedChanged);
            // 
            // btn_Contabilizar
            // 
            this.btn_Contabilizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Contabilizar.BackColor = System.Drawing.Color.Gray;
            this.btn_Contabilizar.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Contabilizar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Contabilizar.Location = new System.Drawing.Point(361, 83);
            this.btn_Contabilizar.Name = "btn_Contabilizar";
            this.btn_Contabilizar.Size = new System.Drawing.Size(101, 23);
            this.btn_Contabilizar.TabIndex = 13;
            this.btn_Contabilizar.Text = "Contabilizar";
            this.btn_Contabilizar.UseVisualStyleBackColor = false;
            this.btn_Contabilizar.Click += new System.EventHandler(this.btn_Contabilizar_Click);
            // 
            // PaginaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(803, 532);
            this.Controls.Add(this.btn_Contabilizar);
            this.Controls.Add(this.checkCheque);
            this.Controls.Add(this.checkEventos);
            this.Controls.Add(this.btn_conectar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblImagem);
            this.Controls.Add(this.checkAdiantamentos);
            this.Controls.Add(this.checkBaixa);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.BtnCarregar);
            this.Controls.Add(this.maskedDataFinal);
            this.Controls.Add(this.maskedDataInicial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblDataInicial);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.Name = "PaginaInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Integração Contábil";
            this.Load += new System.EventHandler(this.PaginaInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblDataInicial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedDataInicial;
        private System.Windows.Forms.MaskedTextBox maskedDataFinal;
        private System.Windows.Forms.Button BtnCarregar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.CheckBox checkBaixa;
        private System.Windows.Forms.CheckBox checkAdiantamentos;
        private System.Windows.Forms.Label lblImagem;
        private EventHandler lblFormulario_Click;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_conectar;
        private System.Windows.Forms.CheckBox checkEventos;
        private System.Windows.Forms.CheckBox checkCheque;
        private System.Windows.Forms.Button btn_Contabilizar;
    }
}

