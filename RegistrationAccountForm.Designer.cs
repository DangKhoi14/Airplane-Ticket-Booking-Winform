namespace AirTicketBookingWindowForm
{
    partial class RegistrationAccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationAccountForm));
            picLogo = new PictureBox();
            lblTitle = new Label();
            label1 = new Label();
            txtCustomerName = new TextBox();
            label2 = new Label();
            dteBirthday = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            txtCustomerPassPort = new TextBox();
            label5 = new Label();
            txtCustomerNationality = new TextBox();
            picCustomerAvatar = new PictureBox();
            btnBrowser = new Button();
            btnRemove = new Button();
            rdbCertify = new RadioButton();
            btnRegist = new Button();
            btnCancel = new Button();
            lblClearFields = new Label();
            lblLogIn = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCustomerAvatar).BeginInit();
            SuspendLayout();
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(14, 16);
            picLogo.Margin = new Padding(3, 4, 3, 4);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(114, 67);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Consolas", 24F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblTitle.Location = new Point(152, 100);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(284, 47);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Registration";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 24F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(126, 27);
            label1.Name = "label1";
            label1.Size = new Size(416, 47);
            label1.TabIndex = 2;
            label1.Text = "TIMBERLAND AIRLINE";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(79, 170);
            txtCustomerName.Margin = new Padding(3, 4, 3, 4);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(436, 27);
            txtCustomerName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(17, 170);
            label2.Name = "label2";
            label2.Size = new Size(60, 22);
            label2.TabIndex = 4;
            label2.Text = "Name:";
            // 
            // dteBirthday
            // 
            dteBirthday.Location = new Point(115, 220);
            dteBirthday.Margin = new Padding(3, 4, 3, 4);
            dteBirthday.Name = "dteBirthday";
            dteBirthday.Size = new Size(250, 27);
            dteBirthday.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(17, 220);
            label3.Name = "label3";
            label3.Size = new Size(100, 22);
            label3.TabIndex = 4;
            label3.Text = "Birthday:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label4.Location = new Point(17, 270);
            label4.Name = "label4";
            label4.Size = new Size(110, 22);
            label4.TabIndex = 4;
            label4.Text = "Pass Port:";
            // 
            // txtCustomerPassPort
            // 
            txtCustomerPassPort.Location = new Point(126, 270);
            txtCustomerPassPort.Margin = new Padding(3, 4, 3, 4);
            txtCustomerPassPort.Name = "txtCustomerPassPort";
            txtCustomerPassPort.Size = new Size(389, 27);
            txtCustomerPassPort.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label5.Location = new Point(17, 320);
            label5.Name = "label5";
            label5.Size = new Size(130, 22);
            label5.TabIndex = 4;
            label5.Text = "Nationality:";
            // 
            // txtCustomerNationality
            // 
            txtCustomerNationality.Location = new Point(143, 320);
            txtCustomerNationality.Margin = new Padding(3, 4, 3, 4);
            txtCustomerNationality.Name = "txtCustomerNationality";
            txtCustomerNationality.Size = new Size(372, 27);
            txtCustomerNationality.TabIndex = 6;
            // 
            // picCustomerAvatar
            // 
            picCustomerAvatar.Image = (Image)resources.GetObject("picCustomerAvatar.Image");
            picCustomerAvatar.Location = new Point(22, 388);
            picCustomerAvatar.Margin = new Padding(3, 4, 3, 4);
            picCustomerAvatar.Name = "picCustomerAvatar";
            picCustomerAvatar.Size = new Size(171, 200);
            picCustomerAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            picCustomerAvatar.TabIndex = 7;
            picCustomerAvatar.TabStop = false;
            // 
            // btnBrowser
            // 
            btnBrowser.Location = new Point(258, 475);
            btnBrowser.Margin = new Padding(3, 4, 3, 4);
            btnBrowser.Name = "btnBrowser";
            btnBrowser.Size = new Size(86, 31);
            btnBrowser.TabIndex = 8;
            btnBrowser.Text = "Browser";
            btnBrowser.UseVisualStyleBackColor = true;
            btnBrowser.Click += btnBrowser_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(371, 475);
            btnRemove.Margin = new Padding(3, 4, 3, 4);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(86, 31);
            btnRemove.TabIndex = 8;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // rdbCertify
            // 
            rdbCertify.AutoSize = true;
            rdbCertify.Location = new Point(210, 563);
            rdbCertify.Margin = new Padding(3, 4, 3, 4);
            rdbCertify.Name = "rdbCertify";
            rdbCertify.Size = new Size(344, 24);
            rdbCertify.TabIndex = 9;
            rdbCertify.TabStop = true;
            rdbCertify.Text = "I certify that the information provided is correct";
            rdbCertify.UseVisualStyleBackColor = true;
            // 
            // btnRegist
            // 
            btnRegist.BackColor = Color.DarkGray;
            btnRegist.FlatAppearance.BorderSize = 0;
            btnRegist.FlatStyle = FlatStyle.Flat;
            btnRegist.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnRegist.Location = new Point(57, 624);
            btnRegist.Margin = new Padding(3, 4, 3, 4);
            btnRegist.Name = "btnRegist";
            btnRegist.Size = new Size(457, 40);
            btnRegist.TabIndex = 10;
            btnRegist.Text = "Regist";
            btnRegist.UseVisualStyleBackColor = false;
            btnRegist.Click += btnRegist_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnCancel.Location = new Point(229, 672);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(114, 40);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblClearFields
            // 
            lblClearFields.AutoSize = true;
            lblClearFields.Location = new Point(448, 388);
            lblClearFields.Name = "lblClearFields";
            lblClearFields.Size = new Size(85, 20);
            lblClearFields.TabIndex = 11;
            lblClearFields.Text = "Clear Fields";
            lblClearFields.Click += lblClearFields_Click;
            // 
            // lblLogIn
            // 
            lblLogIn.AutoSize = true;
            lblLogIn.Font = new Font("Consolas", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblLogIn.Location = new Point(500, 692);
            lblLogIn.Name = "lblLogIn";
            lblLogIn.Size = new Size(54, 20);
            lblLogIn.TabIndex = 12;
            lblLogIn.Text = "Login";
            lblLogIn.Click += lblLogIn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Consolas", 11.25F, FontStyle.Bold);
            label6.Location = new Point(17, 362);
            label6.Name = "label6";
            label6.Size = new Size(130, 22);
            label6.TabIndex = 13;
            label6.Text = "Your Avatar:";
            // 
            // RegistrationAccountForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(571, 733);
            Controls.Add(label6);
            Controls.Add(lblLogIn);
            Controls.Add(lblClearFields);
            Controls.Add(btnCancel);
            Controls.Add(btnRegist);
            Controls.Add(rdbCertify);
            Controls.Add(btnRemove);
            Controls.Add(btnBrowser);
            Controls.Add(picCustomerAvatar);
            Controls.Add(txtCustomerNationality);
            Controls.Add(txtCustomerPassPort);
            Controls.Add(dteBirthday);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtCustomerName);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Controls.Add(picLogo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "RegistrationAccountForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += RegistrationAccountForm_Load;
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCustomerAvatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picLogo;
        private Label lblTitle;
        private Label label1;
        private TextBox txtCustomerName;
        private Label label2;
        private DateTimePicker dteBirthday;
        private Label label3;
        private Label label4;
        private TextBox txtCustomerPassPort;
        private Label label5;
        private TextBox txtCustomerNationality;
        private PictureBox picCustomerAvatar;
        private Button btnBrowser;
        private Button btnRemove;
        private RadioButton rdbCertify;
        private Button btnRegist;
        private Button btnCancel;
        private Label lblClearFields;
        private Label lblLogIn;
        private Label label6;
    }
}