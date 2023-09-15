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
            this.LogOutbtn = new System.Windows.Forms.Button();
            this.UserManagementbtn = new System.Windows.Forms.Button();
            this.adm_prodbtn = new System.Windows.Forms.Button();
            this.adm_sellbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogOutbtn
            // 
            this.LogOutbtn.Location = new System.Drawing.Point(126, 296);
            this.LogOutbtn.Name = "LogOutbtn";
            this.LogOutbtn.Size = new System.Drawing.Size(86, 23);
            this.LogOutbtn.TabIndex = 4;
            this.LogOutbtn.Text = "desconectar";
            this.LogOutbtn.UseVisualStyleBackColor = true;
            this.LogOutbtn.Click += new System.EventHandler(this.LogOutbtn_Click);
            // 
            // UserManagementbtn
            // 
            this.UserManagementbtn.Location = new System.Drawing.Point(97, 30);
            this.UserManagementbtn.Name = "UserManagementbtn";
            this.UserManagementbtn.Size = new System.Drawing.Size(150, 50);
            this.UserManagementbtn.TabIndex = 5;
            this.UserManagementbtn.Text = "Administrar Usuarios";
            this.UserManagementbtn.UseVisualStyleBackColor = true;
            this.UserManagementbtn.Click += new System.EventHandler(this.UserManagementbtn_Click);
            // 
            // adm_prodbtn
            // 
            this.adm_prodbtn.Location = new System.Drawing.Point(97, 119);
            this.adm_prodbtn.Name = "adm_prodbtn";
            this.adm_prodbtn.Size = new System.Drawing.Size(150, 50);
            this.adm_prodbtn.TabIndex = 6;
            this.adm_prodbtn.Text = "Administrar Produtos";
            this.adm_prodbtn.UseVisualStyleBackColor = true;
            this.adm_prodbtn.Click += new System.EventHandler(this.adm_prodbtn_Click);
            // 
            // adm_sellbtn
            // 
            this.adm_sellbtn.Location = new System.Drawing.Point(97, 200);
            this.adm_sellbtn.Name = "adm_sellbtn";
            this.adm_sellbtn.Size = new System.Drawing.Size(150, 50);
            this.adm_sellbtn.TabIndex = 7;
            this.adm_sellbtn.Text = "Administrar Vendas";
            this.adm_sellbtn.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 386);
            this.Controls.Add(this.adm_sellbtn);
            this.Controls.Add(this.adm_prodbtn);
            this.Controls.Add(this.UserManagementbtn);
            this.Controls.Add(this.LogOutbtn);
            this.Name = "Form2";
            this.ResumeLayout(false);

        }

        #endregion
        private Button LogOutbtn;
        private Button UserManagementbtn;
        private Button adm_prodbtn;
        private Button adm_sellbtn;
    }
}