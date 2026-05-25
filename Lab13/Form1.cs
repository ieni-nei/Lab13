using System.IO.Compression;

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

                foreach (string dir in Directory.GetDirectories(path))
                {
                    TreeNode child =
                        new TreeNode(Path.GetFileName(dir));

                    child.Tag = dir;

                    // fake child
                    child.Nodes.Add("Loading...");

                    node.Nodes.Add(child);
                }
            }
            catch { }
        }

        private void treeViewFolders_BeforeExpand(
    object sender,
    TreeViewCancelEventArgs e)
        {
            try
            {
                // remove fake node
                if (e.Node.Nodes.Count == 1 &&
                    e.Node.Nodes[0].Text == "Loading...")
                {
                    e.Node.Nodes.Clear();

                    string path = e.Node.Tag.ToString();

                    foreach (string dir in Directory.GetDirectories(path))
                    {
                        TreeNode child =
                            new TreeNode(Path.GetFileName(dir));

                        child.Tag = dir;

                        child.Nodes.Add("Loading...");

                        e.Node.Nodes.Add(child);
                    }
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
                richTextBoxInfo.Text =
                    File.ReadAllText(path);
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

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (treeViewFolders.SelectedNode == null)
                {
                    MessageBox.Show("Select folder first");
                    return;
                }

                string currentPath =
                    treeViewFolders.SelectedNode.Tag.ToString();

                string newFolder =
                    Path.Combine(currentPath, txtNewName.Text);

                Directory.CreateDirectory(newFolder);

                MessageBox.Show("Folder created");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string path =
                    treeViewFolders.SelectedNode.Tag.ToString();

                Directory.Delete(path, true);

                MessageBox.Show("Folder deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string source =
                    treeViewFolders.SelectedNode.Tag.ToString();

                FolderBrowserDialog fbd =
                    new FolderBrowserDialog();

                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    string destination =
                        Path.Combine(
                            fbd.SelectedPath,
                            Path.GetFileName(source));

                    CopyDirectory(source, destination);

                    MessageBox.Show("Folder copied");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CopyDirectory(string source, string dest)
        {
            Directory.CreateDirectory(dest);

            foreach (string file in Directory.GetFiles(source))
            {
                string name = Path.GetFileName(file);

                File.Copy(file,
                    Path.Combine(dest, name), true);
            }

            foreach (string folder in Directory.GetDirectories(source))
            {
                string name = Path.GetFileName(folder);

                CopyDirectory(folder,
                    Path.Combine(dest, name));
            }
        }

        private void moveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string source =
                    treeViewFolders.SelectedNode.Tag.ToString();

                FolderBrowserDialog fbd =
                    new FolderBrowserDialog();

                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    string destination =
                        Path.Combine(
                            fbd.SelectedPath,
                            Path.GetFileName(source));

                    Directory.Move(source, destination);

                    MessageBox.Show("Folder moved");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void createToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                string path =
                    treeViewFolders.SelectedNode.Tag.ToString();

                string file =
                    Path.Combine(path, txtNewName.Text);

                File.Create(file).Close();

                MessageBox.Show("File created");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxFiles.SelectedItem == null)
                    return;

                string file =
                    listBoxFiles.SelectedItem.ToString();

                File.Delete(file);

                MessageBox.Show("File deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxFiles.SelectedItem == null)
                    return;

                string source =
                    listBoxFiles.SelectedItem.ToString();

                FolderBrowserDialog fbd =
                    new FolderBrowserDialog();

                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    string destination =
                        Path.Combine(
                            fbd.SelectedPath,
                            Path.GetFileName(source));

                    File.Copy(source, destination, true);

                    MessageBox.Show("File copied");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void moveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxFiles.SelectedItem == null)
                    return;

                string source =
                    listBoxFiles.SelectedItem.ToString();

                FolderBrowserDialog fbd =
                    new FolderBrowserDialog();

                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    string destination =
                        Path.Combine(
                            fbd.SelectedPath,
                            Path.GetFileName(source));

                    File.Move(source, destination);

                    MessageBox.Show("File moved");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void changeAttributesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxFiles.SelectedItem == null)
                {
                    MessageBox.Show("Select a file first");
                    return;
                }

                string file =
                    listBoxFiles.SelectedItem.ToString();

                FileAttributes attr =
                    File.GetAttributes(file);

                File.SetAttributes(file,
                    attr | FileAttributes.Hidden);

                MessageBox.Show("Hidden attribute added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string file =
                    listBoxFiles.SelectedItem.ToString();

                using (FileStream fs =
                    new FileStream(file, FileMode.Create,
                    FileAccess.Write, FileShare.None))
                {
                    using (StreamWriter writer =
                        new StreamWriter(fs))
                    {
                        writer.Write(richTextBoxInfo.Text);
                    }
                }

                MessageBox.Show("Saved successfully");
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("No access to file. Run as Admin.");
            }
            catch (IOException)
            {
                MessageBox.Show("File is being used by another process.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void zIPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string file =
                    listBoxFiles.SelectedItem.ToString();

                string zip =
                    file + ".zip";

                using (ZipArchive archive =
                    ZipFile.Open(zip, ZipArchiveMode.Create))
                {
                    archive.CreateEntryFromFile(
                        file,
                        Path.GetFileName(file));
                }

                MessageBox.Show("Archived");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void uNZIPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string zip =
                    listBoxFiles.SelectedItem.ToString();

                string folder =
                    Path.Combine(
                        Path.GetDirectoryName(zip),
                        "Extracted");

                ZipFile.ExtractToDirectory(zip, folder);

                MessageBox.Show("Extracted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
