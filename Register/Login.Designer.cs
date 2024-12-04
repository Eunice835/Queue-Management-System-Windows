namespace Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            button3 = new Button();
            Login_btn = new Button();
            label1 = new Label();
            checkBox1 = new CheckBox();
            tbPassword = new TextBox();
            tbUsername = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            SignUp = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label6 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.Navy;
            button3.ForeColor = Color.White;
            button3.Location = new Point(757, 649);
            button3.Name = "button3";
            button3.Size = new Size(112, 45);
            button3.TabIndex = 28;
            button3.Text = "Sign Up";
            button3.UseVisualStyleBackColor = false;
            // 
            // Login_btn
            // 
            Login_btn.BackColor = Color.Navy;
            Login_btn.ForeColor = Color.White;
            Login_btn.Location = new Point(676, 420);
            Login_btn.Name = "Login_btn";
            Login_btn.Size = new Size(112, 45);
            Login_btn.TabIndex = 27;
            Login_btn.Text = "Login";
            Login_btn.UseVisualStyleBackColor = false;
            Login_btn.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(491, 657);
            label1.Name = "label1";
            label1.Size = new Size(199, 23);
            label1.TabIndex = 26;
            label1.Text = "Don't Have an Account?";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(778, 512);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(156, 27);
            checkBox1.TabIndex = 25;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(555, 344);
            tbPassword.Multiline = true;
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '◘';
            tbPassword.Size = new Size(407, 37);
            tbPassword.TabIndex = 22;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(555, 238);
            tbUsername.Multiline = true;
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(407, 37);
            tbUsername.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(134, 437);
            label5.Name = "label5";
            label5.Size = new Size(0, 23);
            label5.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(443, 347);
            label4.Name = "label4";
            label4.Size = new Size(85, 23);
            label4.TabIndex = 18;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(443, 241);
            label3.Name = "label3";
            label3.Size = new Size(89, 23);
            label3.TabIndex = 17;
            label3.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(555, 123);
            label2.Name = "label2";
            label2.Size = new Size(253, 23);
            label2.TabIndex = 16;
            label2.Text = "Enter Your Credential To Login";
            // 
            // SignUp
            // 
            SignUp.AutoSize = true;
            SignUp.Font = new Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignUp.Location = new Point(512, 22);
            SignUp.Name = "SignUp";
            SignUp.Size = new Size(348, 62);
            SignUp.TabIndex = 15;
            SignUp.Text = "Welcome Back";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(437, 712);
            panel1.TabIndex = 29;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(114, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(201, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLightLight;
            button1.ForeColor = Color.Navy;
            button1.Location = new Point(79, 637);
            button1.Name = "button1";
            button1.Size = new Size(274, 37);
            button1.TabIndex = 1;
            button1.Text = "Sign In";
            button1.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Navy;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(27, 337);
            label6.Name = "label6";
            label6.Size = new Size(333, 32);
            label6.TabIndex = 0;
            label6.Text = "Queue Management System";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Navy;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(963, 9);
            label7.Name = "label7";
            label7.Size = new Size(24, 25);
            label7.TabIndex = 30;
            label7.Text = "X";
            label7.Click += label7_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1002, 712);
            Controls.Add(label7);
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(Login_btn);
            Controls.Add(label1);
            Controls.Add(checkBox1);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(SignUp);
            Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Login";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button Login_btn;
        private Label label1;
        private CheckBox checkBox1;
        private TextBox tbPassword;
        private TextBox tbUsername;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label SignUp;
        private Panel panel1;
        private Label label6;
        private Button button1;
        private Label label7;
        private PictureBox pictureBox1;
    }
}