namespace NatureHabitat
{
    partial class Login
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
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            BtnClear = new Button();
            BtnLogin = new Button();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(151, 39);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(261, 23);
            txtUserName.TabIndex = 1;
            txtUserName.Text = "admin";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(151, 86);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '#';
            txtPassword.Size = new Size(261, 23);
            txtPassword.TabIndex = 2;
            txtPassword.Text = "admin@2023";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Open Sans Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(51, 44);
            label1.Name = "label1";
            label1.Size = new Size(84, 18);
            label1.TabIndex = 1;
            label1.Text = "User Name :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Open Sans Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(59, 91);
            label2.Name = "label2";
            label2.Size = new Size(76, 18);
            label2.TabIndex = 1;
            label2.Text = "Password :";
            // 
            // BtnClear
            // 
            BtnClear.Font = new Font("Open Sans Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnClear.Location = new Point(161, 157);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(108, 43);
            BtnClear.TabIndex = 2;
            BtnClear.Text = "Clear";
            BtnClear.UseVisualStyleBackColor = true;
            BtnClear.Click += BtnClear_Click;
            // 
            // BtnLogin
            // 
            BtnLogin.Font = new Font("Open Sans Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnLogin.Location = new Point(275, 159);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(108, 39);
            BtnLogin.TabIndex = 2;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = true;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel1.Location = new Point(313, 128);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(99, 15);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forget Password?";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 237);
            Controls.Add(linkLabel1);
            Controls.Add(BtnLogin);
            Controls.Add(BtnClear);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserName;
        private TextBox txtPassword;
        private Label label1;
        private Label label2;
        private Button BtnClear;
        private Button BtnLogin;
        private LinkLabel linkLabel1;
    }
}