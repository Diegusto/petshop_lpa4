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
            this.Cad_Userbtn = new System.Windows.Forms.Button();
            this.Cad_Prodbtn = new System.Windows.Forms.Button();
            this.List_Prodbtn = new System.Windows.Forms.Button();
            this.Produtos = new System.Windows.Forms.ListBox();
            this.LogOutbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cad_Userbtn
            // 
            this.Cad_Userbtn.Location = new System.Drawing.Point(77, 53);
            this.Cad_Userbtn.Name = "Cad_Userbtn";
            this.Cad_Userbtn.Size = new System.Drawing.Size(155, 46);
            this.Cad_Userbtn.TabIndex = 0;
            this.Cad_Userbtn.Text = "Cadastrar Usuario";
            this.Cad_Userbtn.UseVisualStyleBackColor = true;
            this.Cad_Userbtn.Click += new System.EventHandler(this.Cad_Userbtn_Click_1);
            // 
            // Cad_Prodbtn
            // 
            this.Cad_Prodbtn.Location = new System.Drawing.Point(318, 53);
            this.Cad_Prodbtn.Name = "Cad_Prodbtn";
            this.Cad_Prodbtn.Size = new System.Drawing.Size(156, 49);
            this.Cad_Prodbtn.TabIndex = 1;
            this.Cad_Prodbtn.Text = "Cadastrar Produto";
            this.Cad_Prodbtn.UseVisualStyleBackColor = true;
            this.Cad_Prodbtn.Click += new System.EventHandler(this.Cad_Prodbtn_Click_1);
            // 
            // List_Prodbtn
            // 
            this.List_Prodbtn.Location = new System.Drawing.Point(555, 52);
            this.List_Prodbtn.Name = "List_Prodbtn";
            this.List_Prodbtn.Size = new System.Drawing.Size(186, 49);
            this.List_Prodbtn.TabIndex = 2;
            this.List_Prodbtn.Text = "Listar Produto";
            this.List_Prodbtn.UseVisualStyleBackColor = true;
            // 
            // Produtos
            // 
            this.Produtos.FormattingEnabled = true;
            this.Produtos.ItemHeight = 15;
            this.Produtos.Location = new System.Drawing.Point(109, 132);
            this.Produtos.Name = "Produtos";
            this.Produtos.Size = new System.Drawing.Size(540, 214);
            this.Produtos.TabIndex = 3;
            // 
            // LogOutbtn
            // 
            this.LogOutbtn.Location = new System.Drawing.Point(532, 431);
            this.LogOutbtn.Name = "LogOutbtn";
            this.LogOutbtn.Size = new System.Drawing.Size(86, 23);
            this.LogOutbtn.TabIndex = 4;
            this.LogOutbtn.Text = "desconectar";
            this.LogOutbtn.UseVisualStyleBackColor = true;
            this.LogOutbtn.Click += new System.EventHandler(this.LogOutbtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 528);
            this.Controls.Add(this.LogOutbtn);
            this.Controls.Add(this.Produtos);
            this.Controls.Add(this.List_Prodbtn);
            this.Controls.Add(this.Cad_Prodbtn);
            this.Controls.Add(this.Cad_Userbtn);
            this.Name = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private Button Cad_Userbtn;
        private Button Cad_Prodbtn;
        private Button List_Prodbtn;
        private ListBox Produtos;
        private Button LogOutbtn;
    }
}