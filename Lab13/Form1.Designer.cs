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
            menuStrip1 = new MenuStrip();
            folderToolStripMenuItem = new ToolStripMenuItem();
            createToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            moveToolStripMenuItem = new ToolStripMenuItem();
            fileToolStripMenuItem = new ToolStripMenuItem();
            createToolStripMenuItem1 = new ToolStripMenuItem();
            deleteToolStripMenuItem1 = new ToolStripMenuItem();
            copyToolStripMenuItem1 = new ToolStripMenuItem();
            moveToolStripMenuItem1 = new ToolStripMenuItem();
            otherToolStripMenuItem = new ToolStripMenuItem();
            changeAttributesToolStripMenuItem = new ToolStripMenuItem();
            saveTextToolStripMenuItem = new ToolStripMenuItem();
            zIPToolStripMenuItem = new ToolStripMenuItem();
            uNZIPToolStripMenuItem = new ToolStripMenuItem();
            txtNewName = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // cmbDrives
            // 
            cmbDrives.FormattingEnabled = true;
            cmbDrives.Location = new Point(128, 82);
            cmbDrives.Name = "cmbDrives";
            cmbDrives.Size = new Size(121, 23);
            cmbDrives.TabIndex = 0;
            cmbDrives.SelectedIndexChanged += cmbDrives_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 85);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 1;
            label1.Text = "список дисків";
            // 
            // treeViewFolders
            // 
            treeViewFolders.Location = new Point(25, 203);
            treeViewFolders.Name = "treeViewFolders";
            treeViewFolders.Size = new Size(174, 224);
            treeViewFolders.TabIndex = 2;
            treeViewFolders.BeforeExpand += treeViewFolders_BeforeExpand;
            treeViewFolders.AfterSelect += treeViewFolders_AfterSelect;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 153);
            label2.Name = "label2";
            label2.Size = new Size(114, 15);
            label2.TabIndex = 3;
            label2.Text = "навігація по папках";
            // 
            // listBoxFiles
            // 
            listBoxFiles.FormattingEnabled = true;
            listBoxFiles.ItemHeight = 15;
            listBoxFiles.Location = new Point(227, 198);
            listBoxFiles.Name = "listBoxFiles";
            listBoxFiles.Size = new Size(172, 229);
            listBoxFiles.TabIndex = 4;
            listBoxFiles.SelectedIndexChanged += listBoxFiles_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(207, 153);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 5;
            label3.Text = "файли";
            // 
            // richTextBoxInfo
            // 
            richTextBoxInfo.Location = new Point(659, 198);
            richTextBoxInfo.Name = "richTextBoxInfo";
            richTextBoxInfo.Size = new Size(109, 137);
            richTextBoxInfo.TabIndex = 6;
            richTextBoxInfo.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(697, 153);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 7;
            label4.Text = "властивості";
            // 
            // txtFileFilter
            // 
            txtFileFilter.Location = new Point(381, 82);
            txtFileFilter.Name = "txtFileFilter";
            txtFileFilter.Size = new Size(97, 23);
            txtFileFilter.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(312, 85);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 9;
            label5.Text = "фільтр";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(435, 198);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(205, 229);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // btnFilterFiles
            // 
            btnFilterFiles.Location = new Point(378, 130);
            btnFilterFiles.Name = "btnFilterFiles";
            btnFilterFiles.Size = new Size(122, 38);
            btnFilterFiles.TabIndex = 11;
            btnFilterFiles.Text = "Filter files";
            btnFilterFiles.UseVisualStyleBackColor = true;
            btnFilterFiles.Click += btnFilterFiles_Click;
            // 
            // txtFolderFilter
            // 
            txtFolderFilter.Location = new Point(543, 82);
            txtFolderFilter.Name = "txtFolderFilter";
            txtFolderFilter.Size = new Size(97, 23);
            txtFolderFilter.TabIndex = 12;
            // 
            // btnFilterFolders
            // 
            btnFilterFolders.Location = new Point(543, 130);
            btnFilterFolders.Name = "btnFilterFolders";
            btnFilterFolders.Size = new Size(122, 38);
            btnFilterFolders.TabIndex = 13;
            btnFilterFolders.Text = "Filter folders";
            btnFilterFolders.UseVisualStyleBackColor = true;
            btnFilterFolders.Click += btnFilterFolders_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { folderToolStripMenuItem, fileToolStripMenuItem, otherToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 14;
            menuStrip1.Text = "menuStrip1";
            // 
            // folderToolStripMenuItem
            // 
            folderToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createToolStripMenuItem, deleteToolStripMenuItem, copyToolStripMenuItem, moveToolStripMenuItem });
            folderToolStripMenuItem.Name = "folderToolStripMenuItem";
            folderToolStripMenuItem.Size = new Size(52, 20);
            folderToolStripMenuItem.Text = "Folder";
            // 
            // createToolStripMenuItem
            // 
            createToolStripMenuItem.Name = "createToolStripMenuItem";
            createToolStripMenuItem.Size = new Size(108, 22);
            createToolStripMenuItem.Text = "Create";
            createToolStripMenuItem.Click += createToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(108, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(108, 22);
            copyToolStripMenuItem.Text = "Copy";
            copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
            // 
            // moveToolStripMenuItem
            // 
            moveToolStripMenuItem.Name = "moveToolStripMenuItem";
            moveToolStripMenuItem.Size = new Size(108, 22);
            moveToolStripMenuItem.Text = "Move";
            moveToolStripMenuItem.Click += moveToolStripMenuItem_Click;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createToolStripMenuItem1, deleteToolStripMenuItem1, copyToolStripMenuItem1, moveToolStripMenuItem1 });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // createToolStripMenuItem1
            // 
            createToolStripMenuItem1.Name = "createToolStripMenuItem1";
            createToolStripMenuItem1.Size = new Size(108, 22);
            createToolStripMenuItem1.Text = "Create";
            createToolStripMenuItem1.Click += createToolStripMenuItem1_Click;
            // 
            // deleteToolStripMenuItem1
            // 
            deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            deleteToolStripMenuItem1.Size = new Size(108, 22);
            deleteToolStripMenuItem1.Text = "Delete";
            deleteToolStripMenuItem1.Click += deleteToolStripMenuItem1_Click;
            // 
            // copyToolStripMenuItem1
            // 
            copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            copyToolStripMenuItem1.Size = new Size(108, 22);
            copyToolStripMenuItem1.Text = "Copy";
            copyToolStripMenuItem1.Click += copyToolStripMenuItem1_Click;
            // 
            // moveToolStripMenuItem1
            // 
            moveToolStripMenuItem1.Name = "moveToolStripMenuItem1";
            moveToolStripMenuItem1.Size = new Size(108, 22);
            moveToolStripMenuItem1.Text = "Move";
            moveToolStripMenuItem1.Click += moveToolStripMenuItem1_Click;
            // 
            // otherToolStripMenuItem
            // 
            otherToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { changeAttributesToolStripMenuItem, saveTextToolStripMenuItem, zIPToolStripMenuItem, uNZIPToolStripMenuItem });
            otherToolStripMenuItem.Name = "otherToolStripMenuItem";
            otherToolStripMenuItem.Size = new Size(49, 20);
            otherToolStripMenuItem.Text = "Other";
            // 
            // changeAttributesToolStripMenuItem
            // 
            changeAttributesToolStripMenuItem.Name = "changeAttributesToolStripMenuItem";
            changeAttributesToolStripMenuItem.Size = new Size(170, 22);
            changeAttributesToolStripMenuItem.Text = "Change Attributes";
            changeAttributesToolStripMenuItem.Click += changeAttributesToolStripMenuItem_Click;
            // 
            // saveTextToolStripMenuItem
            // 
            saveTextToolStripMenuItem.Name = "saveTextToolStripMenuItem";
            saveTextToolStripMenuItem.Size = new Size(170, 22);
            saveTextToolStripMenuItem.Text = "Save Text";
            saveTextToolStripMenuItem.Click += saveTextToolStripMenuItem_Click;
            // 
            // zIPToolStripMenuItem
            // 
            zIPToolStripMenuItem.Name = "zIPToolStripMenuItem";
            zIPToolStripMenuItem.Size = new Size(170, 22);
            zIPToolStripMenuItem.Text = "ZIP";
            zIPToolStripMenuItem.Click += zIPToolStripMenuItem_Click;
            // 
            // uNZIPToolStripMenuItem
            // 
            uNZIPToolStripMenuItem.Name = "uNZIPToolStripMenuItem";
            uNZIPToolStripMenuItem.Size = new Size(170, 22);
            uNZIPToolStripMenuItem.Text = "UNZIP";
            uNZIPToolStripMenuItem.Click += uNZIPToolStripMenuItem_Click;
            // 
            // txtNewName
            // 
            txtNewName.Location = new Point(128, 38);
            txtNewName.Name = "txtNewName";
            txtNewName.Size = new Size(100, 23);
            txtNewName.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 46);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 16;
            label6.Text = "Нове ім'я";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(txtNewName);
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
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private MenuStrip menuStrip1;
        private ToolStripMenuItem folderToolStripMenuItem;
        private ToolStripMenuItem createToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem moveToolStripMenuItem;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem createToolStripMenuItem1;
        private ToolStripMenuItem deleteToolStripMenuItem1;
        private ToolStripMenuItem copyToolStripMenuItem1;
        private ToolStripMenuItem moveToolStripMenuItem1;
        private ToolStripMenuItem otherToolStripMenuItem;
        private ToolStripMenuItem changeAttributesToolStripMenuItem;
        private ToolStripMenuItem saveTextToolStripMenuItem;
        private ToolStripMenuItem zIPToolStripMenuItem;
        private ToolStripMenuItem uNZIPToolStripMenuItem;
        private TextBox txtNewName;
        private Label label6;
    }
}
