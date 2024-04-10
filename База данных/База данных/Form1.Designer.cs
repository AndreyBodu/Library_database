namespace База_данных
{
    partial class Form1
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
            tabPage3 = new TabPage();
            Table_BookClients = new DataGridView();
            panel3 = new Panel();
            comboBoxBook = new ComboBox();
            comboBoxClients = new ComboBox();
            button5 = new Button();
            panel5 = new Panel();
            label11 = new Label();
            button1 = new Button();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label10 = new Label();
            tabPage2 = new TabPage();
            panel1 = new Panel();
            AddText = new Button();
            BookGenre = new TextBox();
            BookName = new TextBox();
            AuthorName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Table_1 = new DataGridView();
            panel4 = new Panel();
            NamberPHone = new TextBox();
            SureNAme = new TextBox();
            label7 = new Label();
            NameClients = new TextBox();
            label6 = new Label();
            button3 = new Button();
            label5 = new Label();
            Table_Clients = new DataGridView();
            panel7 = new Panel();
            button2 = new Button();
            panel8 = new Panel();
            button4 = new Button();
            tabPage1 = new TabPage();
            panel2 = new Panel();
            radioButton1 = new RadioButton();
            label4 = new Label();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            radioButton7 = new RadioButton();
            radioButton8 = new RadioButton();
            radioButton10 = new RadioButton();
            radioButton11 = new RadioButton();
            radioButton12 = new RadioButton();
            radioButton13 = new RadioButton();
            SearchdataGridView1 = new DataGridView();
            tabControl1 = new TabControl();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Table_BookClients).BeginInit();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            tabPage2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Table_1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Table_Clients).BeginInit();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            tabPage1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SearchdataGridView1).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(panel5);
            tabPage3.Controls.Add(panel3);
            tabPage3.Controls.Add(Table_BookClients);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(942, 784);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Выдача книги";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // Table_BookClients
            // 
            Table_BookClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Table_BookClients.Location = new Point(3, 3);
            Table_BookClients.Name = "Table_BookClients";
            Table_BookClients.RowHeadersWidth = 35;
            Table_BookClients.Size = new Size(896, 261);
            Table_BookClients.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGray;
            panel3.Controls.Add(button5);
            panel3.Controls.Add(comboBoxClients);
            panel3.Controls.Add(comboBoxBook);
            panel3.Location = new Point(3, 270);
            panel3.Name = "panel3";
            panel3.Size = new Size(301, 170);
            panel3.TabIndex = 15;
            // 
            // comboBoxBook
            // 
            comboBoxBook.FormattingEnabled = true;
            comboBoxBook.Location = new Point(4, 47);
            comboBoxBook.Name = "comboBoxBook";
            comboBoxBook.Size = new Size(284, 28);
            comboBoxBook.TabIndex = 1;
            // 
            // comboBoxClients
            // 
            comboBoxClients.FormattingEnabled = true;
            comboBoxClients.Location = new Point(4, 13);
            comboBoxClients.Name = "comboBoxClients";
            comboBoxClients.Size = new Size(284, 28);
            comboBoxClients.TabIndex = 0;
            comboBoxClients.SelectedIndexChanged += comboBoxClients_SelectedIndexChanged;
            // 
            // button5
            // 
            button5.Location = new Point(4, 104);
            button5.Name = "button5";
            button5.Size = new Size(172, 63);
            button5.TabIndex = 10;
            button5.Text = "Добавить";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.LightGray;
            panel5.Controls.Add(label10);
            panel5.Controls.Add(textBox4);
            panel5.Controls.Add(textBox3);
            panel5.Controls.Add(button1);
            panel5.Controls.Add(label11);
            panel5.Location = new Point(598, 270);
            panel5.Name = "panel5";
            panel5.Size = new Size(301, 170);
            panel5.TabIndex = 16;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(143, 21);
            label11.Name = "label11";
            label11.Size = new Size(108, 20);
            label11.TabIndex = 12;
            label11.Text = "Номер строки";
            // 
            // button1
            // 
            button1.Location = new Point(12, 94);
            button1.Name = "button1";
            button1.Size = new Size(172, 63);
            button1.TabIndex = 10;
            button1.Text = "Удалить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 14);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 51);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 13;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(143, 58);
            label10.Name = "label10";
            label10.Size = new Size(153, 20);
            label10.TabIndex = 15;
            label10.Text = "ID выбранной нкиги";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel8);
            tabPage2.Controls.Add(panel7);
            tabPage2.Controls.Add(Table_Clients);
            tabPage2.Controls.Add(panel4);
            tabPage2.Controls.Add(Table_1);
            tabPage2.Controls.Add(panel1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(942, 784);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Добавление данных";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(AuthorName);
            panel1.Controls.Add(BookName);
            panel1.Controls.Add(BookGenre);
            panel1.Controls.Add(AddText);
            panel1.Location = new Point(561, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(370, 165);
            panel1.TabIndex = 3;
            // 
            // AddText
            // 
            AddText.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddText.Location = new Point(3, 3);
            AddText.Name = "AddText";
            AddText.Size = new Size(364, 55);
            AddText.TabIndex = 2;
            AddText.Text = "Добавить книгу";
            AddText.UseVisualStyleBackColor = true;
            AddText.Click += AddText_Click;
            // 
            // BookGenre
            // 
            BookGenre.Location = new Point(7, 64);
            BookGenre.MaxLength = 999999999;
            BookGenre.Name = "BookGenre";
            BookGenre.Size = new Size(125, 27);
            BookGenre.TabIndex = 3;
            // 
            // BookName
            // 
            BookName.Location = new Point(7, 97);
            BookName.Name = "BookName";
            BookName.Size = new Size(125, 27);
            BookName.TabIndex = 4;
            // 
            // AuthorName
            // 
            AuthorName.Location = new Point(7, 130);
            AuthorName.Name = "AuthorName";
            AuthorName.Size = new Size(125, 27);
            AuthorName.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(151, 71);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 6;
            label1.Text = "Жанр книги";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(151, 104);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 7;
            label2.Text = "Название книги";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(151, 137);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 8;
            label3.Text = "Имя автора";
            // 
            // Table_1
            // 
            Table_1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Table_1.Location = new Point(6, 6);
            Table_1.Name = "Table_1";
            Table_1.RowHeadersWidth = 51;
            Table_1.Size = new Size(549, 366);
            Table_1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlLight;
            panel4.Controls.Add(label5);
            panel4.Controls.Add(button3);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(NameClients);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(SureNAme);
            panel4.Controls.Add(NamberPHone);
            panel4.Location = new Point(561, 378);
            panel4.Name = "panel4";
            panel4.Size = new Size(370, 165);
            panel4.TabIndex = 9;
            // 
            // NamberPHone
            // 
            NamberPHone.Location = new Point(3, 130);
            NamberPHone.Name = "NamberPHone";
            NamberPHone.Size = new Size(125, 27);
            NamberPHone.TabIndex = 11;
            // 
            // SureNAme
            // 
            SureNAme.Location = new Point(3, 97);
            SureNAme.Name = "SureNAme";
            SureNAme.Size = new Size(125, 27);
            SureNAme.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(147, 71);
            label7.Name = "label7";
            label7.Size = new Size(39, 20);
            label7.TabIndex = 12;
            label7.Text = "Имя";
            // 
            // NameClients
            // 
            NameClients.Location = new Point(3, 64);
            NameClients.MaxLength = 999999999;
            NameClients.Name = "NameClients";
            NameClients.Size = new Size(125, 27);
            NameClients.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(147, 104);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 13;
            label6.Text = "Фамилия";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button3.Location = new Point(3, 3);
            button3.Name = "button3";
            button3.Size = new Size(364, 55);
            button3.TabIndex = 9;
            button3.Text = "Добавить Клиента";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(147, 137);
            label5.Name = "label5";
            label5.Size = new Size(127, 20);
            label5.TabIndex = 14;
            label5.Text = "Номер телефона";
            // 
            // Table_Clients
            // 
            Table_Clients.AllowUserToOrderColumns = true;
            Table_Clients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Table_Clients.Location = new Point(6, 378);
            Table_Clients.Name = "Table_Clients";
            Table_Clients.RowHeadersWidth = 51;
            Table_Clients.Size = new Size(549, 396);
            Table_Clients.TabIndex = 4;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ControlLight;
            panel7.Controls.Add(button2);
            panel7.Location = new Point(561, 177);
            panel7.Name = "panel7";
            panel7.Size = new Size(370, 64);
            panel7.TabIndex = 9;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.Location = new Point(3, 3);
            button2.Name = "button2";
            button2.Size = new Size(364, 55);
            button2.TabIndex = 2;
            button2.Text = "Удалить книгу";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.ControlLight;
            panel8.Controls.Add(button4);
            panel8.Location = new Point(561, 549);
            panel8.Name = "panel8";
            panel8.Size = new Size(370, 64);
            panel8.TabIndex = 10;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button4.Location = new Point(3, 3);
            button4.Name = "button4";
            button4.Size = new Size(364, 55);
            button4.TabIndex = 2;
            button4.Text = "Удалить клиента";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(SearchdataGridView1);
            tabPage1.Controls.Add(panel2);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(942, 784);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Поиск книги";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(radioButton13);
            panel2.Controls.Add(radioButton12);
            panel2.Controls.Add(radioButton11);
            panel2.Controls.Add(radioButton10);
            panel2.Controls.Add(radioButton8);
            panel2.Controls.Add(radioButton7);
            panel2.Controls.Add(radioButton6);
            panel2.Controls.Add(radioButton5);
            panel2.Controls.Add(radioButton4);
            panel2.Controls.Add(radioButton3);
            panel2.Controls.Add(radioButton2);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(radioButton1);
            panel2.Location = new Point(6, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(231, 470);
            panel2.TabIndex = 4;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(3, 47);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(75, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Роман";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(3, 11);
            label4.Name = "label4";
            label4.Size = new Size(141, 31);
            label4.TabIndex = 1;
            label4.Text = "Жанры книг";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(3, 77);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(76, 24);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "Ужасы";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(3, 107);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(110, 24);
            radioButton3.TabIndex = 3;
            radioButton3.TabStop = true;
            radioButton3.Text = "Блокбастер";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(3, 167);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(132, 24);
            radioButton4.TabIndex = 4;
            radioButton4.TabStop = true;
            radioButton4.Text = "Энциклопедия";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(3, 137);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(88, 24);
            radioButton5.TabIndex = 5;
            radioButton5.TabStop = true;
            radioButton5.Text = "Фентези";
            radioButton5.UseVisualStyleBackColor = true;
            radioButton5.CheckedChanged += radioButton5_CheckedChanged;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(3, 197);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(109, 24);
            radioButton6.TabIndex = 6;
            radioButton6.TabStop = true;
            radioButton6.Text = "Фантастика";
            radioButton6.UseVisualStyleBackColor = true;
            radioButton6.CheckedChanged += radioButton6_CheckedChanged;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Location = new Point(3, 227);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(80, 24);
            radioButton7.TabIndex = 7;
            radioButton7.TabStop = true;
            radioButton7.Text = "Утопия";
            radioButton7.UseVisualStyleBackColor = true;
            radioButton7.CheckedChanged += radioButton7_CheckedChanged;
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.Location = new Point(3, 257);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(112, 24);
            radioButton8.TabIndex = 8;
            radioButton8.TabStop = true;
            radioButton8.Text = "Антиутопия";
            radioButton8.UseVisualStyleBackColor = true;
            radioButton8.CheckedChanged += radioButton8_CheckedChanged;
            // 
            // radioButton10
            // 
            radioButton10.AutoSize = true;
            radioButton10.Location = new Point(3, 287);
            radioButton10.Name = "radioButton10";
            radioButton10.Size = new Size(77, 24);
            radioButton10.TabIndex = 10;
            radioButton10.TabStop = true;
            radioButton10.Text = "Сказки";
            radioButton10.UseVisualStyleBackColor = true;
            radioButton10.CheckedChanged += radioButton10_CheckedChanged;
            // 
            // radioButton11
            // 
            radioButton11.AutoSize = true;
            radioButton11.Location = new Point(3, 317);
            radioButton11.Name = "radioButton11";
            radioButton11.Size = new Size(93, 24);
            radioButton11.TabIndex = 11;
            radioButton11.TabStop = true;
            radioButton11.Text = "Рассказы";
            radioButton11.UseVisualStyleBackColor = true;
            radioButton11.CheckedChanged += radioButton11_CheckedChanged;
            // 
            // radioButton12
            // 
            radioButton12.AutoSize = true;
            radioButton12.Location = new Point(3, 347);
            radioButton12.Name = "radioButton12";
            radioButton12.Size = new Size(79, 24);
            radioButton12.TabIndex = 12;
            radioButton12.TabStop = true;
            radioButton12.Text = "Драмы";
            radioButton12.UseVisualStyleBackColor = true;
            radioButton12.CheckedChanged += radioButton12_CheckedChanged;
            // 
            // radioButton13
            // 
            radioButton13.AutoSize = true;
            radioButton13.Location = new Point(4, 377);
            radioButton13.Name = "radioButton13";
            radioButton13.Size = new Size(115, 24);
            radioButton13.TabIndex = 13;
            radioButton13.TabStop = true;
            radioButton13.Text = "Мелодрамы";
            radioButton13.UseVisualStyleBackColor = true;
            radioButton13.CheckedChanged += radioButton13_CheckedChanged;
            // 
            // SearchdataGridView1
            // 
            SearchdataGridView1.AllowUserToOrderColumns = true;
            SearchdataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SearchdataGridView1.Location = new Point(263, 6);
            SearchdataGridView1.Name = "SearchdataGridView1";
            SearchdataGridView1.RowHeadersWidth = 51;
            SearchdataGridView1.Size = new Size(659, 470);
            SearchdataGridView1.TabIndex = 5;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(10, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(950, 817);
            tabControl1.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(963, 833);
            Controls.Add(tabControl1);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "БД библиотеки";
            Load += Form1_Load;
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Table_BookClients).EndInit();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            tabPage2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Table_1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Table_Clients).EndInit();
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SearchdataGridView1).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage3;
        private Panel panel5;
        private Label label10;
        private TextBox textBox4;
        private TextBox textBox3;
        private Button button1;
        private Label label11;
        private Panel panel3;
        private Button button5;
        private ComboBox comboBoxClients;
        private ComboBox comboBoxBook;
        private DataGridView Table_BookClients;
        private TabPage tabPage2;
        private Panel panel8;
        private Button button4;
        private Panel panel7;
        private Button button2;
        private DataGridView Table_Clients;
        private Panel panel4;
        private Label label5;
        private Button button3;
        private Label label6;
        private TextBox NameClients;
        private Label label7;
        private TextBox SureNAme;
        private TextBox NamberPHone;
        private DataGridView Table_1;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox AuthorName;
        private TextBox BookName;
        private TextBox BookGenre;
        private Button AddText;
        private TabPage tabPage1;
        private DataGridView SearchdataGridView1;
        private Panel panel2;
        private RadioButton radioButton13;
        private RadioButton radioButton12;
        private RadioButton radioButton11;
        private RadioButton radioButton10;
        private RadioButton radioButton8;
        private RadioButton radioButton7;
        private RadioButton radioButton6;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private Label label4;
        private RadioButton radioButton1;
        private TabControl tabControl1;
    }
}
