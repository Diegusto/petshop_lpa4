namespace projeto_petshop
{
    partial class Form2
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
            Cad_Userbtn = new Button();
            Cad_Prodbtn = new Button();
            List_Prodbtn = new Button();
            Produtos = new ListBox();
            SuspendLayout();
            // 
            // Cad_Userbtn
            // 
            Cad_Userbtn.Location = new Point(77, 53);
            Cad_Userbtn.Name = "Cad_Userbtn";
            Cad_Userbtn.Size = new Size(155, 46);
            Cad_Userbtn.TabIndex = 0;
            Cad_Userbtn.Text = "Cadastrar Usuario";
            Cad_Userbtn.UseVisualStyleBackColor = true;
            Cad_Userbtn.Click += Cad_Userbtn_Click;
            // 
            // Cad_Prodbtn
            // 
            Cad_Prodbtn.Location = new Point(318, 53);
            Cad_Prodbtn.Name = "Cad_Prodbtn";
            Cad_Prodbtn.Size = new Size(156, 49);
            Cad_Prodbtn.TabIndex = 1;
            Cad_Prodbtn.Text = "Cadastrar Produto";
            Cad_Prodbtn.UseVisualStyleBackColor = true;
            Cad_Prodbtn.Click += Cad_Prodbtn_Click;
            // 
            // List_Prodbtn
            // 
            List_Prodbtn.Location = new Point(555, 52);
            List_Prodbtn.Name = "List_Prodbtn";
            List_Prodbtn.Size = new Size(186, 49);
            List_Prodbtn.TabIndex = 2;
            List_Prodbtn.Text = "Listar Produto";
            List_Prodbtn.UseVisualStyleBackColor = true;
            // 
            // Produtos
            // 
            Produtos.FormattingEnabled = true;
            Produtos.ItemHeight = 15;
            Produtos.Location = new Point(109, 132);
            Produtos.Name = "Produtos";
            Produtos.Size = new Size(540, 214);
            Produtos.TabIndex = 3;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 528);
            Controls.Add(Produtos);
            Controls.Add(List_Prodbtn);
            Controls.Add(Cad_Prodbtn);
            Controls.Add(Cad_Userbtn);
            Name = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Button Cad_Userbtn;
        private Button Cad_Prodbtn;
        private Button List_Prodbtn;
        private ListBox Produtos;
    }
}