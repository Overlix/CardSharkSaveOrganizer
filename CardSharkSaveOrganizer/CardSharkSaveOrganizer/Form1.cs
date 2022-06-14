using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardSharkSaveOrganizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LocationButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Card Shark Save|*.slot";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtLocation.Text = dlg.FileName;
                Refresh();
            }
        }

        //Bouton browse du profile
        private void ProfileButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtProfile.Text = dlg.SelectedPath;
                UpdateListView();
                Refresh();
            }
        }

        void UpdateListView()
        {
            listFiles.Items.Clear();
            string[] files = Directory.GetFiles(txtProfile.Text);
            //string[] dirs = Directory.GetDirectories(dlg.SelectedPath);

            foreach (string file in files)
            {
                listFiles.Items.Add(Path.GetFileName(file));
            }
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            try
            {
                string[] files = Directory.GetFiles(txtProfile.Text);
                string copyFileName = txtProfile.Text + "\\" + Path.GetFileName(txtLocation.Text);
                foreach (string file in files)
                {
                    if (file == copyFileName)
                    {
                        MessageBox.Show("File already exist, please rename it to import a new savestate");
                        return;
                    }
                }
                File.Copy(txtLocation.Text, copyFileName, false);
                UpdateListView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            try
            {
                string loadFileName = txtProfile.Text + "\\" + listFiles.GetItemText(listFiles.SelectedItem);
                File.Copy(loadFileName, txtLocation.Text, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ReplaceButton_Click(object sender, EventArgs e)
        {
            try
            {
                string copyFileName = txtProfile.Text + "\\" + listFiles.GetItemText(listFiles.SelectedItem);
                File.Copy(txtLocation.Text, copyFileName, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                string deleteFileName = txtProfile.Text + "\\" + listFiles.GetItemText(listFiles.SelectedItem);
                File.Delete(deleteFileName);
                UpdateListView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void RenameButton_Click(object sender, EventArgs e)
        {
            Form2 newform = new Form2();
            newform.NewName = listFiles.GetItemText(listFiles.SelectedItem);
            if (newform.ShowDialog() == DialogResult.OK)
            {
                string oldFileName = txtProfile.Text + "\\" + listFiles.GetItemText(listFiles.SelectedItem);
                string newFileName = txtProfile.Text + "\\" + newform.NewName;
                System.IO.File.Move(oldFileName, newFileName);
                UpdateListView();
            }
        }

        public new void Refresh()
        {
            base.Refresh();

            ImportButton.Enabled = false;
            LoadButton.Enabled = false;
            ReplaceButton.Enabled = false;
            DeleteButton.Enabled = false;
            RenameButton.Enabled = false;

            if (txtLocation.Text != null && txtProfile.Text != null)
            {
                ImportButton.Enabled = true;
                LoadButton.Enabled = true;
                if (listFiles.SelectedItem != null)
                {
                    ReplaceButton.Enabled = true;
                }

            }

            if (listFiles.SelectedItem != null)
            {
                DeleteButton.Enabled = true;
                RenameButton.Enabled = true;
            }
        }

        private void listFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
