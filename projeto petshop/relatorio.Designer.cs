namespace projeto_petshop
{
    partial class relatorio
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
            label1 = new Label();
            label2 = new Label();
            product_name = new TextBox();
            relatorio_vendas = new ListView();
            search = new Button();
            exit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(225, 109);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 0;
            label1.Text = "nome do produto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(259, 35);
            label2.Name = "label2";
            label2.Size = new Size(251, 37);
            label2.TabIndex = 3;
            label2.Text = "Vendas Por Produto";
            // 
            // product_name
            // 
            product_name.Location = new Point(335, 106);
            product_name.Name = "product_name";
            product_name.Size = new Size(100, 23);
            product_name.TabIndex = 4;
            // 
            // relatorio_vendas
            // 
            relatorio_vendas.Location = new Point(12, 181);
            relatorio_vendas.Name = "relatorio_vendas";
            relatorio_vendas.Size = new Size(776, 257);
            relatorio_vendas.TabIndex = 5;
            relatorio_vendas.UseCompatibleStateImageBehavior = false;
            // 
            // search
            // 
            search.Location = new Point(344, 135);
            search.Name = "search";
            search.Size = new Size(75, 23);
            search.TabIndex = 6;
            search.Text = "buscar";
            search.UseVisualStyleBackColor = true;
            search.Click += search_Click;
            // 
            // exit
            // 
            exit.Location = new Point(691, 35);
            exit.Name = "exit";
            exit.Size = new Size(75, 23);
            exit.TabIndex = 7;
            exit.Text = "sair";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // relatorio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(exit);
            Controls.Add(search);
            Controls.Add(relatorio_vendas);
            Controls.Add(product_name);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "relatorio";
            Text = "relatorio";
            Load += relatorio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox product_name;
        private ListView relatorio_vendas;
        private Button search;
        private Button exit;
    }
}