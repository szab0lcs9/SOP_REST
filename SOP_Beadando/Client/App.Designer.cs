
namespace Client
{
    partial class App
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
            this.title = new System.Windows.Forms.Label();
            this.getButton = new System.Windows.Forms.Button();
            this.postButton = new System.Windows.Forms.Button();
            this.putButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.contentTextBox = new System.Windows.Forms.TextBox();
            this.getWithId = new System.Windows.Forms.LinkLabel();
            this.getAll = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.contentListBox = new System.Windows.Forms.ListBox();
            this.idErrorNote = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.authorErrorNote = new System.Windows.Forms.Label();
            this.contentErrorNote = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.title.Location = new System.Drawing.Point(15, 19);
            this.title.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.title.Name = "title";
            this.title.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.title.Size = new System.Drawing.Size(364, 40);
            this.title.TabIndex = 0;
            this.title.Text = "Today\'s corny jokes";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // getButton
            // 
            this.getButton.BackColor = System.Drawing.Color.Yellow;
            this.getButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getButton.Font = new System.Drawing.Font("Ravie", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.getButton.Location = new System.Drawing.Point(83, 117);
            this.getButton.Name = "getButton";
            this.getButton.Size = new System.Drawing.Size(202, 60);
            this.getButton.TabIndex = 1;
            this.getButton.Text = "Get your daily joke!";
            this.getButton.UseVisualStyleBackColor = false;
            this.getButton.Click += new System.EventHandler(this.getButton_Click);
            // 
            // postButton
            // 
            this.postButton.BackColor = System.Drawing.Color.Yellow;
            this.postButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.postButton.Font = new System.Drawing.Font("Ravie", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.postButton.Location = new System.Drawing.Point(83, 323);
            this.postButton.Name = "postButton";
            this.postButton.Size = new System.Drawing.Size(202, 30);
            this.postButton.TabIndex = 2;
            this.postButton.Text = "Write a new joke!";
            this.postButton.UseVisualStyleBackColor = false;
            this.postButton.Click += new System.EventHandler(this.postButton_Click);
            // 
            // putButton
            // 
            this.putButton.BackColor = System.Drawing.Color.Yellow;
            this.putButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.putButton.Font = new System.Drawing.Font("Ravie", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.putButton.Location = new System.Drawing.Point(83, 368);
            this.putButton.Name = "putButton";
            this.putButton.Size = new System.Drawing.Size(202, 30);
            this.putButton.TabIndex = 3;
            this.putButton.Text = "Modify your joke!";
            this.putButton.UseVisualStyleBackColor = false;
            this.putButton.Click += new System.EventHandler(this.putButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Yellow;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Ravie", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteButton.Location = new System.Drawing.Point(83, 411);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(202, 30);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Delete your joke!";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(436, 323);
            this.idTextBox.Multiline = true;
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(63, 30);
            this.idTextBox.TabIndex = 6;
            // 
            // contentTextBox
            // 
            this.contentTextBox.Location = new System.Drawing.Point(436, 368);
            this.contentTextBox.Multiline = true;
            this.contentTextBox.Name = "contentTextBox";
            this.contentTextBox.Size = new System.Drawing.Size(217, 30);
            this.contentTextBox.TabIndex = 7;
            // 
            // getWithId
            // 
            this.getWithId.ActiveLinkColor = System.Drawing.Color.Black;
            this.getWithId.AutoSize = true;
            this.getWithId.LinkColor = System.Drawing.Color.Black;
            this.getWithId.Location = new System.Drawing.Point(83, 191);
            this.getWithId.Name = "getWithId";
            this.getWithId.Size = new System.Drawing.Size(202, 15);
            this.getWithId.TabIndex = 8;
            this.getWithId.TabStop = true;
            this.getWithId.Text = "If you want a specific joke, click here!";
            this.getWithId.VisitedLinkColor = System.Drawing.Color.Black;
            this.getWithId.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.getWithId_LinkClicked);
            // 
            // getAll
            // 
            this.getAll.ActiveLinkColor = System.Drawing.Color.Black;
            this.getAll.AutoSize = true;
            this.getAll.LinkColor = System.Drawing.Color.Black;
            this.getAll.Location = new System.Drawing.Point(83, 216);
            this.getAll.Name = "getAll";
            this.getAll.Size = new System.Drawing.Size(161, 15);
            this.getAll.TabIndex = 9;
            this.getAll.TabStop = true;
            this.getAll.Text = "Click here to get all the jokes!";
            this.getAll.VisitedLinkColor = System.Drawing.Color.Black;
            this.getAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.getAll_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 539);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Created by: Veres Szabolcs - NY4KT5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(408, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Content:";
            // 
            // contentListBox
            // 
            this.contentListBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.contentListBox.AllowDrop = true;
            this.contentListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contentListBox.ColumnWidth = 50;
            this.contentListBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.contentListBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contentListBox.HorizontalScrollbar = true;
            this.contentListBox.ItemHeight = 15;
            this.contentListBox.Location = new System.Drawing.Point(377, 117);
            this.contentListBox.Name = "contentListBox";
            this.contentListBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.contentListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.contentListBox.Size = new System.Drawing.Size(510, 167);
            this.contentListBox.TabIndex = 13;
            // 
            // idErrorNote
            // 
            this.idErrorNote.AutoSize = true;
            this.idErrorNote.ForeColor = System.Drawing.Color.Red;
            this.idErrorNote.Location = new System.Drawing.Point(505, 331);
            this.idErrorNote.Name = "idErrorNote";
            this.idErrorNote.Size = new System.Drawing.Size(120, 15);
            this.idErrorNote.TabIndex = 14;
            this.idErrorNote.Text = "*This field is required!";
            this.idErrorNote.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(383, 419);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Author:";
            this.label4.Visible = false;
            // 
            // authorTextBox
            // 
            this.authorTextBox.Location = new System.Drawing.Point(436, 411);
            this.authorTextBox.Multiline = true;
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(100, 30);
            this.authorTextBox.TabIndex = 16;
            this.authorTextBox.Visible = false;
            // 
            // authorErrorNote
            // 
            this.authorErrorNote.AutoSize = true;
            this.authorErrorNote.ForeColor = System.Drawing.Color.Red;
            this.authorErrorNote.Location = new System.Drawing.Point(542, 419);
            this.authorErrorNote.Name = "authorErrorNote";
            this.authorErrorNote.Size = new System.Drawing.Size(120, 15);
            this.authorErrorNote.TabIndex = 17;
            this.authorErrorNote.Text = "*This field is required!";
            this.authorErrorNote.Visible = false;
            // 
            // contentErrorNote
            // 
            this.contentErrorNote.AutoSize = true;
            this.contentErrorNote.ForeColor = System.Drawing.Color.Red;
            this.contentErrorNote.Location = new System.Drawing.Point(659, 376);
            this.contentErrorNote.Name = "contentErrorNote";
            this.contentErrorNote.Size = new System.Drawing.Size(120, 15);
            this.contentErrorNote.TabIndex = 18;
            this.contentErrorNote.Text = "*This field is required!";
            this.contentErrorNote.Visible = false;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Ravie", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginLabel.LinkColor = System.Drawing.Color.Black;
            this.loginLabel.Location = new System.Drawing.Point(941, 535);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(55, 17);
            this.loginLabel.TabIndex = 19;
            this.loginLabel.TabStop = true;
            this.loginLabel.Text = "Log in";
            this.loginLabel.VisitedLinkColor = System.Drawing.Color.Black;
            this.loginLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.loginLabel_LinkClicked);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.contentErrorNote);
            this.Controls.Add(this.authorErrorNote);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.idErrorNote);
            this.Controls.Add(this.contentListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.getAll);
            this.Controls.Add(this.getWithId);
            this.Controls.Add(this.contentTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.putButton);
            this.Controls.Add(this.postButton);
            this.Controls.Add(this.getButton);
            this.Controls.Add(this.title);
            this.HelpButton = true;
            this.Name = "App";
            this.Text = "Corny Jokes";
            this.Load += new System.EventHandler(this.CornyJokes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button getButton;
        private System.Windows.Forms.Button postButton;
        private System.Windows.Forms.Button putButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox contentTextBox;
        private System.Windows.Forms.LinkLabel getWithId;
        private System.Windows.Forms.LinkLabel getAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox contentListBox;
        private System.Windows.Forms.Label idErrorNote;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.Label authorErrorNote;
        private System.Windows.Forms.Label contentErrorNote;
        public System.Windows.Forms.LinkLabel loginLabel;
    }
}

