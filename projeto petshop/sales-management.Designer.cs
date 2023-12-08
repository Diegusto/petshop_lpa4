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
            add_sale = new Button();
            label1 = new Label();
            button2 = new Button();
            listar_vendas = new ListView();
            SuspendLayout();
            // 
            // add_sale
            // 
            add_sale.Location = new Point(12, 131);
            add_sale.Name = "add_sale";
            add_sale.Size = new Size(108, 67);
            add_sale.TabIndex = 0;
            add_sale.Text = "Cadastrar";
            add_sale.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(224, 76);
            label1.Name = "label1";
            label1.Size = new Size(246, 37);
            label1.TabIndex = 1;
            label1.Text = "Administrar Vendas";
            // 
            // button2
            // 
            button2.Location = new Point(405, 153);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "sair";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listar_vendas
            // 
            listar_vendas.Location = new Point(12, 236);
            listar_vendas.Name = "listar_vendas";
            listar_vendas.Size = new Size(663, 289);
            listar_vendas.TabIndex = 4;
            listar_vendas.UseCompatibleStateImageBehavior = false;
            // 
            // sales_management
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 537);
            Controls.Add(listar_vendas);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(add_sale);
            Name = "sales_management";
            Text = "sales_management";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button add_sale;
        private Label label1;
        private Button button2;
        private ListView listar_vendas;
    }
}