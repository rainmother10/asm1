namespace ASM1
{
    partial class Form2_User
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
            tb_idbook = new TextBox();
            bt_dangky = new Button();
            dgv1 = new DataGridView();
            button1 = new Button();
            dtimengaymuon = new DateTimePicker();
            dtimengaytra = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            label3 = new Label();
            tbsreach = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv1).BeginInit();
            SuspendLayout();
            // 
            // tb_idbook
            // 
            tb_idbook.Location = new Point(10, 31);
            tb_idbook.Name = "tb_idbook";
            tb_idbook.Size = new Size(100, 23);
            tb_idbook.TabIndex = 0;
            // 
            // bt_dangky
            // 
            bt_dangky.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_dangky.Location = new Point(580, 53);
            bt_dangky.Name = "bt_dangky";
            bt_dangky.Size = new Size(82, 45);
            bt_dangky.TabIndex = 11;
            bt_dangky.Text = "History of borrowing books";
            bt_dangky.UseVisualStyleBackColor = true;
            bt_dangky.Click += bt_dangky_Click;
            // 
            // dgv1
            // 
            dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv1.Location = new Point(49, 139);
            dgv1.Name = "dgv1";
            dgv1.Size = new Size(561, 318);
            dgv1.TabIndex = 12;
            // 
            // button1
            // 
            button1.Font = new Font("Adobe Caslon Pro Bold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(568, 5);
            button1.Name = "button1";
            button1.Size = new Size(94, 42);
            button1.TabIndex = 13;
            button1.Text = "Load Book";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dtimengaymuon
            // 
            dtimengaymuon.Location = new Point(141, 28);
            dtimengaymuon.Name = "dtimengaymuon";
            dtimengaymuon.Size = new Size(200, 23);
            dtimengaymuon.TabIndex = 14;
            // 
            // dtimengaytra
            // 
            dtimengaytra.Location = new Point(141, 87);
            dtimengaytra.Name = "dtimengaytra";
            dtimengaytra.Size = new Size(200, 23);
            dtimengaytra.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(141, 10);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 16;
            label1.Text = "borrowed day";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(141, 69);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 17;
            label2.Text = "Book Return Date";
            // 
            // button2
            // 
            button2.Font = new Font("Adobe Caslon Pro Bold", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(12, 83);
            button2.Name = "button2";
            button2.Size = new Size(101, 41);
            button2.TabIndex = 18;
            button2.Text = "borrow books";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(10, 5);
            label3.Name = "label3";
            label3.Size = new Size(60, 21);
            label3.TabIndex = 19;
            label3.Text = "IDBook";
            // 
            // tbsreach
            // 
            tbsreach.Location = new Point(386, 61);
            tbsreach.Name = "tbsreach";
            tbsreach.Size = new Size(118, 23);
            tbsreach.TabIndex = 20;
            tbsreach.TextChanged += tbsreach_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(386, 29);
            label4.Name = "label4";
            label4.Size = new Size(96, 21);
            label4.TabIndex = 21;
            label4.Text = "Search Book";
            // 
            // Form2_User
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 471);
            Controls.Add(label4);
            Controls.Add(tbsreach);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtimengaytra);
            Controls.Add(dtimengaymuon);
            Controls.Add(button1);
            Controls.Add(dgv1);
            Controls.Add(bt_dangky);
            Controls.Add(tb_idbook);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Form2_User";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dgv1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_idbook;
        private Button bt_dangky;
        private DataGridView dgv1;
        private Button button1;
        private DateTimePicker dtimengaymuon;
        private DateTimePicker dtimengaytra;
        private Label label1;
        private Label label2;
        private Button button2;
        private Label label3;
        private TextBox tbsreach;
        private Label label4;
    }
}