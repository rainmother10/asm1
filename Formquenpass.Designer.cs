namespace ASM1
{
    partial class Formquenpass
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
            tbuser = new TextBox();
            tbpass = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // tbuser
            // 
            tbuser.Location = new Point(94, 69);
            tbuser.Name = "tbuser";
            tbuser.Size = new Size(100, 23);
            tbuser.TabIndex = 0;
            // 
            // tbpass
            // 
            tbpass.Location = new Point(94, 109);
            tbpass.Name = "tbpass";
            tbpass.Size = new Size(100, 23);
            tbpass.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 72);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 2;
            label1.Text = "username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 112);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 3;
            label2.Text = "pass";
            // 
            // button1
            // 
            button1.Location = new Point(105, 148);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "resset pass";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(105, 177);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "register";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Formquenpass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 239);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbpass);
            Controls.Add(tbuser);
            Name = "Formquenpass";
            Text = "Formquenpass";
            Load += Formquenpass_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbuser;
        private TextBox tbpass;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
    }
}