namespace ASM1
{
    partial class From_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(From_Login));
            panel3 = new Panel();
            tb_pass = new TextBox();
            tb_user = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            pictureBox4 = new PictureBox();
            bt_login = new Button();
            button1 = new Button();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(tb_pass);
            panel3.Controls.Add(tb_user);
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(197, 183);
            panel3.Name = "panel3";
            panel3.Size = new Size(591, 113);
            panel3.TabIndex = 5;
            // 
            // tb_pass
            // 
            tb_pass.BorderStyle = BorderStyle.None;
            tb_pass.Location = new Point(55, 75);
            tb_pass.Name = "tb_pass";
            tb_pass.PasswordChar = '*';
            tb_pass.Size = new Size(265, 16);
            tb_pass.TabIndex = 4;
            // 
            // tb_user
            // 
            tb_user.BorderStyle = BorderStyle.None;
            tb_user.Location = new Point(55, 20);
            tb_user.Name = "tb_user";
            tb_user.Size = new Size(265, 16);
            tb_user.TabIndex = 3;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-1, 52);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 50);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-1, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 50);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Adobe Fan Heiti Std B", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(255, 128, 0);
            label2.Location = new Point(323, 75);
            label2.Name = "label2";
            label2.Size = new Size(235, 68);
            label2.TabIndex = 4;
            label2.Text = "Login To \r\n         Your Account";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 255, 255);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(191, 450);
            panel1.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Adobe Devanagari", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(255, 128, 0);
            label3.Location = new Point(12, 183);
            label3.Name = "label3";
            label3.Size = new Size(167, 44);
            label3.TabIndex = 1;
            label3.Text = "WELCOME library of\r\n            library of BTEC Fpt\r\n";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Literature;
            pictureBox4.Location = new Point(67, 101);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(50, 50);
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // bt_login
            // 
            bt_login.Font = new Font("Segoe UI Emoji", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_login.Location = new Point(434, 315);
            bt_login.Name = "bt_login";
            bt_login.Size = new Size(84, 42);
            bt_login.TabIndex = 9;
            bt_login.Text = "Login";
            bt_login.UseVisualStyleBackColor = true;
            bt_login.Click += bt_login_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(536, 315);
            button1.Name = "button1";
            button1.Size = new Size(92, 42);
            button1.TabIndex = 10;
            button1.Text = "Forgot password";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // From_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(bt_login);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "From_Login";
            Text = "From_Login";
            Load += Form1_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel3;
        private TextBox tb_pass;
        private TextBox tb_user;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label2;
        private Panel panel1;
        private Label label3;
        private PictureBox pictureBox4;
        private Button bt_login;
        private Button button1;
    }
}
