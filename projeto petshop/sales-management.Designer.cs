namespace projeto_petshop
{
    partial class sales_management
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
            this.add_sale = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.listar_vendas = new System.Windows.Forms.ListView();
            this.excluir = new System.Windows.Forms.Button();
            this.relatory = new System.Windows.Forms.Button();
            this.exclude = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // add_sale
            // 
            this.add_sale.Location = new System.Drawing.Point(12, 131);
            this.add_sale.Name = "add_sale";
            this.add_sale.Size = new System.Drawing.Size(108, 67);
            this.add_sale.TabIndex = 0;
            this.add_sale.Text = "Cadastrar";
            this.add_sale.UseVisualStyleBackColor = true;
            this.add_sale.Click += new System.EventHandler(this.add_sale_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(224, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Administrar Vendas";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(600, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "sair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listar_vendas
            // 
            this.listar_vendas.Location = new System.Drawing.Point(12, 236);
            this.listar_vendas.Name = "listar_vendas";
            this.listar_vendas.Size = new System.Drawing.Size(663, 289);
            this.listar_vendas.TabIndex = 4;
            this.listar_vendas.UseCompatibleStateImageBehavior = false;
            // 
            // excluir
            // 
            this.excluir.Location = new System.Drawing.Point(160, 131);
            this.excluir.Name = "excluir";
            this.excluir.Size = new System.Drawing.Size(108, 67);
            this.excluir.TabIndex = 5;
            this.excluir.Text = "excluir";
            this.excluir.UseVisualStyleBackColor = true;
            this.excluir.Click += new System.EventHandler(this.excluir_Click);
            // 
            // relatory
            // 
            this.relatory.Location = new System.Drawing.Point(458, 132);
            this.relatory.Name = "relatory";
            this.relatory.Size = new System.Drawing.Size(108, 67);
            this.relatory.TabIndex = 6;
            this.relatory.Text = "vendas por produto";
            this.relatory.UseVisualStyleBackColor = true;
            this.relatory.Click += new System.EventHandler(this.relatory_Click_1);
            // 
            // exclude
            // 
            this.exclude.AutoSize = true;
            this.exclude.Location = new System.Drawing.Point(273, 157);
            this.exclude.Name = "exclude";
            this.exclude.Size = new System.Drawing.Size(127, 19);
            this.exclude.TabIndex = 7;
            this.exclude.Text = "confirmar exclusão";
            this.exclude.UseVisualStyleBackColor = true;
            // 
            // sales_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 537);
            this.Controls.Add(this.exclude);
            this.Controls.Add(this.relatory);
            this.Controls.Add(this.excluir);
            this.Controls.Add(this.listar_vendas);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add_sale);
            this.Name = "sales_management";
            this.Text = "sales_management";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button add_sale;
        private Label label1;
        private Button button2;
        private ListView listar_vendas;
        private Button excluir;
        private Button relatory;
        private CheckBox exclude;
    }
}