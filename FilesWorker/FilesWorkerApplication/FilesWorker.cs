using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Extensions;
using FilesManager;

namespace FilesWorkerApplication
{
    public partial class FilesWorker : Form
    {
        private readonly char[] cInvalidChars = Path.GetInvalidFileNameChars();

        public FilesWorker()
        {
            InitializeComponent();
        }

        private void FilesWorker_Load(object sender, EventArgs e)
        {
            mNumericType.SelectedIndex = 0;
        }

        //Při změně formátu pro výstupní přejmenování
        private void mFormat_ValueMemberChanged(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                var lTextBox = sender as TextBox;
                if (lTextBox.Text.IndexOfAny(cInvalidChars) >= 0)
                {
                    MessageBox.Show(
                        string.Format("Zadaná hodnota {0} (\"{1}\") obsahuje nepřípustné znaky pro pojmenování souboru)",
                        (lTextBox.Name == mPrefix.Name)?"Prefixu":"Sufixu",
                        lTextBox.Text)
                    );

                    mPreview.Text = "";

                    lTextBox.Focus();
                    lTextBox.SelectAll();
                }
            }

            try
            {
                var lSelectedFile = mFileList.SelectedItem as FileInfo;
                var lFileName = lSelectedFile.FormatFileName(mPrefix.Text, mSufix.Text, mFileList.SelectedIndex + 1, (int)Math.Truncate(Math.Log10(mFileList.Items.Count)) + 1);

                mPreview.Text = lFileName;
            }
            catch (Exception aExc)
            {
                mPreview.Text = "Nelze zobrazit";
            }
        }

        private void mAddButt_Click(object sender, EventArgs e)
        {
            if (mOpenFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var lSelectedFiles = mOpenFileDialog.FileNames;
                foreach (var lFile in lSelectedFiles)
                {
                    mFileList.Items.Add(new FileInfo(lFile));
                }
            }
        }

        private void mRename_Click(object sender, EventArgs e)
        {
            if (mFileList.Items.Count == 0)
                return;

            var lFiles = new List<FileInfo>();
            foreach (var lFile in mFileList.Items)
            {
                lFiles.Add((FileInfo)lFile);
            }

            try
            {
                Worker.RenameFiles(lFiles, mPrefix.Text, mSufix.Text);
                MessageBox.Show("Soubory byly úspěšn přejmenovány");
            }
            catch (Exception aExc)
            {
                MessageBox.Show(aExc.Message);
            }
        }

        private void mRemove_Click(object sender, EventArgs e)
        {
            while (mFileList.SelectedItems.Count > 0)
            {
                mFileList.Items.Remove(mFileList.SelectedItems[0]);
            }
        }

        private void mFileList_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void mFileList_DragDrop(object sender, DragEventArgs e)
        {
            string[] lFiles = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string lFile in lFiles)
            {
                if (File.Exists(lFile))
                    mFileList.Items.Add(new FileInfo(lFile));
                else if (Directory.Exists(lFile))
                {
                    var lItems = Directory.GetFiles(lFile);
                    foreach (var lItem in lItems)
                        if (File.Exists(lItem))
                            mFileList.Items.Add(new FileInfo(lItem));
                }
            }
        }
    }
}
