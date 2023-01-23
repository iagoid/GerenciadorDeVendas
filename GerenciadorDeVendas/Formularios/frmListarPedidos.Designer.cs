namespace GerenciadorDeVendas.Formularios
{
    partial class frmListarPedidos
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
            this.label7 = new System.Windows.Forms.Label();
            this.colEndereco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTelefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.lstClientes = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNovoPedido = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(452, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Buscar:";
            // 
            // colEndereco
            // 
            this.colEndereco.Text = "Quantidade";
            this.colEndereco.Width = 281;
            // 
            // colTelefone
            // 
            this.colTelefone.Text = "Produtos";
            this.colTelefone.Width = 211;
            // 
            // colNome
            // 
            this.colNome.Text = "Cliente";
            this.colNome.Width = 154;
            // 
            // txtBusca
            // 
            this.txtBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusca.Location = new System.Drawing.Point(501, 72);
            this.txtBusca.MaxLength = 11;
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(287, 20);
            this.txtBusca.TabIndex = 2;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            // 
            // lstClientes
            // 
            this.lstClientes.AllowColumnReorder = true;
            this.lstClientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNome,
            this.colTelefone,
            this.colEndereco});
            this.lstClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstClientes.FullRowSelect = true;
            this.lstClientes.GridLines = true;
            this.lstClientes.HideSelection = false;
            this.lstClientes.LabelEdit = true;
            this.lstClientes.Location = new System.Drawing.Point(10, 98);
            this.lstClientes.MultiSelect = false;
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(778, 218);
            this.lstClientes.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lstClientes.TabIndex = 44;
            this.lstClientes.UseCompatibleStateImageBehavior = false;
            this.lstClientes.View = System.Windows.Forms.View.Details;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(273, -1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(281, 37);
            this.label5.TabIndex = 41;
            this.label5.Text = "Gerenciar Pedidos";
            // 
            // btnNovoPedido
            // 
            this.btnNovoPedido.BackColor = System.Drawing.Color.ForestGreen;
            this.btnNovoPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovoPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoPedido.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNovoPedido.Location = new System.Drawing.Point(10, 57);
            this.btnNovoPedido.Name = "btnNovoPedido";
            this.btnNovoPedido.Size = new System.Drawing.Size(210, 37);
            this.btnNovoPedido.TabIndex = 1;
            this.btnNovoPedido.Text = "Novo Pedido";
            this.btnNovoPedido.UseVisualStyleBackColor = false;
            this.btnNovoPedido.Click += new System.EventHandler(this.btnNovoPedido_Click);
            // 
            // frmListarPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 328);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.lstClientes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnNovoPedido);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListarPedidos";
            this.Text = "frmListarPedidos";
            this.Load += new System.EventHandler(this.frmListarPedidos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColumnHeader colEndereco;
        private System.Windows.Forms.ColumnHeader colTelefone;
        private System.Windows.Forms.ColumnHeader colNome;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.ListView lstClientes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNovoPedido;
    }
}