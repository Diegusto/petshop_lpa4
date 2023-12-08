namespace projeto_petshop
{
    partial class Product_management
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
            cad_prodbtn = new Button();
            returnbtn = new Button();
            List_Products = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(186, 71);
            label1.Name = "label1";
            label1.Size = new Size(268, 37);
            label1.TabIndex = 0;
            label1.Text = "Administrar Produtos";
            // 
            // cad_prodbtn
            // 
            cad_prodbtn.Location = new Point(33, 128);
            cad_prodbtn.Name = "cad_prodbtn";
            cad_prodbtn.Size = new Size(129, 68);
            cad_prodbtn.TabIndex = 1;
            cad_prodbtn.Text = "Cadastrar";
            cad_prodbtn.UseVisualStyleBackColor = true;
            cad_prodbtn.Click += cad_prodbtn_Click;
            // 
            // returnbtn
            // 
            returnbtn.Location = new Point(420, 151);
            returnbtn.Name = "returnbtn";
            returnbtn.Size = new Size(75, 23);
            returnbtn.TabIndex = 4;
            returnbtn.Text = "sair";
            returnbtn.UseVisualStyleBackColor = true;
            returnbtn.Click += returnbtn_Click;
            // 
            // List_Products
            // 
            List_Products.FormattingEnabled = true;
            List_Products.ItemHeight = 15;
            List_Products.Location = new Point(146, 202);
            List_Products.Name = "List_Products";
            List_Products.Size = new Size(324, 349);
            List_Products.TabIndex = 5;
            // 
            // Product_management
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 552);
            Controls.Add(List_Products);
            Controls.Add(returnbtn);
            Controls.Add(cad_prodbtn);
            Controls.Add(label1);
            Name = "Product_management";
            Text = "Product_management";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button cad_prodbtn;
        private Button returnbtn;
        private ListBox List_Products;
    }
}