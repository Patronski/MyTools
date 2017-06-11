namespace CommentingAndUncommentingFilesWF
{
    partial class Form1
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
            this.richTextBoxSelectedFolder = new System.Windows.Forms.RichTextBox();
            this.buttonSelectFolder = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBoxAllFilesCount = new System.Windows.Forms.TextBox();
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonComment = new System.Windows.Forms.Button();
            this.buttonUncomment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBoxSelectedFolder
            // 
            this.richTextBoxSelectedFolder.Location = new System.Drawing.Point(12, 29);
            this.richTextBoxSelectedFolder.Name = "richTextBoxSelectedFolder";
            this.richTextBoxSelectedFolder.Size = new System.Drawing.Size(281, 52);
            this.richTextBoxSelectedFolder.TabIndex = 2;
            this.richTextBoxSelectedFolder.Text = "";
            // 
            // buttonSelectFolder
            // 
            this.buttonSelectFolder.Location = new System.Drawing.Point(12, 0);
            this.buttonSelectFolder.Name = "buttonSelectFolder";
            this.buttonSelectFolder.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectFolder.TabIndex = 3;
            this.buttonSelectFolder.Text = "SelectFolder";
            this.buttonSelectFolder.UseVisualStyleBackColor = true;
            this.buttonSelectFolder.Click += new System.EventHandler(this.buttonSelectFolder_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 117);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(67, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "select all";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBoxAllFilesCount
            // 
            this.textBoxAllFilesCount.Location = new System.Drawing.Point(82, 88);
            this.textBoxAllFilesCount.Name = "textBoxAllFilesCount";
            this.textBoxAllFilesCount.Size = new System.Drawing.Size(39, 20);
            this.textBoxAllFilesCount.TabIndex = 7;
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.Location = new System.Drawing.Point(12, 140);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxFiles.Size = new System.Drawing.Size(281, 264);
            this.listBoxFiles.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Found Files:";
            // 
            // buttonComment
            // 
            this.buttonComment.Location = new System.Drawing.Point(137, 88);
            this.buttonComment.Name = "buttonComment";
            this.buttonComment.Size = new System.Drawing.Size(75, 23);
            this.buttonComment.TabIndex = 10;
            this.buttonComment.Text = "Comment!";
            this.buttonComment.UseVisualStyleBackColor = true;
            this.buttonComment.Click += new System.EventHandler(this.buttonComment_Click);
            // 
            // buttonUncomment
            // 
            this.buttonUncomment.Location = new System.Drawing.Point(218, 88);
            this.buttonUncomment.Name = "buttonUncomment";
            this.buttonUncomment.Size = new System.Drawing.Size(75, 23);
            this.buttonUncomment.TabIndex = 11;
            this.buttonUncomment.Text = "Uncomment!";
            this.buttonUncomment.UseVisualStyleBackColor = true;
            this.buttonUncomment.Click += new System.EventHandler(this.buttonUncomment_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 421);
            this.Controls.Add(this.buttonUncomment);
            this.Controls.Add(this.buttonComment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxFiles);
            this.Controls.Add(this.textBoxAllFilesCount);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.buttonSelectFolder);
            this.Controls.Add(this.richTextBoxSelectedFolder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBoxSelectedFolder;
        private System.Windows.Forms.Button buttonSelectFolder;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBoxAllFilesCount;
        private System.Windows.Forms.ListBox listBoxFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonComment;
        private System.Windows.Forms.Button buttonUncomment;
    }
}

