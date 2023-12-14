namespace projeto_petshop
{
    partial class Cadastro_Venda
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
            confirm_cad_sell = new Button();
            cancel_cad_sell = new Button();
            label3 = new Label();
            label2 = new Label();
            total_value = new TextBox();
            product_name = new TextBox();
            label4 = new Label();
            User_id = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(261, 56);
            label1.Name = "label1";
            label1.Size = new Size(252, 37);
            label1.TabIndex = 2;
            label1.Text = "Cadastro de Vendas";
            // 
            // confirm_cad_sell
            // 
            confirm_cad_sell.Cursor = Cursors.IBeam;
            confirm_cad_sell.Location = new Point(321, 256);
            confirm_cad_sell.Name = "confirm_cad_sell";
            confirm_cad_sell.Size = new Size(75, 23);
            confirm_cad_sell.TabIndex = 23;
            confirm_cad_sell.Text = "confirmar";
            confirm_cad_sell.UseVisualStyleBackColor = true;
            confirm_cad_sell.Click += confirm_cad_sell_Click;
            // 
            // cancel_cad_sell
            // 
            cancel_cad_sell.Cursor = Cursors.IBeam;
            cancel_cad_sell.Location = new Point(438, 256);
            cancel_cad_sell.Name = "cancel_cad_sell";
            cancel_cad_sell.Size = new Size(75, 23);
            cancel_cad_sell.TabIndex = 22;
            cancel_cad_sell.Text = "cancelar";
            cancel_cad_sell.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(307, 159);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 17;
            label3.Text = "Valor total:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(264, 119);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 16;
            label2.Text = "Nome do Produto:";
            // 
            // total_value
            // 
            total_value.Location = new Point(376, 156);
            total_value.Name = "total_value";
            total_value.Size = new Size(100, 23);
            total_value.TabIndex = 15;
            // 
            // product_name
            // 
            product_name.Location = new Point(376, 116);
            product_name.Name = "product_name";
            product_name.Size = new Size(100, 23);
            product_name.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(289, 203);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 25;
            label4.Text = "ID do Usuario:";
            // 
            // User_id
            // 
            User_id.Location = new Point(376, 200);
            User_id.Name = "User_id";
            User_id.Size = new Size(100, 23);
            User_id.TabIndex = 24;
            // 
            // Cadastro_Venda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(User_id);
            Controls.Add(confirm_cad_sell);
            Controls.Add(cancel_cad_sell);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(total_value);
            Controls.Add(product_name);
            Controls.Add(label1);
            Name = "Cadastro_Venda";
            Text = "Cadastro_Venda";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button confirm_cad_sell;
        private Button cancel_cad_sell;
        private Label label3;
        private Label label2;
        private TextBox total_value;
        private TextBox product_name;
        private Label label4;
        private TextBox User_id;
    }
}