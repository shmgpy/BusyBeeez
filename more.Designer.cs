namespace BusyBeezApplication
{
    partial class more
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
            txtTaskName = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            dateTimePicker2 = new DateTimePicker();
            richTextBox1 = new RichTextBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            label3 = new Label();
            btnCreateTask = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtTaskName
            // 
            txtTaskName.Location = new Point(27, 25);
            txtTaskName.Name = "txtTaskName";
            txtTaskName.PlaceholderText = "Task name*";
            txtTaskName.Size = new Size(452, 27);
            txtTaskName.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarTitleBackColor = Color.Aqua;
            dateTimePicker1.Location = new Point(27, 111);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(265, 27);
            dateTimePicker1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 88);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 2;
            label1.Text = "Start date";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(27, 82);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(21, 26);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(27, 151);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(21, 26);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 157);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 5;
            label2.Text = "Due date";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarTitleBackColor = Color.Aqua;
            dateTimePicker2.Location = new Point(27, 180);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(265, 27);
            dateTimePicker2.TabIndex = 4;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(27, 232);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(452, 120);
            richTextBox1.TabIndex = 8;
            richTextBox1.Text = "Description*";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(353, 111);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(91, 24);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Easy Task";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(353, 151);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(117, 24);
            checkBox2.TabIndex = 10;
            checkBox2.Text = "Meduim Task";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(353, 193);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(95, 24);
            checkBox3.TabIndex = 11;
            checkBox3.Text = "Hard Task";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(366, 82);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 12;
            label3.Text = "How Hard";
            label3.Click += label3_Click;
            // 
            // btnCreateTask
            // 
            btnCreateTask.Location = new Point(366, 378);
            btnCreateTask.Name = "btnCreateTask";
            btnCreateTask.Size = new Size(94, 29);
            btnCreateTask.TabIndex = 13;
            btnCreateTask.Text = "Create Task";
            btnCreateTask.UseVisualStyleBackColor = true;
            // 
            // more
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(509, 428);
            Controls.Add(btnCreateTask);
            Controls.Add(label3);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(richTextBox1);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(dateTimePicker2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtTaskName);
            Name = "more";
            Text = "Add Task";
            Load += more_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTaskName;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label2;
        private DateTimePicker dateTimePicker2;
        private RichTextBox richTextBox1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private Label label3;
        private Button btnCreateTask;
    }
}