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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Nome", System.Windows.Forms.HorizontalAlignment.Left);
            this.user_cadbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.returnbtn = new System.Windows.Forms.Button();
            this.listar_usuarios = new System.Windows.Forms.ListView();
            this.excluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // user_cadbtn
            // 
            this.user_cadbtn.Location = new System.Drawing.Point(12, 112);
            this.user_cadbtn.Name = "user_cadbtn";
            this.user_cadbtn.Size = new System.Drawing.Size(127, 73);
            this.user_cadbtn.TabIndex = 0;
            this.user_cadbtn.Text = "cadastrar";
            this.user_cadbtn.UseVisualStyleBackColor = true;
            this.user_cadbtn.Click += new System.EventHandler(this.user_cadbtn_Click);
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
            // returnbtn
            // 
            this.returnbtn.Location = new System.Drawing.Point(352, 137);
            this.returnbtn.Name = "returnbtn";
            this.returnbtn.Size = new System.Drawing.Size(75, 23);
            this.returnbtn.TabIndex = 5;
            this.returnbtn.Text = "sair";
            this.returnbtn.UseVisualStyleBackColor = true;
            this.returnbtn.Click += new System.EventHandler(this.returnbtn_Click);
            // 
            // listar_usuarios
            // 
            listViewGroup1.Header = "Nome";
            listViewGroup1.Name = "listViewGroup1";
            this.listar_usuarios.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.listar_usuarios.Location = new System.Drawing.Point(12, 214);
            this.listar_usuarios.Name = "listar_usuarios";
            this.listar_usuarios.Size = new System.Drawing.Size(484, 360);
            this.listar_usuarios.TabIndex = 6;
            this.listar_usuarios.UseCompatibleStateImageBehavior = false;
            this.listar_usuarios.View = System.Windows.Forms.View.Details;
            // 
            // excluir
            // 
            this.excluir.Location = new System.Drawing.Point(182, 112);
            this.excluir.Name = "excluir";
            this.excluir.Size = new System.Drawing.Size(127, 73);
            this.excluir.TabIndex = 7;
            this.excluir.Text = "excluir";
            this.excluir.UseVisualStyleBackColor = true;
            this.excluir.Click += new System.EventHandler(this.excluir_Click);
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 586);
            this.Controls.Add(this.excluir);
            this.Controls.Add(this.listar_usuarios);
            this.Controls.Add(this.returnbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.user_cadbtn);
            this.Name = "UserManagement";
            this.Text = "UserManagement";
            this.Load += new System.EventHandler(this.UserManagement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button user_cadbtn;
        private Label label1;
        private Button returnbtn;
        private ListView listar_usuarios;
        private Button excluir;
    }
}