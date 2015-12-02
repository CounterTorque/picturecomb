namespace PictureComb
{
    partial class FormMain
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
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.splitContainerResults = new System.Windows.Forms.SplitContainer();
            this.groupBoxMain = new System.Windows.Forms.GroupBox();
            this.checkedListBoxSearch = new System.Windows.Forms.CheckedListBox();
            this.radioButtonFile = new System.Windows.Forms.RadioButton();
            this.radioButtonImage = new System.Windows.Forms.RadioButton();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.labelFound = new System.Windows.Forms.Label();
            this.groupBoxFiles = new System.Windows.Forms.GroupBox();
            this.progressBarSearch = new System.Windows.Forms.ProgressBar();
            this.groupBoxResults = new System.Windows.Forms.GroupBox();
            this.treeViewResults = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerResults)).BeginInit();
            this.splitContainerResults.SuspendLayout();
            this.groupBoxMain.SuspendLayout();
            this.groupBoxInfo.SuspendLayout();
            this.groupBoxFiles.SuspendLayout();
            this.groupBoxResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.groupBoxResults);
            this.splitContainerMain.Panel1.Controls.Add(this.groupBoxInfo);
            this.splitContainerMain.Panel1.Controls.Add(this.groupBoxMain);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.splitContainerResults);
            this.splitContainerMain.Size = new System.Drawing.Size(784, 561);
            this.splitContainerMain.SplitterDistance = 261;
            this.splitContainerMain.TabIndex = 0;
            // 
            // splitContainerResults
            // 
            this.splitContainerResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerResults.IsSplitterFixed = true;
            this.splitContainerResults.Location = new System.Drawing.Point(0, 0);
            this.splitContainerResults.Name = "splitContainerResults";
            this.splitContainerResults.Size = new System.Drawing.Size(784, 296);
            this.splitContainerResults.SplitterDistance = 392;
            this.splitContainerResults.TabIndex = 0;
            // 
            // groupBoxMain
            // 
            this.groupBoxMain.Controls.Add(this.radioButtonImage);
            this.groupBoxMain.Controls.Add(this.radioButtonFile);
            this.groupBoxMain.Controls.Add(this.checkedListBoxSearch);
            this.groupBoxMain.Location = new System.Drawing.Point(12, 12);
            this.groupBoxMain.Name = "groupBoxMain";
            this.groupBoxMain.Size = new System.Drawing.Size(260, 235);
            this.groupBoxMain.TabIndex = 0;
            this.groupBoxMain.TabStop = false;
            this.groupBoxMain.Text = "Search";
            // 
            // checkedListBoxSearch
            // 
            this.checkedListBoxSearch.FormattingEnabled = true;
            this.checkedListBoxSearch.Location = new System.Drawing.Point(6, 19);
            this.checkedListBoxSearch.Name = "checkedListBoxSearch";
            this.checkedListBoxSearch.Size = new System.Drawing.Size(248, 184);
            this.checkedListBoxSearch.TabIndex = 0;
            // 
            // radioButtonFile
            // 
            this.radioButtonFile.AutoSize = true;
            this.radioButtonFile.Checked = true;
            this.radioButtonFile.Location = new System.Drawing.Point(6, 209);
            this.radioButtonFile.Name = "radioButtonFile";
            this.radioButtonFile.Size = new System.Drawing.Size(77, 17);
            this.radioButtonFile.TabIndex = 1;
            this.radioButtonFile.TabStop = true;
            this.radioButtonFile.Text = "File Names";
            this.radioButtonFile.UseVisualStyleBackColor = true;
            // 
            // radioButtonImage
            // 
            this.radioButtonImage.AutoSize = true;
            this.radioButtonImage.Location = new System.Drawing.Point(89, 212);
            this.radioButtonImage.Name = "radioButtonImage";
            this.radioButtonImage.Size = new System.Drawing.Size(143, 17);
            this.radioButtonImage.TabIndex = 2;
            this.radioButtonImage.Text = "File Names and Contents";
            this.radioButtonImage.UseVisualStyleBackColor = true;
            // 
            // buttonExecute
            // 
            this.buttonExecute.Location = new System.Drawing.Point(6, 19);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(101, 23);
            this.buttonExecute.TabIndex = 1;
            this.buttonExecute.Text = "Execute";
            this.buttonExecute.UseVisualStyleBackColor = true;
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.progressBarSearch);
            this.groupBoxInfo.Controls.Add(this.groupBoxFiles);
            this.groupBoxInfo.Controls.Add(this.buttonExecute);
            this.groupBoxInfo.Location = new System.Drawing.Point(279, 13);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(113, 234);
            this.groupBoxInfo.TabIndex = 2;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Info";
            // 
            // labelFound
            // 
            this.labelFound.AutoSize = true;
            this.labelFound.Location = new System.Drawing.Point(6, 16);
            this.labelFound.Name = "labelFound";
            this.labelFound.Size = new System.Drawing.Size(30, 13);
            this.labelFound.TabIndex = 2;
            this.labelFound.Text = "0 / 0";
            // 
            // groupBoxFiles
            // 
            this.groupBoxFiles.Controls.Add(this.labelFound);
            this.groupBoxFiles.Location = new System.Drawing.Point(6, 49);
            this.groupBoxFiles.Name = "groupBoxFiles";
            this.groupBoxFiles.Size = new System.Drawing.Size(101, 36);
            this.groupBoxFiles.TabIndex = 2;
            this.groupBoxFiles.TabStop = false;
            this.groupBoxFiles.Text = "Files";
            // 
            // progressBarSearch
            // 
            this.progressBarSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBarSearch.Location = new System.Drawing.Point(3, 208);
            this.progressBarSearch.Name = "progressBarSearch";
            this.progressBarSearch.Size = new System.Drawing.Size(107, 23);
            this.progressBarSearch.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBarSearch.TabIndex = 3;
            // 
            // groupBoxResults
            // 
            this.groupBoxResults.Controls.Add(this.treeViewResults);
            this.groupBoxResults.Location = new System.Drawing.Point(398, 13);
            this.groupBoxResults.Name = "groupBoxResults";
            this.groupBoxResults.Size = new System.Drawing.Size(374, 234);
            this.groupBoxResults.TabIndex = 3;
            this.groupBoxResults.TabStop = false;
            this.groupBoxResults.Text = "Results";
            // 
            // treeViewResults
            // 
            this.treeViewResults.Location = new System.Drawing.Point(6, 18);
            this.treeViewResults.Name = "treeViewResults";
            this.treeViewResults.PathSeparator = "|";
            this.treeViewResults.Size = new System.Drawing.Size(362, 184);
            this.treeViewResults.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.splitContainerMain);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "FormMain";
            this.Text = "Picture Comb";
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerResults)).EndInit();
            this.splitContainerResults.ResumeLayout(false);
            this.groupBoxMain.ResumeLayout(false);
            this.groupBoxMain.PerformLayout();
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxFiles.ResumeLayout(false);
            this.groupBoxFiles.PerformLayout();
            this.groupBoxResults.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.SplitContainer splitContainerResults;
        private System.Windows.Forms.GroupBox groupBoxMain;
        private System.Windows.Forms.RadioButton radioButtonImage;
        private System.Windows.Forms.RadioButton radioButtonFile;
        private System.Windows.Forms.CheckedListBox checkedListBoxSearch;
        private System.Windows.Forms.GroupBox groupBoxResults;
        private System.Windows.Forms.TreeView treeViewResults;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.ProgressBar progressBarSearch;
        private System.Windows.Forms.GroupBox groupBoxFiles;
        private System.Windows.Forms.Label labelFound;
        private System.Windows.Forms.Button buttonExecute;
    }
}

