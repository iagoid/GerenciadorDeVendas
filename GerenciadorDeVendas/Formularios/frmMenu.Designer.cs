namespace GerenciadorDeVendas.Formularios
{
    partial class frmMenu
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
            this.txtBemVindo = new System.Windows.Forms.Label();
            this.btnGerenciarClientes = new System.Windows.Forms.Button();
            this.btnGerenciarPedidos = new System.Windows.Forms.Button();
            this.btnGerenciarProdutos = new System.Windows.Forms.Button();
            this.btnGerenciarCompras = new System.Windows.Forms.Button();
            this.btnGerenciarFinancas = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBemVindo
            // 
            this.txtBemVindo.AutoSize = true;
            this.txtBemVindo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBemVindo.Location = new System.Drawing.Point(300, 9);
            this.txtBemVindo.Name = "txtBemVindo";
            this.txtBemVindo.Size = new System.Drawing.Size(246, 31);
            this.txtBemVindo.TabIndex = 9;
            this.txtBemVindo.Text = "Bem Vindo Usuário";
            // 
            // btnGerenciarClientes
            // 
            this.btnGerenciarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciarClientes.Location = new System.Drawing.Point(306, 59);
            this.btnGerenciarClientes.Name = "btnGerenciarClientes";
            this.btnGerenciarClientes.Size = new System.Drawing.Size(240, 51);
            this.btnGerenciarClientes.TabIndex = 13;
            this.btnGerenciarClientes.Text = "Gerenciar Clientes";
            this.btnGerenciarClientes.UseVisualStyleBackColor = true;
            this.btnGerenciarClientes.Click += new System.EventHandler(this.btnGerenciarClientes_Click);
            // 
            // btnGerenciarPedidos
            // 
            this.btnGerenciarPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciarPedidos.Location = new System.Drawing.Point(306, 125);
            this.btnGerenciarPedidos.Name = "btnGerenciarPedidos";
            this.btnGerenciarPedidos.Size = new System.Drawing.Size(240, 51);
            this.btnGerenciarPedidos.TabIndex = 14;
            this.btnGerenciarPedidos.Text = "Gerenciar Pedidos";
            this.btnGerenciarPedidos.UseVisualStyleBackColor = true;
            this.btnGerenciarPedidos.Click += new System.EventHandler(this.btnGerenciarPedidos_Click);
            // 
            // btnGerenciarProdutos
            // 
            this.btnGerenciarProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciarProdutos.Location = new System.Drawing.Point(306, 195);
            this.btnGerenciarProdutos.Name = "btnGerenciarProdutos";
            this.btnGerenciarProdutos.Size = new System.Drawing.Size(240, 51);
            this.btnGerenciarProdutos.TabIndex = 15;
            this.btnGerenciarProdutos.Text = "Gerenciar Produtos";
            this.btnGerenciarProdutos.UseVisualStyleBackColor = true;
            this.btnGerenciarProdutos.Click += new System.EventHandler(this.btnGerenciarProdutos_Click);
            // 
            // btnGerenciarCompras
            // 
            this.btnGerenciarCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciarCompras.Location = new System.Drawing.Point(306, 266);
            this.btnGerenciarCompras.Name = "btnGerenciarCompras";
            this.btnGerenciarCompras.Size = new System.Drawing.Size(240, 51);
            this.btnGerenciarCompras.TabIndex = 16;
            this.btnGerenciarCompras.Text = "Gerenciar Compras";
            this.btnGerenciarCompras.UseVisualStyleBackColor = true;
            this.btnGerenciarCompras.Click += new System.EventHandler(this.btnGerenciarCompras_Click);
            // 
            // btnGerenciarFinancas
            // 
            this.btnGerenciarFinancas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciarFinancas.Location = new System.Drawing.Point(306, 333);
            this.btnGerenciarFinancas.Name = "btnGerenciarFinancas";
            this.btnGerenciarFinancas.Size = new System.Drawing.Size(240, 51);
            this.btnGerenciarFinancas.TabIndex = 17;
            this.btnGerenciarFinancas.Text = "Gerenciar Finanças";
            this.btnGerenciarFinancas.UseVisualStyleBackColor = true;
            this.btnGerenciarFinancas.Click += new System.EventHandler(this.btnGerenciarFinancas_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(306, 402);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(240, 51);
            this.btnSair.TabIndex = 18;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 501);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnGerenciarFinancas);
            this.Controls.Add(this.btnGerenciarCompras);
            this.Controls.Add(this.btnGerenciarProdutos);
            this.Controls.Add(this.btnGerenciarPedidos);
            this.Controls.Add(this.btnGerenciarClientes);
            this.Controls.Add(this.txtBemVindo);
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txtBemVindo;
        private System.Windows.Forms.Button btnGerenciarClientes;
        private System.Windows.Forms.Button btnGerenciarPedidos;
        private System.Windows.Forms.Button btnGerenciarProdutos;
        private System.Windows.Forms.Button btnGerenciarCompras;
        private System.Windows.Forms.Button btnGerenciarFinancas;
        private System.Windows.Forms.Button btnSair;
    }
}