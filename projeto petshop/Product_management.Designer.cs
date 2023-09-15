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
            this.label1 = new System.Windows.Forms.Label();
            this.cad_prodbtn = new System.Windows.Forms.Button();
            this.edit_prodbtn = new System.Windows.Forms.Button();
            this.list_prodbtn = new System.Windows.Forms.Button();
            this.returnbtn = new System.Windows.Forms.Button();
            this.List_Products = new System.Windows.Forms.ListBox();
            this.remove_productbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(186, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrar Produtos";
            // 
            // cad_prodbtn
            // 
            this.cad_prodbtn.Location = new System.Drawing.Point(30, 143);
            this.cad_prodbtn.Name = "cad_prodbtn";
            this.cad_prodbtn.Size = new System.Drawing.Size(129, 68);
            this.cad_prodbtn.TabIndex = 1;
            this.cad_prodbtn.Text = "Cadastrar";
            this.cad_prodbtn.UseVisualStyleBackColor = true;
            this.cad_prodbtn.Click += new System.EventHandler(this.cad_prodbtn_Click);
            // 
            // edit_prodbtn
            // 
            this.edit_prodbtn.Location = new System.Drawing.Point(196, 143);
            this.edit_prodbtn.Name = "edit_prodbtn";
            this.edit_prodbtn.Size = new System.Drawing.Size(129, 68);
            this.edit_prodbtn.TabIndex = 2;
            this.edit_prodbtn.Text = "Editar";
            this.edit_prodbtn.UseVisualStyleBackColor = true;
            // 
            // list_prodbtn
            // 
            this.list_prodbtn.Location = new System.Drawing.Point(511, 143);
            this.list_prodbtn.Name = "list_prodbtn";
            this.list_prodbtn.Size = new System.Drawing.Size(129, 68);
            this.list_prodbtn.TabIndex = 3;
            this.list_prodbtn.Text = "Listar";
            this.list_prodbtn.UseVisualStyleBackColor = true;
            // 
            // returnbtn
            // 
            this.returnbtn.Location = new System.Drawing.Point(297, 234);
            this.returnbtn.Name = "returnbtn";
            this.returnbtn.Size = new System.Drawing.Size(75, 23);
            this.returnbtn.TabIndex = 4;
            this.returnbtn.Text = "sair";
            this.returnbtn.UseVisualStyleBackColor = true;
            this.returnbtn.Click += new System.EventHandler(this.returnbtn_Click);
            // 
            // List_Products
            // 
            this.List_Products.FormattingEnabled = true;
            this.List_Products.ItemHeight = 15;
            this.List_Products.Location = new System.Drawing.Point(79, 278);
            this.List_Products.Name = "List_Products";
            this.List_Products.Size = new System.Drawing.Size(511, 229);
            this.List_Products.TabIndex = 5;
            // 
            // remove_productbtn
            // 
            this.remove_productbtn.Location = new System.Drawing.Point(352, 143);
            this.remove_productbtn.Name = "remove_productbtn";
            this.remove_productbtn.Size = new System.Drawing.Size(129, 68);
            this.remove_productbtn.TabIndex = 6;
            this.remove_productbtn.Text = "Excluir";
            this.remove_productbtn.UseVisualStyleBackColor = true;
            // 
            // Product_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 552);
            this.Controls.Add(this.remove_productbtn);
            this.Controls.Add(this.List_Products);
            this.Controls.Add(this.returnbtn);
            this.Controls.Add(this.list_prodbtn);
            this.Controls.Add(this.edit_prodbtn);
            this.Controls.Add(this.cad_prodbtn);
            this.Controls.Add(this.label1);
            this.Name = "Product_management";
            this.Text = "Product_management";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button cad_prodbtn;
        private Button edit_prodbtn;
        private Button list_prodbtn;
        private Button returnbtn;
        private ListBox List_Products;
        private Button remove_productbtn;
    }
}