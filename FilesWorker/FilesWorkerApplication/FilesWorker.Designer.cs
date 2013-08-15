namespace FilesWorkerApplication
{
    partial class FilesWorker
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilesWorker));
            this.mAddButt = new System.Windows.Forms.Button();
            this.mImages = new System.Windows.Forms.ImageList(this.components);
            this.mFileListLabel = new System.Windows.Forms.Label();
            this.mOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mNumericTypeLabel = new System.Windows.Forms.Label();
            this.mNumericType = new System.Windows.Forms.ComboBox();
            this.mPrefixLabel = new System.Windows.Forms.Label();
            this.mPrefix = new System.Windows.Forms.TextBox();
            this.mSufixLabel = new System.Windows.Forms.Label();
            this.mSufix = new System.Windows.Forms.TextBox();
            this.mPreviewLabel = new System.Windows.Forms.Label();
            this.mPreview = new System.Windows.Forms.Label();
            this.mRename = new System.Windows.Forms.Button();
            this.mRemove = new System.Windows.Forms.Button();
            this.mFileList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // mAddButt
            // 
            this.mAddButt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mAddButt.ImageIndex = 0;
            this.mAddButt.ImageList = this.mImages;
            this.mAddButt.Location = new System.Drawing.Point(231, 38);
            this.mAddButt.Name = "mAddButt";
            this.mAddButt.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.mAddButt.Size = new System.Drawing.Size(94, 25);
            this.mAddButt.TabIndex = 1;
            this.mAddButt.Text = "Přidat";
            this.mAddButt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mAddButt.UseVisualStyleBackColor = true;
            this.mAddButt.Click += new System.EventHandler(this.mAddButt_Click);
            // 
            // mImages
            // 
            this.mImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("mImages.ImageStream")));
            this.mImages.TransparentColor = System.Drawing.Color.Transparent;
            this.mImages.Images.SetKeyName(0, "add.ico");
            this.mImages.Images.SetKeyName(1, "remove.ico");
            this.mImages.Images.SetKeyName(2, "rename.png");
            // 
            // mFileListLabel
            // 
            this.mFileListLabel.AutoSize = true;
            this.mFileListLabel.Location = new System.Drawing.Point(9, 22);
            this.mFileListLabel.Name = "mFileListLabel";
            this.mFileListLabel.Size = new System.Drawing.Size(88, 13);
            this.mFileListLabel.TabIndex = 2;
            this.mFileListLabel.Text = "Načtené soubory";
            // 
            // mOpenFileDialog
            // 
            this.mOpenFileDialog.FileName = "mOpenFile";
            this.mOpenFileDialog.Multiselect = true;
            this.mOpenFileDialog.Title = "¨Přidat soubory";
            // 
            // mNumericTypeLabel
            // 
            this.mNumericTypeLabel.AutoSize = true;
            this.mNumericTypeLabel.Location = new System.Drawing.Point(13, 289);
            this.mNumericTypeLabel.Name = "mNumericTypeLabel";
            this.mNumericTypeLabel.Size = new System.Drawing.Size(73, 13);
            this.mNumericTypeLabel.TabIndex = 3;
            this.mNumericTypeLabel.Text = "Typ číslování";
            // 
            // mNumericType
            // 
            this.mNumericType.AutoCompleteCustomSource.AddRange(new string[] {
            "1, 2, 3, ..."});
            this.mNumericType.DropDownHeight = 60;
            this.mNumericType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mNumericType.IntegralHeight = false;
            this.mNumericType.ItemHeight = 13;
            this.mNumericType.Items.AddRange(new object[] {
            "1, 2, 3, ..."});
            this.mNumericType.Location = new System.Drawing.Point(16, 306);
            this.mNumericType.MaxDropDownItems = 5;
            this.mNumericType.Name = "mNumericType";
            this.mNumericType.Size = new System.Drawing.Size(120, 21);
            this.mNumericType.TabIndex = 4;
            this.mNumericType.ValueMemberChanged += new System.EventHandler(this.mFormat_ValueMemberChanged);
            // 
            // mPrefixLabel
            // 
            this.mPrefixLabel.AutoSize = true;
            this.mPrefixLabel.Location = new System.Drawing.Point(139, 289);
            this.mPrefixLabel.Name = "mPrefixLabel";
            this.mPrefixLabel.Size = new System.Drawing.Size(33, 13);
            this.mPrefixLabel.TabIndex = 5;
            this.mPrefixLabel.Text = "Prefix";
            // 
            // mPrefix
            // 
            this.mPrefix.Location = new System.Drawing.Point(142, 307);
            this.mPrefix.MaxLength = 50;
            this.mPrefix.Name = "mPrefix";
            this.mPrefix.Size = new System.Drawing.Size(100, 20);
            this.mPrefix.TabIndex = 6;
            this.mPrefix.TextChanged += new System.EventHandler(this.mFormat_ValueMemberChanged);
            // 
            // mSufixLabel
            // 
            this.mSufixLabel.AutoSize = true;
            this.mSufixLabel.Location = new System.Drawing.Point(245, 291);
            this.mSufixLabel.Name = "mSufixLabel";
            this.mSufixLabel.Size = new System.Drawing.Size(30, 13);
            this.mSufixLabel.TabIndex = 7;
            this.mSufixLabel.Text = "Sufix";
            // 
            // mSufix
            // 
            this.mSufix.Location = new System.Drawing.Point(248, 307);
            this.mSufix.MaxLength = 50;
            this.mSufix.Name = "mSufix";
            this.mSufix.Size = new System.Drawing.Size(100, 20);
            this.mSufix.TabIndex = 8;
            this.mSufix.TextChanged += new System.EventHandler(this.mFormat_ValueMemberChanged);
            // 
            // mPreviewLabel
            // 
            this.mPreviewLabel.AutoSize = true;
            this.mPreviewLabel.Location = new System.Drawing.Point(16, 334);
            this.mPreviewLabel.Name = "mPreviewLabel";
            this.mPreviewLabel.Size = new System.Drawing.Size(41, 13);
            this.mPreviewLabel.TabIndex = 9;
            this.mPreviewLabel.Text = "Náhled";
            // 
            // mPreview
            // 
            this.mPreview.Location = new System.Drawing.Point(61, 334);
            this.mPreview.Name = "mPreview";
            this.mPreview.Size = new System.Drawing.Size(286, 13);
            this.mPreview.TabIndex = 10;
            // 
            // mRename
            // 
            this.mRename.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.mRename.ImageIndex = 2;
            this.mRename.ImageList = this.mImages;
            this.mRename.Location = new System.Drawing.Point(232, 100);
            this.mRename.Name = "mRename";
            this.mRename.Size = new System.Drawing.Size(93, 25);
            this.mRename.TabIndex = 11;
            this.mRename.Text = "Přejmenovat";
            this.mRename.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mRename.UseVisualStyleBackColor = true;
            this.mRename.Click += new System.EventHandler(this.mRename_Click);
            // 
            // mRemove
            // 
            this.mRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mRemove.ImageIndex = 1;
            this.mRemove.ImageList = this.mImages;
            this.mRemove.Location = new System.Drawing.Point(232, 69);
            this.mRemove.Name = "mRemove";
            this.mRemove.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.mRemove.Size = new System.Drawing.Size(93, 25);
            this.mRemove.TabIndex = 14;
            this.mRemove.Text = "Odstranit";
            this.mRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mRemove.UseVisualStyleBackColor = true;
            this.mRemove.Click += new System.EventHandler(this.mRemove_Click);
            // 
            // mFileList
            // 
            this.mFileList.AllowDrop = true;
            this.mFileList.FormattingEnabled = true;
            this.mFileList.Location = new System.Drawing.Point(12, 38);
            this.mFileList.Name = "mFileList";
            this.mFileList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.mFileList.Size = new System.Drawing.Size(213, 238);
            this.mFileList.TabIndex = 15;
            this.mFileList.ValueMemberChanged += new System.EventHandler(this.mFormat_ValueMemberChanged);
            this.mFileList.DragDrop += new System.Windows.Forms.DragEventHandler(this.mFileList_DragDrop);
            this.mFileList.DragEnter += new System.Windows.Forms.DragEventHandler(this.mFileList_DragEnter);
            // 
            // FilesWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 364);
            this.Controls.Add(this.mFileList);
            this.Controls.Add(this.mRemove);
            this.Controls.Add(this.mRename);
            this.Controls.Add(this.mPreview);
            this.Controls.Add(this.mPreviewLabel);
            this.Controls.Add(this.mSufix);
            this.Controls.Add(this.mSufixLabel);
            this.Controls.Add(this.mPrefix);
            this.Controls.Add(this.mPrefixLabel);
            this.Controls.Add(this.mNumericType);
            this.Controls.Add(this.mNumericTypeLabel);
            this.Controls.Add(this.mFileListLabel);
            this.Controls.Add(this.mAddButt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FilesWorker";
            this.Text = "Files Worker";
            this.Load += new System.EventHandler(this.FilesWorker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mAddButt;
        private System.Windows.Forms.Label mFileListLabel;
        private System.Windows.Forms.OpenFileDialog mOpenFileDialog;
        private System.Windows.Forms.Label mNumericTypeLabel;
        private System.Windows.Forms.ComboBox mNumericType;
        private System.Windows.Forms.Label mPrefixLabel;
        private System.Windows.Forms.TextBox mPrefix;
        private System.Windows.Forms.Label mSufixLabel;
        private System.Windows.Forms.TextBox mSufix;
        private System.Windows.Forms.Label mPreviewLabel;
        private System.Windows.Forms.Label mPreview;
        private System.Windows.Forms.Button mRename;
        private System.Windows.Forms.Button mRemove;
        private System.Windows.Forms.ImageList mImages;
        private System.Windows.Forms.ListBox mFileList;
    }
}

