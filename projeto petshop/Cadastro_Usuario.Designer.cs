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
            userText = new TextBox();
            passwordText = new TextBox();
            confirmPasswordText = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cancel_cad_user = new Button();
            confirm_cad_user = new Button();
            emailtxt = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // userText
            // 
            userText.Location = new Point(218, 128);
            userText.Name = "userText";
            userText.Size = new Size(100, 23);
            userText.TabIndex = 1;
            // 
            // passwordText
            // 
            passwordText.Location = new Point(218, 224);
            passwordText.Name = "passwordText";
            passwordText.PasswordChar = '*';
            passwordText.Size = new Size(100, 23);
            passwordText.TabIndex = 2;
            // 
            // confirmPasswordText
            // 
            confirmPasswordText.Location = new Point(218, 268);
            confirmPasswordText.Name = "confirmPasswordText";
            confirmPasswordText.PasswordChar = '*';
            confirmPasswordText.Size = new Size(100, 23);
            confirmPasswordText.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(163, 131);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 4;
            label1.Text = "usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(171, 227);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 5;
            label2.Text = "senha:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(116, 268);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 6;
            label3.Text = "confirmar senha:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(137, 74);
            label4.Name = "label4";
            label4.Size = new Size(258, 37);
            label4.TabIndex = 7;
            label4.Text = "Cadastro de Usuario";
            // 
            // cancel_cad_user
            // 
            cancel_cad_user.Location = new Point(297, 311);
            cancel_cad_user.Name = "cancel_cad_user";
            cancel_cad_user.Size = new Size(75, 23);
            cancel_cad_user.TabIndex = 8;
            cancel_cad_user.Text = "cancelar";
            cancel_cad_user.UseVisualStyleBackColor = true;
            cancel_cad_user.Click += cancel_cad_user_Click;
            // 
            // confirm_cad_user
            // 
            confirm_cad_user.Location = new Point(151, 311);
            confirm_cad_user.Name = "confirm_cad_user";
            confirm_cad_user.Size = new Size(75, 23);
            confirm_cad_user.TabIndex = 9;
            confirm_cad_user.Text = "confirmar";
            confirm_cad_user.UseVisualStyleBackColor = true;
            confirm_cad_user.Click += confirm_cad_user_Click;
            // 
            // emailtxt
            // 
            emailtxt.Location = new Point(218, 175);
            emailtxt.Name = "emailtxt";
            emailtxt.Size = new Size(100, 23);
            emailtxt.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(173, 178);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 11;
            label5.Text = "email:";
            // 
            // Cadastro_Usuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 384);
            Controls.Add(label5);
            Controls.Add(emailtxt);
            Controls.Add(confirm_cad_user);
            Controls.Add(cancel_cad_user);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(confirmPasswordText);
            Controls.Add(passwordText);
            Controls.Add(userText);
            Name = "Cadastro_Usuario";
            Text = "Cadastro_Usuario";
            Load += Cadastro_Usuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox userText;
        private TextBox passwordText;
        private TextBox confirmPasswordText;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button cancel_cad_user;
        private Button confirm_cad_user;
        private TextBox emailtxt;
        private Label label5;
    }
}