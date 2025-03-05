namespace BusyBeezApplication
{
    partial class frmMainView
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
            lblName = new Label();
            btnAccount = new Button();
            btnNotification = new Button();
            btnNotes = new Button();
            button4 = new Button();
            btnAddTask = new Button();
            txtTask = new TextBox();
            panel1 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            checkBox1 = new CheckBox();
            panel2 = new Panel();
            checkBox9 = new CheckBox();
            textBox6 = new TextBox();
            checkBox8 = new CheckBox();
            textBox5 = new TextBox();
            checkBox7 = new CheckBox();
            lblToday = new Label();
            textBox4 = new TextBox();
            panel3 = new Panel();
            checkBox6 = new CheckBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            checkBox4 = new CheckBox();
            lblNextWeek = new Label();
            textBox1 = new TextBox();
            checkBox2 = new CheckBox();
            panel4 = new Panel();
            checkBox11 = new CheckBox();
            textBox8 = new TextBox();
            checkBox10 = new CheckBox();
            lblAlongWay = new Label();
            textBox7 = new TextBox();
            checkBox3 = new CheckBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(76, 9);
            lblName.Name = "lblName";
            lblName.Size = new Size(75, 20);
            lblName.TabIndex = 2;
            lblName.Text = "Busy Beez";
            lblName.Click += label1_Click;
            // 
            // btnAccount
            // 
            btnAccount.Location = new Point(12, 60);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(217, 29);
            btnAccount.TabIndex = 4;
            btnAccount.Text = "Account";
            btnAccount.UseVisualStyleBackColor = true;
            btnAccount.Click += btnAccount_Click;
            // 
            // btnNotification
            // 
            btnNotification.Location = new Point(12, 120);
            btnNotification.Name = "btnNotification";
            btnNotification.Size = new Size(217, 29);
            btnNotification.TabIndex = 5;
            btnNotification.Text = "Notification";
            btnNotification.UseVisualStyleBackColor = true;
            btnNotification.Click += button1_Click;
            // 
            // btnNotes
            // 
            btnNotes.Location = new Point(12, 180);
            btnNotes.Name = "btnNotes";
            btnNotes.Size = new Size(217, 29);
            btnNotes.TabIndex = 7;
            btnNotes.Text = "Notes";
            btnNotes.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(12, 241);
            button4.Name = "button4";
            button4.Size = new Size(217, 29);
            button4.TabIndex = 8;
            button4.Text = "Track Hobbies";
            button4.UseVisualStyleBackColor = true;
            // 
            // btnAddTask
            // 
            btnAddTask.Location = new Point(548, 49);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(186, 29);
            btnAddTask.TabIndex = 9;
            btnAddTask.Text = "Add Task";
            btnAddTask.UseVisualStyleBackColor = true;
            btnAddTask.Click += button5_Click;
            // 
            // txtTask
            // 
            txtTask.Location = new Point(41, 24);
            txtTask.Name = "txtTask";
            txtTask.PlaceholderText = "Input Task";
            txtTask.Size = new Size(214, 27);
            txtTask.TabIndex = 10;
            txtTask.TextChanged += txtbxTask_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuText;
            panel1.Controls.Add(btnAccount);
            panel1.Controls.Add(btnNotification);
            panel1.Controls.Add(btnNotes);
            panel1.Controls.Add(button4);
            panel1.Location = new Point(0, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 608);
            panel1.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(345, 9);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 14;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(20, 27);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(18, 17);
            checkBox1.TabIndex = 15;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(checkBox9);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(checkBox8);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(checkBox7);
            panel2.Controls.Add(lblToday);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(txtTask);
            panel2.Location = new Point(256, 88);
            panel2.Name = "panel2";
            panel2.Size = new Size(478, 203);
            panel2.TabIndex = 16;
            panel2.Paint += panel2_Paint;
            // 
            // checkBox9
            // 
            checkBox9.AutoSize = true;
            checkBox9.Location = new Point(20, 131);
            checkBox9.Name = "checkBox9";
            checkBox9.Size = new Size(18, 17);
            checkBox9.TabIndex = 28;
            checkBox9.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(41, 128);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Input Task";
            textBox6.Size = new Size(214, 27);
            textBox6.TabIndex = 27;
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.Location = new Point(20, 98);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(18, 17);
            checkBox8.TabIndex = 26;
            checkBox8.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(41, 95);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Input Task";
            textBox5.Size = new Size(214, 27);
            textBox5.TabIndex = 25;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point(20, 65);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(18, 17);
            checkBox7.TabIndex = 24;
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // lblToday
            // 
            lblToday.AutoSize = true;
            lblToday.Location = new Point(3, 4);
            lblToday.Name = "lblToday";
            lblToday.Size = new Size(55, 20);
            lblToday.TabIndex = 18;
            lblToday.Text = "TODAY";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(41, 62);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Input Task";
            textBox4.Size = new Size(214, 27);
            textBox4.TabIndex = 23;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(checkBox6);
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(checkBox4);
            panel3.Controls.Add(lblNextWeek);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(checkBox2);
            panel3.Location = new Point(256, 297);
            panel3.Name = "panel3";
            panel3.Size = new Size(478, 161);
            panel3.TabIndex = 17;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(20, 93);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(18, 17);
            checkBox6.TabIndex = 22;
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(41, 90);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Input Task";
            textBox3.Size = new Size(214, 27);
            textBox3.TabIndex = 21;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(41, 27);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Input Task";
            textBox2.Size = new Size(214, 27);
            textBox2.TabIndex = 21;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(20, 60);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(18, 17);
            checkBox4.TabIndex = 20;
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // lblNextWeek
            // 
            lblNextWeek.AutoSize = true;
            lblNextWeek.Location = new Point(3, 4);
            lblNextWeek.Name = "lblNextWeek";
            lblNextWeek.Size = new Size(80, 20);
            lblNextWeek.TabIndex = 19;
            lblNextWeek.Text = "Next Week";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(41, 57);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Input Task";
            textBox1.Size = new Size(214, 27);
            textBox1.TabIndex = 19;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(20, 27);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(101, 24);
            checkBox2.TabIndex = 15;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(checkBox11);
            panel4.Controls.Add(textBox8);
            panel4.Controls.Add(checkBox10);
            panel4.Controls.Add(lblAlongWay);
            panel4.Controls.Add(textBox7);
            panel4.Controls.Add(checkBox3);
            panel4.Location = new Point(256, 464);
            panel4.Name = "panel4";
            panel4.Size = new Size(478, 175);
            panel4.TabIndex = 17;
            // 
            // checkBox11
            // 
            checkBox11.AutoSize = true;
            checkBox11.Location = new Point(20, 93);
            checkBox11.Name = "checkBox11";
            checkBox11.Size = new Size(18, 17);
            checkBox11.TabIndex = 32;
            checkBox11.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(41, 90);
            textBox8.Name = "textBox8";
            textBox8.PlaceholderText = "Input Task";
            textBox8.Size = new Size(214, 27);
            textBox8.TabIndex = 31;
            // 
            // checkBox10
            // 
            checkBox10.AutoSize = true;
            checkBox10.Location = new Point(20, 60);
            checkBox10.Name = "checkBox10";
            checkBox10.Size = new Size(18, 17);
            checkBox10.TabIndex = 30;
            checkBox10.UseVisualStyleBackColor = true;
            // 
            // lblAlongWay
            // 
            lblAlongWay.AutoSize = true;
            lblAlongWay.Location = new Point(3, 4);
            lblAlongWay.Name = "lblAlongWay";
            lblAlongWay.Size = new Size(85, 20);
            lblAlongWay.TabIndex = 19;
            lblAlongWay.Text = "A long Way";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(41, 57);
            textBox7.Name = "textBox7";
            textBox7.PlaceholderText = "Input Task";
            textBox7.Size = new Size(214, 27);
            textBox7.TabIndex = 29;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(20, 27);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(101, 24);
            checkBox3.TabIndex = 15;
            checkBox3.Text = "checkBox3";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(259, 58);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 29;
            label1.Text = "My work";
            // 
            // frmMainView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(767, 651);
            Controls.Add(label1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(dateTimePicker1);
            Controls.Add(panel1);
            Controls.Add(btnAddTask);
            Controls.Add(lblName);
            Name = "frmMainView";
            Text = "Main Page";
            Load += frmMainView_Load_1;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblName;
        private Button btnAccount;
        private Button btnNotification;
        private Button btnNotes;
        private Button button4;
        private Button btnAddTask;
        private TextBox txtTask;
        private Panel panel1;
        private DateTimePicker dateTimePicker1;
        private CheckBox checkBox1;
        private Panel panel2;
        private Label lblToday;
        private Panel panel3;
        private CheckBox checkBox2;
        private Panel panel4;
        private CheckBox checkBox3;
        private Label lblNextWeek;
        private Label lblAlongWay;
        private CheckBox checkBox9;
        private TextBox textBox6;
        private CheckBox checkBox8;
        private TextBox textBox5;
        private CheckBox checkBox7;
        private TextBox textBox4;
        private CheckBox checkBox6;
        private TextBox textBox3;
        private TextBox textBox2;
        private CheckBox checkBox4;
        private TextBox textBox1;
        private CheckBox checkBox11;
        private TextBox textBox8;
        private CheckBox checkBox10;
        private TextBox textBox7;
        private Label label1;
    }
}
