namespace GerenciadorDeVendas.Formularios
{
    partial class frmCompras
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
            this.cmbProdutos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbParcelas = new System.Windows.Forms.ComboBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.colValor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQuantidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colProduto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstProdutos = new System.Windows.Forms.ListView();
            this.btnInserir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbProdutos
            // 
            this.cmbProdutos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbProdutos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProdutos.FormattingEnabled = true;
            this.cmbProdutos.Location = new System.Drawing.Point(90, 84);
            this.cmbProdutos.Name = "cmbProdutos";
            this.cmbProdutos.Size = new System.Drawing.Size(547, 28);
            this.cmbProdutos.TabIndex = 89;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 87;
            this.label3.Text = "Parcelas:";
            // 
            // cmbParcelas
            // 
            this.cmbParcelas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParcelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbParcelas.FormattingEnabled = true;
            this.cmbParcelas.Location = new System.Drawing.Point(90, 125);
            this.cmbParcelas.Name = "cmbParcelas";
            this.cmbParcelas.Size = new System.Drawing.Size(269, 28);
            this.cmbParcelas.TabIndex = 86;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(741, 84);
            this.txtQuantidade.MaxLength = 2;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(47, 26);
            this.txtQuantidade.TabIndex = 85;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(643, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 84;
            this.label2.Text = "Quantidade:";
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.IndianRed;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExcluir.Location = new System.Drawing.Point(608, 297);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(180, 50);
            this.btnExcluir.TabIndex = 83;
            this.btnExcluir.Text = "Excluir Produto";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.EnabledChanged += new System.EventHandler(this.btnExcluir_EnabledChanged);
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(288, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(297, 37);
            this.label5.TabIndex = 78;
            this.label5.Text = "Gerenciar Compras";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(424, 125);
            this.txtTotal.MaxLength = 10;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(178, 26);
            this.txtTotal.TabIndex = 76;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(370, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 75;
            this.label4.Text = "Total:";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnFinalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFinalizar.Location = new System.Drawing.Point(608, 230);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(180, 50);
            this.btnFinalizar.TabIndex = 82;
            this.btnFinalizar.Text = "Finalizar Pedido";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // colValor
            // 
            this.colValor.Text = "Valor";
            this.colValor.Width = 98;
            // 
            // colQuantidade
            // 
            this.colQuantidade.Text = "Quantidade";
            this.colQuantidade.Width = 103;
            // 
            // colProduto
            // 
            this.colProduto.Text = "Produto";
            this.colProduto.Width = 359;
            // 
            // lstProdutos
            // 
            this.lstProdutos.AllowColumnReorder = true;
            this.lstProdutos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colProduto,
            this.colQuantidade,
            this.colValor});
            this.lstProdutos.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lstProdutos.FullRowSelect = true;
            this.lstProdutos.GridLines = true;
            this.lstProdutos.HideSelection = false;
            this.lstProdutos.LabelEdit = true;
            this.lstProdutos.Location = new System.Drawing.Point(15, 159);
            this.lstProdutos.MultiSelect = false;
            this.lstProdutos.Name = "lstProdutos";
            this.lstProdutos.Size = new System.Drawing.Size(587, 188);
            this.lstProdutos.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lstProdutos.TabIndex = 81;
            this.lstProdutos.UseCompatibleStateImageBehavior = false;
            this.lstProdutos.View = System.Windows.Forms.View.Details;
            this.lstProdutos.SelectedIndexChanged += new System.EventHandler(this.lstProdutos_SelectedIndexChanged);
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.Color.ForestGreen;
            this.btnInserir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInserir.Location = new System.Drawing.Point(608, 159);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(180, 50);
            this.btnInserir.TabIndex = 77;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 74;
            this.label1.Text = "Produto:";
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 355);
            this.Controls.Add(this.cmbProdutos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbParcelas);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.lstProdutos);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.label1);
            this.Name = "frmCompras";
            this.Text = "frmCompras";
            this.Load += new System.EventHandler(this.frmPedidos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbProdutos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbParcelas;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.ColumnHeader colValor;
        private System.Windows.Forms.ColumnHeader colQuantidade;
        private System.Windows.Forms.ColumnHeader colProduto;
        private System.Windows.Forms.ListView lstProdutos;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label label1;
    }
}