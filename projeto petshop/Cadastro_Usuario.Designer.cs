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
            this.userText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.confirmPasswordText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cancel_cad_user = new System.Windows.Forms.Button();
            this.confirm_cad_user = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userText
            // 
            this.userText.Location = new System.Drawing.Point(330, 128);
            this.userText.Name = "userText";
            this.userText.Size = new System.Drawing.Size(100, 23);
            this.userText.TabIndex = 1;
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(330, 176);
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '*';
            this.passwordText.Size = new System.Drawing.Size(100, 23);
            this.passwordText.TabIndex = 2;
            // 
            // confirmPasswordText
            // 
            this.confirmPasswordText.Location = new System.Drawing.Point(330, 224);
            this.confirmPasswordText.Name = "confirmPasswordText";
            this.confirmPasswordText.PasswordChar = '*';
            this.confirmPasswordText.Size = new System.Drawing.Size(100, 23);
            this.confirmPasswordText.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "senha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "confirmar senha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(245, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 37);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cadastro de Usuario";
            // 
            // cancel_cad_user
            // 
            this.cancel_cad_user.Location = new System.Drawing.Point(383, 264);
            this.cancel_cad_user.Name = "cancel_cad_user";
            this.cancel_cad_user.Size = new System.Drawing.Size(75, 23);
            this.cancel_cad_user.TabIndex = 8;
            this.cancel_cad_user.Text = "cancelar";
            this.cancel_cad_user.UseVisualStyleBackColor = true;
            this.cancel_cad_user.Click += new System.EventHandler(this.cancel_cad_user_Click);
            // 
            // confirm_cad_user
            // 
            this.confirm_cad_user.Location = new System.Drawing.Point(275, 264);
            this.confirm_cad_user.Name = "confirm_cad_user";
            this.confirm_cad_user.Size = new System.Drawing.Size(75, 23);
            this.confirm_cad_user.TabIndex = 9;
            this.confirm_cad_user.Text = "confirmar";
            this.confirm_cad_user.UseVisualStyleBackColor = true;
            this.confirm_cad_user.Click += new System.EventHandler(this.confirm_cad_user_Click);
            // 
            // Cadastro_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.confirm_cad_user);
            this.Controls.Add(this.cancel_cad_user);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirmPasswordText);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.userText);
            this.Name = "Cadastro_Usuario";
            this.Text = "Cadastro_Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}