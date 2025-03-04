namespace BusyBeezApplication
{
    partial class frmLogin
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
            pictureBox1 = new PictureBox();
            lblBusyBeezFront = new Label();
            lblInvalid = new Label();
            txtUsername = new TextBox();
            txtPasscode = new TextBox();
            btnLogIn = new Button();
            lnkForgotPassword = new LinkLabel();
            lnkSignUp = new LinkLabel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.doñajuana;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(452, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lblBusyBeezFront
            // 
            lblBusyBeezFront.AutoSize = true;
            lblBusyBeezFront.Location = new Point(170, 150);
            lblBusyBeezFront.Name = "lblBusyBeezFront";
            lblBusyBeezFront.Size = new Size(113, 20);
            lblBusyBeezFront.TabIndex = 3;
            lblBusyBeezFront.Text = "BusyBeez Portal";
            // 
            // lblInvalid
            // 
            lblInvalid.AutoSize = true;
            lblInvalid.Location = new Point(183, 257);
            lblInvalid.Name = "lblInvalid";
            lblInvalid.Size = new Size(100, 20);
            lblInvalid.TabIndex = 4;
            lblInvalid.Text = "User is invalid";
            lblInvalid.Visible = false;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(91, 194);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(271, 27);
            txtUsername.TabIndex = 1;
            // 
            // txtPasscode
            // 
            txtPasscode.Location = new Point(91, 227);
            txtPasscode.Name = "txtPasscode";
            txtPasscode.PasswordChar = 'X';
            txtPasscode.PlaceholderText = "Passcode";
            txtPasscode.Size = new Size(271, 27);
            txtPasscode.TabIndex = 2;
            txtPasscode.KeyPress += txtPasscode_KeyPress;
            // 
            // btnLogIn
            // 
            btnLogIn.Location = new Point(91, 280);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(271, 65);
            btnLogIn.TabIndex = 3;
            btnLogIn.Text = "Log in";
            btnLogIn.UseVisualStyleBackColor = true;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // lnkForgotPassword
            // 
            lnkForgotPassword.AutoSize = true;
            lnkForgotPassword.Location = new Point(164, 348);
            lnkForgotPassword.Name = "lnkForgotPassword";
            lnkForgotPassword.Size = new Size(125, 20);
            lnkForgotPassword.TabIndex = 4;
            lnkForgotPassword.TabStop = true;
            lnkForgotPassword.Text = "Forgot Password?";
            // 
            // lnkSignUp
            // 
            lnkSignUp.AutoSize = true;
            lnkSignUp.Location = new Point(197, 368);
            lnkSignUp.Name = "lnkSignUp";
            lnkSignUp.Size = new Size(59, 20);
            lnkSignUp.TabIndex = 4;
            lnkSignUp.TabStop = true;
            lnkSignUp.Text = "Sign up";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(183, 121);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 5;
            label1.Text = "Welcome to";
            label1.Visible = false;
            label1.Click += label1_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(452, 407);
            Controls.Add(label1);
            Controls.Add(lnkSignUp);
            Controls.Add(lnkForgotPassword);
            Controls.Add(btnLogIn);
            Controls.Add(txtPasscode);
            Controls.Add(txtUsername);
            Controls.Add(lblInvalid);
            Controls.Add(lblBusyBeezFront);
            Controls.Add(pictureBox1);
            Name = "frmLogin";
            Text = "frmLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label lblBusyBeezFront;
        private Label lblInvalid;
        private TextBox txtUsername;
        private TextBox txtPasscode;
        private Button btnLogIn;
        private LinkLabel lnkForgotPassword;
        private LinkLabel lnkSignUp;
        private Label label1;
    }
}