namespace ASM1
{
    partial class Form3
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
            components = new System.ComponentModel.Container();
            dgv1 = new DataGridView();
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            tabControl1 = new TabControl();
            tabpage1 = new TabPage();
            button1 = new Button();
            bt_delete = new Button();
            bt_edit = new Button();
            bt_addbook = new Button();
            tb_quantity = new TextBox();
            tb_genre = new TextBox();
            tb_author = new TextBox();
            tb_title = new TextBox();
            tb_bookid = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage3 = new TabPage();
            dgv3 = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)dgv1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            tabControl1.SuspendLayout();
            tabpage1.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv3).BeginInit();
            SuspendLayout();
            // 
            // dgv1
            // 
            dgv1.BackgroundColor = SystemColors.Control;
            dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv1.Location = new Point(358, 28);
            dgv1.Name = "dgv1";
            dgv1.Size = new Size(459, 350);
            dgv1.TabIndex = 0;
            dgv1.CellContentClick += dgv1_CellContentClick;
            dgv1.SelectionChanged += dgv1_SelectionChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 255, 255);
            panel1.Controls.Add(pictureBox4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(912, 57);
            panel1.TabIndex = 15;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Literature;
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(50, 50);
            pictureBox4.TabIndex = 16;
            pictureBox4.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabpage1);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(3, 63);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(909, 504);
            tabControl1.TabIndex = 0;
            // 
            // tabpage1
            // 
            tabpage1.Controls.Add(button1);
            tabpage1.Controls.Add(dgv1);
            tabpage1.Controls.Add(bt_delete);
            tabpage1.Controls.Add(bt_edit);
            tabpage1.Controls.Add(bt_addbook);
            tabpage1.Controls.Add(tb_quantity);
            tabpage1.Controls.Add(tb_genre);
            tabpage1.Controls.Add(tb_author);
            tabpage1.Controls.Add(tb_title);
            tabpage1.Controls.Add(tb_bookid);
            tabpage1.Controls.Add(label5);
            tabpage1.Controls.Add(label4);
            tabpage1.Controls.Add(label3);
            tabpage1.Controls.Add(label2);
            tabpage1.Controls.Add(label1);
            tabpage1.Location = new Point(4, 24);
            tabpage1.Name = "tabpage1";
            tabpage1.Padding = new Padding(3);
            tabpage1.Size = new Size(901, 476);
            tabpage1.TabIndex = 0;
            tabpage1.Text = "MENU";
            tabpage1.UseVisualStyleBackColor = true;
            tabpage1.Click += tabpage1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Adobe Fangsong Std R", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(123, 330);
            button1.Name = "button1";
            button1.Size = new Size(75, 30);
            button1.TabIndex = 28;
            button1.Text = "clear all";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // bt_delete
            // 
            bt_delete.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_delete.Location = new Point(204, 52);
            bt_delete.Name = "bt_delete";
            bt_delete.Size = new Size(78, 35);
            bt_delete.TabIndex = 27;
            bt_delete.Text = "Delete";
            bt_delete.UseVisualStyleBackColor = true;
            bt_delete.Click += bt_delete_Click_1;
            // 
            // bt_edit
            // 
            bt_edit.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_edit.Location = new Point(123, 52);
            bt_edit.Name = "bt_edit";
            bt_edit.Size = new Size(75, 35);
            bt_edit.TabIndex = 26;
            bt_edit.Text = "Update";
            bt_edit.UseVisualStyleBackColor = true;
            bt_edit.Click += bt_edit_Click_1;
            // 
            // bt_addbook
            // 
            bt_addbook.Font = new Font("Adobe Fangsong Std R", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_addbook.Location = new Point(42, 52);
            bt_addbook.Name = "bt_addbook";
            bt_addbook.Size = new Size(75, 35);
            bt_addbook.TabIndex = 25;
            bt_addbook.Text = "ADD";
            bt_addbook.UseVisualStyleBackColor = true;
            bt_addbook.Click += bt_addbook_Click_1;
            // 
            // tb_quantity
            // 
            tb_quantity.Location = new Point(108, 285);
            tb_quantity.Name = "tb_quantity";
            tb_quantity.Size = new Size(100, 23);
            tb_quantity.TabIndex = 24;
            // 
            // tb_genre
            // 
            tb_genre.Location = new Point(108, 244);
            tb_genre.Name = "tb_genre";
            tb_genre.Size = new Size(100, 23);
            tb_genre.TabIndex = 23;
            // 
            // tb_author
            // 
            tb_author.Location = new Point(108, 202);
            tb_author.Name = "tb_author";
            tb_author.Size = new Size(100, 23);
            tb_author.TabIndex = 22;
            // 
            // tb_title
            // 
            tb_title.Location = new Point(108, 158);
            tb_title.Name = "tb_title";
            tb_title.Size = new Size(100, 23);
            tb_title.TabIndex = 21;
            // 
            // tb_bookid
            // 
            tb_bookid.Location = new Point(108, 119);
            tb_bookid.Name = "tb_bookid";
            tb_bookid.Size = new Size(100, 23);
            tb_bookid.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label5.Location = new Point(44, 286);
            label5.Name = "label5";
            label5.Size = new Size(62, 17);
            label5.TabIndex = 19;
            label5.Text = "Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label4.Location = new Point(44, 245);
            label4.Name = "label4";
            label4.Size = new Size(44, 17);
            label4.TabIndex = 18;
            label4.Text = "Genre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.Location = new Point(44, 202);
            label3.Name = "label3";
            label3.Size = new Size(51, 17);
            label3.TabIndex = 17;
            label3.Text = "Author";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.Location = new Point(44, 158);
            label2.Name = "label2";
            label2.Size = new Size(36, 17);
            label2.TabIndex = 16;
            label2.Text = "Title";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.Location = new Point(44, 120);
            label1.Name = "label1";
            label1.Size = new Size(58, 17);
            label1.TabIndex = 15;
            label1.Text = "Book_ID";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dgv3);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(901, 476);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "history borrow book user";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgv3
            // 
            dgv3.BackgroundColor = SystemColors.Control;
            dgv3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv3.Location = new Point(198, 31);
            dgv3.Name = "dgv3";
            dgv3.Size = new Size(695, 405);
            dgv3.TabIndex = 8;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 567);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dgv1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            tabControl1.ResumeLayout(false);
            tabpage1.ResumeLayout(false);
            tabpage1.PerformLayout();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv1;
        private Panel panel1;
        private PictureBox pictureBox4;
        private TabControl tabControl1;
        private TabPage tabpage1;
        private Button button1;
        private Button bt_delete;
        private Button bt_edit;
        private Button bt_addbook;
        private TextBox tb_quantity;
        private TextBox tb_genre;
        private TextBox tb_author;
        private TextBox tb_title;
        private TextBox tb_bookid;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private TabPage tabPage3;
        private DataGridView dgv3;
    }
}