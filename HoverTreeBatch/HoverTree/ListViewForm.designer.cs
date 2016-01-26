namespace HoverTree.Batch
{
    partial class ListViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListViewForm));
            this.listView_hoverTree = new System.Windows.Forms.ListView();
            this.imageList_hvt = new System.Windows.Forms.ImageList(this.components);
            this.folderBrowserDialog_hvt = new System.Windows.Forms.FolderBrowserDialog();
            this.button_ok = new System.Windows.Forms.Button();
            this.button_rename = new System.Windows.Forms.Button();
            this.textBox_text = new System.Windows.Forms.TextBox();
            this.label_prefix = new System.Windows.Forms.Label();
            this.comboBox_operationType = new System.Windows.Forms.ComboBox();
            this.label_operationType = new System.Windows.Forms.Label();
            this.textBox_folder = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listView_hoverTree
            // 
            this.listView_hoverTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_hoverTree.LargeImageList = this.imageList_hvt;
            this.listView_hoverTree.Location = new System.Drawing.Point(12, 39);
            this.listView_hoverTree.Name = "listView_hoverTree";
            this.listView_hoverTree.Size = new System.Drawing.Size(604, 210);
            this.listView_hoverTree.SmallImageList = this.imageList_hvt;
            this.listView_hoverTree.StateImageList = this.imageList_hvt;
            this.listView_hoverTree.TabIndex = 0;
            this.listView_hoverTree.UseCompatibleStateImageBehavior = false;
            this.listView_hoverTree.View = System.Windows.Forms.View.Details;
            // 
            // imageList_hvt
            // 
            this.imageList_hvt.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_hvt.ImageStream")));
            this.imageList_hvt.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_hvt.Images.SetKeyName(0, "file.png");
            // 
            // button_ok
            // 
            this.button_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_ok.Location = new System.Drawing.Point(12, 260);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 23);
            this.button_ok.TabIndex = 1;
            this.button_ok.Text = "选择文件夹";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // button_rename
            // 
            this.button_rename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_rename.Location = new System.Drawing.Point(421, 257);
            this.button_rename.Name = "button_rename";
            this.button_rename.Size = new System.Drawing.Size(128, 23);
            this.button_rename.TabIndex = 2;
            this.button_rename.Text = "文件批量重命名";
            this.button_rename.UseVisualStyleBackColor = true;

            // 
            // textBox_text
            // 
            this.textBox_text.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_text.Location = new System.Drawing.Point(331, 259);
            this.textBox_text.Name = "textBox_text";
            this.textBox_text.Size = new System.Drawing.Size(84, 21);
            this.textBox_text.TabIndex = 3;
            this.textBox_text.Text = "HoverTree";
            // 
            // label_prefix
            // 
            this.label_prefix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_prefix.AutoSize = true;
            this.label_prefix.Location = new System.Drawing.Point(284, 265);
            this.label_prefix.Name = "label_prefix";
            this.label_prefix.Size = new System.Drawing.Size(41, 12);
            this.label_prefix.TabIndex = 4;
            this.label_prefix.Text = "文字：";
            // 
            // comboBox_operationType
            // 
            this.comboBox_operationType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox_operationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_operationType.FormattingEnabled = true;
            this.comboBox_operationType.Location = new System.Drawing.Point(143, 260);
            this.comboBox_operationType.Name = "comboBox_operationType";
            this.comboBox_operationType.Size = new System.Drawing.Size(121, 20);
            this.comboBox_operationType.TabIndex = 5;
            // 
            // label_operationType
            // 
            this.label_operationType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_operationType.AutoSize = true;
            this.label_operationType.Location = new System.Drawing.Point(96, 265);
            this.label_operationType.Name = "label_operationType";
            this.label_operationType.Size = new System.Drawing.Size(41, 12);
            this.label_operationType.TabIndex = 6;
            this.label_operationType.Text = "类型：";
            // 
            // textBox_folder
            // 
            this.textBox_folder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_folder.Location = new System.Drawing.Point(12, 12);
            this.textBox_folder.Name = "textBox_folder";
            this.textBox_folder.ReadOnly = true;
            this.textBox_folder.Size = new System.Drawing.Size(604, 21);
            this.textBox_folder.TabIndex = 7;
            // 
            // ListViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 290);
            this.Controls.Add(this.textBox_folder);
            this.Controls.Add(this.label_operationType);
            this.Controls.Add(this.comboBox_operationType);
            this.Controls.Add(this.label_prefix);
            this.Controls.Add(this.textBox_text);
            this.Controls.Add(this.button_rename);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.listView_hoverTree);
            this.Name = "ListViewForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "文件批量操作";
            this.ResumeLayout(false);
            this.PerformLayout();



        }

        #endregion

        private System.Windows.Forms.ListView listView_hoverTree;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_hvt;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.ImageList imageList_hvt;
        private System.Windows.Forms.Button button_rename;
        private System.Windows.Forms.TextBox textBox_text;
        private System.Windows.Forms.Label label_prefix;
        private System.Windows.Forms.ComboBox comboBox_operationType;
        private System.Windows.Forms.Label label_operationType;
        private System.Windows.Forms.TextBox textBox_folder;
    }
}