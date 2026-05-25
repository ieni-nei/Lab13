namespace Lab13
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
            cmbDrives = new ComboBox();
            label1 = new Label();
            treeViewFolders = new TreeView();
            label2 = new Label();
            listBoxFiles = new ListBox();
            label3 = new Label();
            richTextBoxInfo = new RichTextBox();
            label4 = new Label();
            txtFileFilter = new TextBox();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            btnFilterFiles = new Button();
            txtFolderFilter = new TextBox();
            btnFilterFolders = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cmbDrives
            // 
            cmbDrives.FormattingEnabled = true;
            cmbDrives.Location = new Point(128, 25);
            cmbDrives.Name = "cmbDrives";
            cmbDrives.Size = new Size(121, 23);
            cmbDrives.TabIndex = 0;
            cmbDrives.SelectedIndexChanged += cmbDrives_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 28);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 1;
            label1.Text = "список дисків";
            // 
            // treeViewFolders
            // 
            treeViewFolders.Location = new Point(25, 146);
            treeViewFolders.Name = "treeViewFolders";
            treeViewFolders.Size = new Size(114, 224);
            treeViewFolders.TabIndex = 2;
            treeViewFolders.AfterSelect += treeViewFolders_AfterSelect;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 96);
            label2.Name = "label2";
            label2.Size = new Size(114, 15);
            label2.TabIndex = 3;
            label2.Text = "навігація по папках";
            // 
            // listBoxFiles
            // 
            listBoxFiles.FormattingEnabled = true;
            listBoxFiles.ItemHeight = 15;
            listBoxFiles.Location = new Point(184, 141);
            listBoxFiles.Name = "listBoxFiles";
            listBoxFiles.Size = new Size(125, 229);
            listBoxFiles.TabIndex = 4;
            listBoxFiles.SelectedIndexChanged += listBoxFiles_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(184, 96);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 5;
            label3.Text = "файли";
            // 
            // richTextBoxInfo
            // 
            richTextBoxInfo.Location = new Point(646, 141);
            richTextBoxInfo.Name = "richTextBoxInfo";
            richTextBoxInfo.Size = new Size(122, 137);
            richTextBoxInfo.TabIndex = 6;
            richTextBoxInfo.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(697, 96);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 7;
            label4.Text = "властивості";
            // 
            // txtFileFilter
            // 
            txtFileFilter.Location = new Point(381, 25);
            txtFileFilter.Name = "txtFileFilter";
            txtFileFilter.Size = new Size(97, 23);
            txtFileFilter.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(312, 28);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 9;
            label5.Text = "фільтр";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(381, 141);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(231, 229);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // btnFilterFiles
            // 
            btnFilterFiles.Location = new Point(378, 73);
            btnFilterFiles.Name = "btnFilterFiles";
            btnFilterFiles.Size = new Size(122, 38);
            btnFilterFiles.TabIndex = 11;
            btnFilterFiles.Text = "Filter files";
            btnFilterFiles.UseVisualStyleBackColor = true;
            btnFilterFiles.Click += btnFilterFiles_Click;
            // 
            // txtFolderFilter
            // 
            txtFolderFilter.Location = new Point(543, 25);
            txtFolderFilter.Name = "txtFolderFilter";
            txtFolderFilter.Size = new Size(97, 23);
            txtFolderFilter.TabIndex = 12;
            // 
            // btnFilterFolders
            // 
            btnFilterFolders.Location = new Point(543, 73);
            btnFilterFolders.Name = "btnFilterFolders";
            btnFilterFolders.Size = new Size(122, 38);
            btnFilterFolders.TabIndex = 13;
            btnFilterFolders.Text = "Filter folders";
            btnFilterFolders.UseVisualStyleBackColor = true;
            btnFilterFolders.Click += btnFilterFolders_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFilterFolders);
            Controls.Add(txtFolderFilter);
            Controls.Add(btnFilterFiles);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(txtFileFilter);
            Controls.Add(label4);
            Controls.Add(richTextBoxInfo);
            Controls.Add(label3);
            Controls.Add(listBoxFiles);
            Controls.Add(label2);
            Controls.Add(treeViewFolders);
            Controls.Add(label1);
            Controls.Add(cmbDrives);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbDrives;
        private Label label1;
        private TreeView treeViewFolders;
        private Label label2;
        private ListBox listBoxFiles;
        private Label label3;
        private RichTextBox richTextBoxInfo;
        private Label label4;
        private TextBox txtFileFilter;
        private Label label5;
        private PictureBox pictureBox1;
        private Button btnFilterFiles;
        private TextBox txtFolderFilter;
        private Button btnFilterFolders;
    }
}
