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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            ConfirmCadProd = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(250, 34);
            label1.Name = "label1";
            label1.Size = new Size(263, 37);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Produto";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(368, 102);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(368, 151);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(256, 105);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 5;
            label2.Text = "Nome do produto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(263, 154);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 6;
            label3.Text = "Valor do produto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(266, 203);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 7;
            label4.Text = "Tipo do Produto:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(259, 251);
            label5.Name = "label5";
            label5.Size = new Size(103, 15);
            label5.TabIndex = 8;
            label5.Text = "Animal destinado:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(368, 248);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 9;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(368, 200);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 10;
            // 
            // ConfirmCadProd
            // 
            ConfirmCadProd.Location = new Point(347, 297);
            ConfirmCadProd.Name = "ConfirmCadProd";
            ConfirmCadProd.Size = new Size(75, 23);
            ConfirmCadProd.TabIndex = 11;
            ConfirmCadProd.Text = "confirmar";
            ConfirmCadProd.UseVisualStyleBackColor = true;
            ConfirmCadProd.Click += ConfirmCadProd_Click;
            // 
            // Cadastro_Produto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ConfirmCadProd);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Cadastro_Produto";
            Text = "Cadastro_Produto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button ConfirmCadProd;
    }
}