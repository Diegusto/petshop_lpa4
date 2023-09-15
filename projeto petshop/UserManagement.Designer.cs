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
            this.user_cadbtn = new System.Windows.Forms.Button();
            this.List_userbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Listar_Usuarios = new System.Windows.Forms.ListBox();
            this.remove_usertbn = new System.Windows.Forms.Button();
            this.returnbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // user_cadbtn
            // 
            this.user_cadbtn.Location = new System.Drawing.Point(124, 168);
            this.user_cadbtn.Name = "user_cadbtn";
            this.user_cadbtn.Size = new System.Drawing.Size(127, 73);
            this.user_cadbtn.TabIndex = 0;
            this.user_cadbtn.Text = "cadastrar";
            this.user_cadbtn.UseVisualStyleBackColor = true;
            this.user_cadbtn.Click += new System.EventHandler(this.user_cadbtn_Click);
            // 
            // List_userbtn
            // 
            this.List_userbtn.Location = new System.Drawing.Point(466, 168);
            this.List_userbtn.Name = "List_userbtn";
            this.List_userbtn.Size = new System.Drawing.Size(118, 73);
            this.List_userbtn.TabIndex = 1;
            this.List_userbtn.Text = "listar";
            this.List_userbtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(213, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Administrar Usuarios";
            // 
            // Listar_Usuarios
            // 
            this.Listar_Usuarios.FormattingEnabled = true;
            this.Listar_Usuarios.ItemHeight = 15;
            this.Listar_Usuarios.Location = new System.Drawing.Point(81, 306);
            this.Listar_Usuarios.Name = "Listar_Usuarios";
            this.Listar_Usuarios.Size = new System.Drawing.Size(517, 229);
            this.Listar_Usuarios.TabIndex = 3;
            // 
            // remove_usertbn
            // 
            this.remove_usertbn.Location = new System.Drawing.Point(291, 168);
            this.remove_usertbn.Name = "remove_usertbn";
            this.remove_usertbn.Size = new System.Drawing.Size(118, 73);
            this.remove_usertbn.TabIndex = 4;
            this.remove_usertbn.Text = "Excluir";
            this.remove_usertbn.UseVisualStyleBackColor = true;
            // 
            // returnbtn
            // 
            this.returnbtn.Location = new System.Drawing.Point(300, 267);
            this.returnbtn.Name = "returnbtn";
            this.returnbtn.Size = new System.Drawing.Size(75, 23);
            this.returnbtn.TabIndex = 5;
            this.returnbtn.Text = "sair";
            this.returnbtn.UseVisualStyleBackColor = true;
            this.returnbtn.Click += new System.EventHandler(this.returnbtn_Click);
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 586);
            this.Controls.Add(this.returnbtn);
            this.Controls.Add(this.remove_usertbn);
            this.Controls.Add(this.Listar_Usuarios);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.List_userbtn);
            this.Controls.Add(this.user_cadbtn);
            this.Name = "UserManagement";
            this.Text = "UserManagement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button user_cadbtn;
        private Button List_userbtn;
        private Label label1;
        private ListBox Listar_Usuarios;
        private Button remove_usertbn;
        private Button returnbtn;
    }
}