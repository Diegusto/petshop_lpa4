namespace projeto_petshop
{
    partial class Cadastro_Produto
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
            this.product_name = new System.Windows.Forms.TextBox();
            this.product_value = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.animal = new System.Windows.Forms.ComboBox();
            this.product_type = new System.Windows.Forms.ComboBox();
            this.cancel_cad_prod = new System.Windows.Forms.Button();
            this.confirm_cad_prod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(250, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Produto";
            // 
            // product_name
            // 
            this.product_name.Location = new System.Drawing.Point(368, 102);
            this.product_name.Name = "product_name";
            this.product_name.Size = new System.Drawing.Size(100, 23);
            this.product_name.TabIndex = 1;
            // 
            // product_value
            // 
            this.product_value.Location = new System.Drawing.Point(368, 151);
            this.product_value.Name = "product_value";
            this.product_value.Size = new System.Drawing.Size(100, 23);
            this.product_value.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome do produto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valor do produto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tipo do Produto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Animal destinado:";
            // 
            // animal
            // 
            this.animal.FormattingEnabled = true;
            this.animal.Location = new System.Drawing.Point(368, 248);
            this.animal.Name = "animal";
            this.animal.Size = new System.Drawing.Size(121, 23);
            this.animal.TabIndex = 9;
            // 
            // product_type
            // 
            this.product_type.FormattingEnabled = true;
            this.product_type.Location = new System.Drawing.Point(368, 200);
            this.product_type.Name = "product_type";
            this.product_type.Size = new System.Drawing.Size(121, 23);
            this.product_type.TabIndex = 10;
            // 
            // cancel_cad_prod
            // 
            this.cancel_cad_prod.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cancel_cad_prod.Location = new System.Drawing.Point(453, 297);
            this.cancel_cad_prod.Name = "cancel_cad_prod";
            this.cancel_cad_prod.Size = new System.Drawing.Size(75, 23);
            this.cancel_cad_prod.TabIndex = 12;
            this.cancel_cad_prod.Text = "cancelar";
            this.cancel_cad_prod.UseVisualStyleBackColor = true;
            this.cancel_cad_prod.Click += new System.EventHandler(this.cancel_cad_prod_Click);
            // 
            // confirm_cad_prod
            // 
            this.confirm_cad_prod.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.confirm_cad_prod.Location = new System.Drawing.Point(353, 297);
            this.confirm_cad_prod.Name = "confirm_cad_prod";
            this.confirm_cad_prod.Size = new System.Drawing.Size(75, 23);
            this.confirm_cad_prod.TabIndex = 13;
            this.confirm_cad_prod.Text = "confirmar";
            this.confirm_cad_prod.UseVisualStyleBackColor = true;
            this.confirm_cad_prod.Click += new System.EventHandler(this.confirm_cad_prod_Click);
            // 
            // Cadastro_Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.confirm_cad_prod);
            this.Controls.Add(this.cancel_cad_prod);
            this.Controls.Add(this.product_type);
            this.Controls.Add(this.animal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.product_value);
            this.Controls.Add(this.product_name);
            this.Controls.Add(this.label1);
            this.Name = "Cadastro_Produto";
            this.Text = "Cadastro_Produto";
            this.Load += new System.EventHandler(this.Cadastro_Produto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox product_name;
        private TextBox product_value;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox animal;
        private ComboBox product_type;
        private Button cancel_cad_prod;
        private Button confirm_cad_prod;
    }
}