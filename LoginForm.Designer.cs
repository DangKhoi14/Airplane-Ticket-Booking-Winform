namespace AirTicketBookingWindowForm
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            picLogo = new PictureBox();
            lblTitle = new Label();
            AccountPictureBox = new PictureBox();
            panel1 = new Panel();
            PasswordPictureBox = new PictureBox();
            panel2 = new Panel();
            btnLogIn = new Button();
            btnCancel = new Button();
            btnSignUp = new Button();
            lblClearFields = new Label();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AccountPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PasswordPictureBox).BeginInit();
            SuspendLayout();
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(150, 30);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(200, 100);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Consolas", 24F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblTitle.Location = new Point(196, 147);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(107, 37);
            lblTitle.TabIndex = 1;
            lblTitle.Tag = "";
            lblTitle.Text = "LOGIN";
            lblTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // AccountPictureBox
            // 
            AccountPictureBox.Image = (Image)resources.GetObject("AccountPictureBox.Image");
            AccountPictureBox.Location = new Point(50, 220);
            AccountPictureBox.Name = "AccountPictureBox";
            AccountPictureBox.Size = new Size(30, 30);
            AccountPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            AccountPictureBox.TabIndex = 2;
            AccountPictureBox.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Location = new Point(50, 255);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 1);
            panel1.TabIndex = 3;
            // 
            // PasswordPictureBox
            // 
            PasswordPictureBox.Image = (Image)resources.GetObject("PasswordPictureBox.Image");
            PasswordPictureBox.Location = new Point(50, 287);
            PasswordPictureBox.Name = "PasswordPictureBox";
            PasswordPictureBox.Size = new Size(30, 30);
            PasswordPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            PasswordPictureBox.TabIndex = 2;
            PasswordPictureBox.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Location = new Point(50, 322);
            panel2.Name = "panel2";
            panel2.Size = new Size(400, 1);
            panel2.TabIndex = 3;
            // 
            // btnLogIn
            // 
            btnLogIn.BackColor = Color.DarkGray;
            btnLogIn.FlatAppearance.BorderSize = 0;
            btnLogIn.FlatStyle = FlatStyle.Flat;
            btnLogIn.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnLogIn.Location = new Point(150, 360);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(200, 25);
            btnLogIn.TabIndex = 4;
            btnLogIn.Text = "Login";
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // btnCancel
            // 
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnCancel.Location = new Point(210, 400);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(80, 25);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSignUp
            // 
            btnSignUp.FlatAppearance.BorderSize = 0;
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.Font = new Font("Consolas", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            btnSignUp.Location = new Point(413, 465);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(75, 23);
            btnSignUp.TabIndex = 5;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // lblClearFields
            // 
            lblClearFields.AutoSize = true;
            lblClearFields.Location = new Point(413, 343);
            lblClearFields.Name = "lblClearFields";
            lblClearFields.Size = new Size(67, 15);
            lblClearFields.TabIndex = 6;
            lblClearFields.Text = "Clear Fields";
            lblClearFields.Click += lblClearFields_Click;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Left;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(100, 286);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(350, 30);
            txtPassword.TabIndex = 7;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // txtUserName
            // 
            txtUserName.Anchor = AnchorStyles.Left;
            txtUserName.BorderStyle = BorderStyle.None;
            txtUserName.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            txtUserName.ForeColor = Color.Black;
            txtUserName.Location = new Point(100, 220);
            txtUserName.Multiline = true;
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(350, 30);
            txtUserName.TabIndex = 7;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(499, 500);
            Controls.Add(txtUserName);
            Controls.Add(txtPassword);
            Controls.Add(lblClearFields);
            Controls.Add(btnSignUp);
            Controls.Add(btnCancel);
            Controls.Add(btnLogIn);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(PasswordPictureBox);
            Controls.Add(AccountPictureBox);
            Controls.Add(lblTitle);
            Controls.Add(picLogo);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)AccountPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)PasswordPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picLogo;
        private Label lblTitle;
        private PictureBox AccountPictureBox;
        private Panel panel1;
        private PictureBox PasswordPictureBox;
        private Panel panel2;
        private Button btnLogIn;
        private Button btnCancel;
        private Button btnSignUp;
        private Label lblClearFields;
        private TextBox txtPassword;
        private TextBox txtUserName;
    }
}
