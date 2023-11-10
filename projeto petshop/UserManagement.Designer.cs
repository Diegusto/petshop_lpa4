namespace projeto_petshop
{
    partial class UserManagement
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
            user_cadbtn = new Button();
            label1 = new Label();
            Listar_Usuarios = new ListBox();
            returnbtn = new Button();
            SuspendLayout();
            // 
            // user_cadbtn
            // 
            user_cadbtn.Location = new Point(264, 112);
            user_cadbtn.Name = "user_cadbtn";
            user_cadbtn.Size = new Size(127, 73);
            user_cadbtn.TabIndex = 0;
            user_cadbtn.Text = "cadastrar";
            user_cadbtn.UseVisualStyleBackColor = true;
            user_cadbtn.Click += user_cadbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(213, 62);
            label1.Name = "label1";
            label1.Size = new Size(263, 37);
            label1.TabIndex = 2;
            label1.Text = "Administrar Usuarios";
            // 
            // Listar_Usuarios
            // 
            Listar_Usuarios.FormattingEnabled = true;
            Listar_Usuarios.ItemHeight = 15;
            Listar_Usuarios.Location = new Point(2, 191);
            Listar_Usuarios.Name = "Listar_Usuarios";
            Listar_Usuarios.Size = new Size(670, 394);
            Listar_Usuarios.TabIndex = 3;
            // 
            // returnbtn
            // 
            returnbtn.Location = new Point(421, 137);
            returnbtn.Name = "returnbtn";
            returnbtn.Size = new Size(75, 23);
            returnbtn.TabIndex = 5;
            returnbtn.Text = "sair";
            returnbtn.UseVisualStyleBackColor = true;
            returnbtn.Click += returnbtn_Click;
            // 
            // UserManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 586);
            Controls.Add(returnbtn);
            Controls.Add(Listar_Usuarios);
            Controls.Add(label1);
            Controls.Add(user_cadbtn);
            Name = "UserManagement";
            Text = "UserManagement";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button user_cadbtn;
        private Label label1;
        private ListBox Listar_Usuarios;
        private Button returnbtn;
    }
}