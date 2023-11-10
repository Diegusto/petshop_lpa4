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
            list_sales = new ListBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // add_sale
            // 
            add_sale.Location = new Point(268, 131);
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
            // list_sales
            // 
            list_sales.FormattingEnabled = true;
            list_sales.ItemHeight = 15;
            list_sales.Location = new Point(-1, 218);
            list_sales.Name = "list_sales";
            list_sales.Size = new Size(687, 319);
            list_sales.TabIndex = 2;
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
            // sales_management
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 537);
            Controls.Add(button2);
            Controls.Add(list_sales);
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
        private ListBox list_sales;
        private Button button2;
    }
}