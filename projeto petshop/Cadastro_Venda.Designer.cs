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
            this.label1 = new System.Windows.Forms.Label();
            this.confirm_cad_sell = new System.Windows.Forms.Button();
            this.cancel_cad_sell = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.total_value = new System.Windows.Forms.TextBox();
            this.product_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.User_id = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(261, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cadastro de Vendas";
            // 
            // confirm_cad_sell
            // 
            this.confirm_cad_sell.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.confirm_cad_sell.Location = new System.Drawing.Point(321, 256);
            this.confirm_cad_sell.Name = "confirm_cad_sell";
            this.confirm_cad_sell.Size = new System.Drawing.Size(75, 23);
            this.confirm_cad_sell.TabIndex = 23;
            this.confirm_cad_sell.Text = "confirmar";
            this.confirm_cad_sell.UseVisualStyleBackColor = true;
            this.confirm_cad_sell.Click += new System.EventHandler(this.confirm_cad_sell_Click);
            // 
            // cancel_cad_sell
            // 
            this.cancel_cad_sell.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cancel_cad_sell.Location = new System.Drawing.Point(438, 256);
            this.cancel_cad_sell.Name = "cancel_cad_sell";
            this.cancel_cad_sell.Size = new System.Drawing.Size(75, 23);
            this.cancel_cad_sell.TabIndex = 22;
            this.cancel_cad_sell.Text = "cancelar";
            this.cancel_cad_sell.UseVisualStyleBackColor = true;
            this.cancel_cad_sell.Click += new System.EventHandler(this.cancel_cad_sell_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Valor total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nome do Produto:";
            // 
            // total_value
            // 
            this.total_value.Location = new System.Drawing.Point(376, 156);
            this.total_value.Name = "total_value";
            this.total_value.Size = new System.Drawing.Size(100, 23);
            this.total_value.TabIndex = 15;
            // 
            // product_name
            // 
            this.product_name.Location = new System.Drawing.Point(376, 116);
            this.product_name.Name = "product_name";
            this.product_name.Size = new System.Drawing.Size(100, 23);
            this.product_name.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "ID do Usuario:";
            // 
            // User_id
            // 
            this.User_id.Location = new System.Drawing.Point(376, 200);
            this.User_id.Name = "User_id";
            this.User_id.Size = new System.Drawing.Size(100, 23);
            this.User_id.TabIndex = 24;
            // 
            // Cadastro_Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.User_id);
            this.Controls.Add(this.confirm_cad_sell);
            this.Controls.Add(this.cancel_cad_sell);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.total_value);
            this.Controls.Add(this.product_name);
            this.Controls.Add(this.label1);
            this.Name = "Cadastro_Venda";
            this.Text = "Cadastro_Venda";
            this.ResumeLayout(false);
            this.PerformLayout();

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