namespace GerenciadorDeVendas.Formularios
{
    partial class frmProdutos
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
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.colTamanho = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colValor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lstProdutos = new System.Windows.Forms.ListView();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblVoltar = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTamanho = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Gray;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLimpar.Location = new System.Drawing.Point(618, 138);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(170, 39);
            this.btnLimpar.TabIndex = 46;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.LightGray;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Enabled = false;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditar.Location = new System.Drawing.Point(209, 138);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(158, 39);
            this.btnEditar.TabIndex = 44;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.EnabledChanged += new System.EventHandler(this.btnEditar_EnabledChanged);
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // colTamanho
            // 
            this.colTamanho.Text = "Tamanho";
            this.colTamanho.Width = 388;
            // 
            // colValor
            // 
            this.colValor.Text = "Valor";
            this.colValor.Width = 347;
            // 
            // colNome
            // 
            this.colNome.Text = "Nome";
            this.colNome.Width = 154;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.LightGray;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExcluir.Location = new System.Drawing.Point(419, 138);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(158, 39);
            this.btnExcluir.TabIndex = 45;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.EnabledChanged += new System.EventHandler(this.btnExcluir_EnabledChanged);
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lstProdutos
            // 
            this.lstProdutos.AllowColumnReorder = true;
            this.lstProdutos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNome,
            this.colValor,
            this.colTamanho});
            this.lstProdutos.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lstProdutos.FullRowSelect = true;
            this.lstProdutos.GridLines = true;
            this.lstProdutos.HideSelection = false;
            this.lstProdutos.LabelEdit = true;
            this.lstProdutos.Location = new System.Drawing.Point(13, 209);
            this.lstProdutos.MultiSelect = false;
            this.lstProdutos.Name = "lstProdutos";
            this.lstProdutos.Size = new System.Drawing.Size(778, 188);
            this.lstProdutos.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lstProdutos.TabIndex = 43;
            this.lstProdutos.UseCompatibleStateImageBehavior = false;
            this.lstProdutos.View = System.Windows.Forms.View.Details;
            this.lstProdutos.SelectedIndexChanged += new System.EventHandler(this.lstProdutos_SelectedIndexChanged);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(86, 57);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(152, 26);
            this.txtID.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 20);
            this.label6.TabIndex = 41;
            this.label6.Text = "ID:";
            // 
            // lblVoltar
            // 
            this.lblVoltar.AutoSize = true;
            this.lblVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoltar.Location = new System.Drawing.Point(9, 6);
            this.lblVoltar.Name = "lblVoltar";
            this.lblVoltar.Size = new System.Drawing.Size(51, 20);
            this.lblVoltar.TabIndex = 40;
            this.lblVoltar.Text = "Voltar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(277, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(295, 37);
            this.label5.TabIndex = 39;
            this.label5.Text = "Gerenciar Produtos";
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.Color.ForestGreen;
            this.btnInserir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInserir.Location = new System.Drawing.Point(10, 138);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(158, 39);
            this.btnInserir.TabIndex = 38;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.EnabledChanged += new System.EventHandler(this.btnInserir_EnabledChanged);
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(522, 97);
            this.txtValor.MaxLength = 10;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(143, 26);
            this.txtValor.TabIndex = 36;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEndereco_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(466, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Valor:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(89, 97);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(371, 26);
            this.txtNome.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Nome:";
            // 
            // txtTamanho
            // 
            this.txtTamanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTamanho.Location = new System.Drawing.Point(751, 94);
            this.txtTamanho.MaxLength = 2;
            this.txtTamanho.Name = "txtTamanho";
            this.txtTamanho.Size = new System.Drawing.Size(32, 26);
            this.txtTamanho.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(671, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Tamanho:";
            // 
            // txtBusca
            // 
            this.txtBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusca.Location = new System.Drawing.Point(501, 183);
            this.txtBusca.MaxLength = 11;
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(287, 20);
            this.txtBusca.TabIndex = 50;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(452, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Buscar:";
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 406);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTamanho);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.lstProdutos);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblVoltar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "frmProdutos";
            this.Text = "frmProduto";
            this.Load += new System.EventHandler(this.frmProdutos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.ColumnHeader colTamanho;
        private System.Windows.Forms.ColumnHeader colValor;
        private System.Windows.Forms.ColumnHeader colNome;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.ListView lstProdutos;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblVoltar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTamanho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Label label7;
    }
}