namespace projeto_petshop
{
    partial class Form2
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
            LogOutbtn = new Button();
            UserManagementbtn = new Button();
            adm_prodbtn = new Button();
            adm_sellbtn = new Button();
            SuspendLayout();
            // 
            // LogOutbtn
            // 
            LogOutbtn.Location = new Point(126, 296);
            LogOutbtn.Name = "LogOutbtn";
            LogOutbtn.Size = new Size(86, 23);
            LogOutbtn.TabIndex = 4;
            LogOutbtn.Text = "desconectar";
            LogOutbtn.UseVisualStyleBackColor = true;
            LogOutbtn.Click += LogOutbtn_Click;
            // 
            // UserManagementbtn
            // 
            UserManagementbtn.Location = new Point(97, 30);
            UserManagementbtn.Name = "UserManagementbtn";
            UserManagementbtn.Size = new Size(150, 50);
            UserManagementbtn.TabIndex = 5;
            UserManagementbtn.Text = "Administrar Usuarios";
            UserManagementbtn.UseVisualStyleBackColor = true;
            UserManagementbtn.Click += UserManagementbtn_Click;
            // 
            // adm_prodbtn
            // 
            adm_prodbtn.Location = new Point(97, 119);
            adm_prodbtn.Name = "adm_prodbtn";
            adm_prodbtn.Size = new Size(150, 50);
            adm_prodbtn.TabIndex = 6;
            adm_prodbtn.Text = "Administrar Produtos";
            adm_prodbtn.UseVisualStyleBackColor = true;
            adm_prodbtn.Click += adm_prodbtn_Click;
            // 
            // adm_sellbtn
            // 
            adm_sellbtn.Location = new Point(97, 200);
            adm_sellbtn.Name = "adm_sellbtn";
            adm_sellbtn.Size = new Size(150, 50);
            adm_sellbtn.TabIndex = 7;
            adm_sellbtn.Text = "Administrar Vendas";
            adm_sellbtn.UseVisualStyleBackColor = true;
            adm_sellbtn.Click += adm_sellbtn_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 386);
            Controls.Add(adm_sellbtn);
            Controls.Add(adm_prodbtn);
            Controls.Add(UserManagementbtn);
            Controls.Add(LogOutbtn);
            Name = "Form2";
            ResumeLayout(false);
        }

        #endregion
        private Button LogOutbtn;
        private Button UserManagementbtn;
        private Button adm_prodbtn;
        private Button adm_sellbtn;
    }
}