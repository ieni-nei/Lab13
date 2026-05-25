namespace Lab13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in drives)
            {
                cmbDrives.Items.Add(drive.Name);
            }
        }
        private void cmbDrives_SelectedIndexChanged(object sender, EventArgs e)
        {
            treeViewFolders.Nodes.Clear();

            string drive = cmbDrives.SelectedItem.ToString();

            TreeNode root = new TreeNode(drive);
            root.Tag = drive;

            treeViewFolders.Nodes.Add(root);

            LoadDirectories(root);

            ShowDriveInfo(drive);
        }
        private void LoadDirectories(TreeNode node)
        {
            try
            {
                string path = node.Tag.ToString();

                string[] dirs = Directory.GetDirectories(path);

                foreach (string dir in dirs)
                {
                    TreeNode child = new TreeNode(Path.GetFileName(dir));

                    child.Tag = dir;

                    node.Nodes.Add(child);
                }
            }
            catch { }
        }
        private void treeViewFolders_AfterSelect(object sender,
    TreeViewEventArgs e)
        {
            listBoxFiles.Items.Clear();

            string path = e.Node.Tag.ToString();

            try
            {
                foreach (string file in Directory.GetFiles(path))
                {
                    listBoxFiles.Items.Add(file);
                }

                ShowDirectoryInfo(path);
            }
            catch { }
        }
        private void listBoxFiles_SelectedIndexChanged(object sender,
    EventArgs e)
        {
            if (listBoxFiles.SelectedItem == null)
                return;

            string file = listBoxFiles.SelectedItem.ToString();

            ShowFileInfo(file);

            PreviewFile(file);
        }
        private void ShowDriveInfo(string driveName)
        {
            DriveInfo d = new DriveInfo(driveName);

            richTextBoxInfo.Text =
                "Drive: " + d.Name + Environment.NewLine +
                "Type: " + d.DriveType + Environment.NewLine +
                "Format: " + d.DriveFormat + Environment.NewLine +
                "Free Space: " + d.AvailableFreeSpace;
        }
        private void ShowDirectoryInfo(string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);

            richTextBoxInfo.Text =
                "Folder: " + dir.Name + Environment.NewLine +
                "Created: " + dir.CreationTime + Environment.NewLine +
                "Attributes: " + dir.Attributes;
        }
        private void ShowFileInfo(string path)
        {
            FileInfo file = new FileInfo(path);

            richTextBoxInfo.Text =
                "File: " + file.Name + Environment.NewLine +
                "Size: " + file.Length + Environment.NewLine +
                "Extension: " + file.Extension + Environment.NewLine +
                "Created: " + file.CreationTime;
        }
        private void PreviewFile(string path)
        {
            string ext = Path.GetExtension(path).ToLower();

            if (ext == ".jpg" ||
                ext == ".png" ||
                ext == ".bmp")
            {
                pictureBox1.Image = Image.FromFile(path);
            }
            if (ext == ".txt")
            {
                richTextBoxInfo.Text = File.ReadAllText(path);
            }
        }
        private void btnFilterFiles_Click(object sender, EventArgs e)
        {
            if (treeViewFolders.SelectedNode == null)
                return;

            string path =
                treeViewFolders.SelectedNode.Tag.ToString();

            listBoxFiles.Items.Clear();

            string filter = txtFileFilter.Text;

            foreach (string file in Directory.GetFiles(path))
            {
                if (Path.GetFileName(file).Contains(filter))
                {
                    listBoxFiles.Items.Add(file);
                }
            }
        }
        private void btnFilterFolders_Click(object sender, EventArgs e)
        {
            if (treeViewFolders.Nodes.Count == 0)
                return;

            string filter = txtFolderFilter.Text.ToLower();

            foreach (TreeNode node in treeViewFolders.Nodes)
            {
                FilterNodes(node, filter);
            }
        }

        private void FilterNodes(TreeNode node, string filter)
        {
            foreach (TreeNode child in node.Nodes)
            {
                child.BackColor =
                    child.Text.ToLower().Contains(filter)
                    ? Color.Yellow
                    : Color.White;

                FilterNodes(child, filter);
            }
        }
    }
}
