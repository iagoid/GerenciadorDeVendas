namespace GerenciadorDeVendas.Formularios
{
    partial class frmFinancas
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
            this.lstCredito = new System.Windows.Forms.ListView();
            this.colPedido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colValor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQtdParcela = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblVoltar = new System.Windows.Forms.Label();
            this.dtFiltro = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lstDebito = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colParcelas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstCredito
            // 
            this.lstCredito.AllowColumnReorder = true;
            this.lstCredito.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPedido,
            this.colValor,
            this.colData,
            this.colQtdParcela});
            this.lstCredito.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lstCredito.FullRowSelect = true;
            this.lstCredito.GridLines = true;
            this.lstCredito.HideSelection = false;
            this.lstCredito.LabelEdit = true;
            this.lstCredito.Location = new System.Drawing.Point(16, 135);
            this.lstCredito.MultiSelect = false;
            this.lstCredito.Name = "lstCredito";
            this.lstCredito.Size = new System.Drawing.Size(778, 188);
            this.lstCredito.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lstCredito.TabIndex = 60;
            this.lstCredito.UseCompatibleStateImageBehavior = false;
            this.lstCredito.View = System.Windows.Forms.View.Details;
            // 
            // colPedido
            // 
            this.colPedido.Text = "Pedido";
            this.colPedido.Width = 154;
            // 
            // colValor
            // 
            this.colValor.Text = "Valor";
            this.colValor.Width = 347;
            // 
            // colData
            // 
            this.colData.Text = "Data";
            this.colData.Width = 388;
            // 
            // colQtdParcela
            // 
            this.colQtdParcela.Text = "Parcelar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(270, 20);
            this.label6.TabIndex = 58;
            this.label6.Text = "Selecione a data para gerar relatório:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(277, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(295, 37);
            this.label5.TabIndex = 56;
            this.label5.Text = "Gerenciar Produtos";
            // 
            // lblVoltar
            // 
            this.lblVoltar.AutoSize = true;
            this.lblVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoltar.Location = new System.Drawing.Point(9, 30);
            this.lblVoltar.Name = "lblVoltar";
            this.lblVoltar.Size = new System.Drawing.Size(51, 20);
            this.lblVoltar.TabIndex = 57;
            this.lblVoltar.Text = "Voltar";
            // 
            // dtFiltro
            // 
            this.dtFiltro.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFiltro.CustomFormat = "MM-yyyy";
            this.dtFiltro.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFiltro.Location = new System.Drawing.Point(288, 84);
            this.dtFiltro.MaxDate = new System.DateTime(9998, 12, 1, 0, 0, 0, 0);
            this.dtFiltro.Name = "dtFiltro";
            this.dtFiltro.Size = new System.Drawing.Size(87, 20);
            this.dtFiltro.TabIndex = 68;
            this.dtFiltro.Leave += new System.EventHandler(this.dtFiltro_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 69;
            this.label1.Text = "Total Crédito:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lstDebito
            // 
            this.lstDebito.AllowColumnReorder = true;
            this.lstDebito.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.colDate,
            this.colParcelas});
            this.lstDebito.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lstDebito.FullRowSelect = true;
            this.lstDebito.GridLines = true;
            this.lstDebito.HideSelection = false;
            this.lstDebito.LabelEdit = true;
            this.lstDebito.Location = new System.Drawing.Point(16, 364);
            this.lstDebito.MultiSelect = false;
            this.lstDebito.Name = "lstDebito";
            this.lstDebito.Size = new System.Drawing.Size(778, 188);
            this.lstDebito.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lstDebito.TabIndex = 70;
            this.lstDebito.UseCompatibleStateImageBehavior = false;
            this.lstDebito.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Pedido";
            this.columnHeader1.Width = 154;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Valor";
            this.columnHeader2.Width = 224;
            // 
            // colDate
            // 
            this.colDate.Text = "Data";
            this.colDate.Width = 131;
            // 
            // colParcelas
            // 
            this.colParcelas.Text = "Parcelas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 73;
            this.label4.Text = "Total Débito:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmFinancas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 564);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstDebito);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtFiltro);
            this.Controls.Add(this.lstCredito);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblVoltar);
            this.Name = "frmFinancas";
            this.Text = "frmFinancas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lstCredito;
        private System.Windows.Forms.ColumnHeader colPedido;
        private System.Windows.Forms.ColumnHeader colValor;
        private System.Windows.Forms.ColumnHeader colData;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblVoltar;
        private System.Windows.Forms.DateTimePicker dtFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader colQtdParcela;
        private System.Windows.Forms.ListView lstDebito;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader colDate;
        private System.Windows.Forms.ColumnHeader colParcelas;
        private System.Windows.Forms.Label label4;
    }
}