namespace projeto_petshop
{
    partial class Cadastro_Usuario
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
            ConfirmCadUserbtn = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // ConfirmCadUserbtn
            // 
            ConfirmCadUserbtn.Location = new Point(339, 263);
            ConfirmCadUserbtn.Name = "ConfirmCadUserbtn";
            ConfirmCadUserbtn.Size = new Size(75, 23);
            ConfirmCadUserbtn.TabIndex = 0;
            ConfirmCadUserbtn.Text = "Confirmar";
            ConfirmCadUserbtn.UseVisualStyleBackColor = true;
            ConfirmCadUserbtn.Click += ConfirmCadUserbtn_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(330, 128);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(330, 176);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(330, 224);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(275, 131);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 4;
            label1.Text = "usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(286, 179);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 5;
            label2.Text = "senha:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(231, 227);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 6;
            label3.Text = "confirmar senha:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(245, 47);
            label4.Name = "label4";
            label4.Size = new Size(258, 37);
            label4.TabIndex = 7;
            label4.Text = "Cadastro de Usuario";
            // 
            // Cadastro_Usuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(ConfirmCadUserbtn);
            Name = "Cadastro_Usuario";
            Text = "Cadastro_Usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ConfirmCadUserbtn;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}