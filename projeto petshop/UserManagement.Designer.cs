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
            ListViewGroup listViewGroup2 = new ListViewGroup("Nome", HorizontalAlignment.Left);
            user_cadbtn = new Button();
            label1 = new Label();
            returnbtn = new Button();
            listar_usuarios = new ListView();
            excluir = new Button();
            exclude = new CheckBox();
            SuspendLayout();
            // 
            // user_cadbtn
            // 
            user_cadbtn.Location = new Point(12, 112);
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
            // returnbtn
            // 
            returnbtn.Location = new Point(508, 137);
            returnbtn.Name = "returnbtn";
            returnbtn.Size = new Size(75, 23);
            returnbtn.TabIndex = 5;
            returnbtn.Text = "sair";
            returnbtn.UseVisualStyleBackColor = true;
            returnbtn.Click += returnbtn_Click;
            // 
            // listar_usuarios
            // 
            listViewGroup2.Header = "Nome";
            listViewGroup2.Name = "listViewGroup1";
            listar_usuarios.Groups.AddRange(new ListViewGroup[] { listViewGroup2 });
            listar_usuarios.Location = new Point(12, 214);
            listar_usuarios.Name = "listar_usuarios";
            listar_usuarios.Size = new Size(484, 360);
            listar_usuarios.TabIndex = 6;
            listar_usuarios.UseCompatibleStateImageBehavior = false;
            listar_usuarios.View = View.Details;
            // 
            // excluir
            // 
            excluir.Location = new Point(182, 112);
            excluir.Name = "excluir";
            excluir.Size = new Size(127, 73);
            excluir.TabIndex = 7;
            excluir.Text = "excluir";
            excluir.UseVisualStyleBackColor = true;
            excluir.Click += excluir_Click;
            // 
            // exclude
            // 
            exclude.AutoSize = true;
            exclude.Location = new Point(315, 141);
            exclude.Name = "exclude";
            exclude.Size = new Size(127, 19);
            exclude.TabIndex = 8;
            exclude.Text = "confirmar exclusão";
            exclude.UseVisualStyleBackColor = true;
            // 
            // UserManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 586);
            Controls.Add(exclude);
            Controls.Add(excluir);
            Controls.Add(listar_usuarios);
            Controls.Add(returnbtn);
            Controls.Add(label1);
            Controls.Add(user_cadbtn);
            Name = "UserManagement";
            Text = "UserManagement";
            Load += UserManagement_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button user_cadbtn;
        private Label label1;
        private Button returnbtn;
        private ListView listar_usuarios;
        private Button excluir;
        private CheckBox exclude;
    }
}