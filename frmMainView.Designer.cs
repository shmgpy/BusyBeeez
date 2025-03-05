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
            monthCalendar1 = new MonthCalendar();
            checkedListBox1 = new CheckedListBox();
            lblName = new Label();
            lblTodolist = new Label();
            btnAccount = new Button();
            btnNotification = new Button();
            btnProgress = new Button();
            btnNotes = new Button();
            button4 = new Button();
            button5 = new Button();
            txtTask = new TextBox();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(18, 85);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(309, 85);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(264, 202);
            checkedListBox1.TabIndex = 1;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(100, 53);
            lblName.Name = "lblName";
            lblName.Size = new Size(75, 20);
            lblName.TabIndex = 2;
            lblName.Text = "Busy Beez";
            lblName.Click += label1_Click;
            // 
            // lblTodolist
            // 
            lblTodolist.AutoSize = true;
            lblTodolist.Location = new Point(408, 53);
            lblTodolist.Name = "lblTodolist";
            lblTodolist.Size = new Size(77, 20);
            lblTodolist.TabIndex = 3;
            lblTodolist.Text = "To-Do List";
            // 
            // btnAccount
            // 
            btnAccount.Location = new Point(599, 85);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(104, 29);
            btnAccount.TabIndex = 4;
            btnAccount.Text = "Account";
            btnAccount.UseVisualStyleBackColor = true;
            btnAccount.Click += btnAccount_Click;
            // 
            // btnNotification
            // 
            btnNotification.Location = new Point(599, 142);
            btnNotification.Name = "btnNotification";
            btnNotification.Size = new Size(104, 29);
            btnNotification.TabIndex = 5;
            btnNotification.Text = "Notification";
            btnNotification.UseVisualStyleBackColor = true;
            btnNotification.Click += button1_Click;
            // 
            // btnProgress
            // 
            btnProgress.Location = new Point(599, 196);
            btnProgress.Name = "btnProgress";
            btnProgress.Size = new Size(104, 29);
            btnProgress.TabIndex = 6;
            btnProgress.Text = "Progress";
            btnProgress.UseVisualStyleBackColor = true;
            btnProgress.Click += button2_Click;
            // 
            // btnNotes
            // 
            btnNotes.Location = new Point(599, 248);
            btnNotes.Name = "btnNotes";
            btnNotes.Size = new Size(104, 29);
            btnNotes.TabIndex = 7;
            btnNotes.Text = "Notes";
            btnNotes.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(64, 304);
            button4.Name = "button4";
            button4.Size = new Size(171, 29);
            button4.TabIndex = 8;
            button4.Text = "Track Hobbies";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(357, 326);
            button5.Name = "button5";
            button5.Size = new Size(186, 29);
            button5.TabIndex = 9;
            button5.Text = "Create Task";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // txtTask
            // 
            txtTask.Location = new Point(341, 293);
            txtTask.Name = "txtTask";
            txtTask.PlaceholderText = "Input Task";
            txtTask.Size = new Size(214, 27);
            txtTask.TabIndex = 10;
            txtTask.TextChanged += txtbxTask_TextChanged;
            // 
            // frmMainView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(738, 379);
            Controls.Add(txtTask);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(btnNotes);
            Controls.Add(btnProgress);
            Controls.Add(btnNotification);
            Controls.Add(btnAccount);
            Controls.Add(lblTodolist);
            Controls.Add(lblName);
            Controls.Add(checkedListBox1);
            Controls.Add(monthCalendar1);
            Name = "frmMainView";
            Text = "Main Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar monthCalendar1;
        private CheckedListBox checkedListBox1;
        private Label lblName;
        private Label lblTodolist;
        private Button btnAccount;
        private Button btnNotification;
        private Button btnProgress;
        private Button btnNotes;
        private Button button4;
        private Button button5;
        private TextBox txtTask;
    }
}
