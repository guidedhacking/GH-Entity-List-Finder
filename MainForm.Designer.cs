using System;
using System.Windows.Forms;

namespace EntityListFinder {
	partial class MainForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.marginOffsetTextBox = new System.Windows.Forms.TextBox();
			this.addressesToFindTextBox = new System.Windows.Forms.TextBox();
			this.attachButton = new System.Windows.Forms.Button();
			this.processNameLabel = new System.Windows.Forms.Label();
			this.maxBytesBetweenAddressesLabel = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.loadAddressesButton = new System.Windows.Forms.Button();
			this.searchButton = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.possibleEntityListTextBox = new System.Windows.Forms.TextBox();
			this.saveButton = new System.Windows.Forms.Button();
			this.searchPanel = new System.Windows.Forms.Panel();
			this.validateButton = new System.Windows.Forms.Button();
			this.processesList = new System.Windows.Forms.ComboBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.processesListToolTip = new System.Windows.Forms.ToolTip(this.components);
			this.maxBytesToolTip = new System.Windows.Forms.ToolTip(this.components);
			this.validateToolTip = new System.Windows.Forms.ToolTip(this.components);
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.maxBytesHelp = new System.Windows.Forms.PictureBox();
			this.processImage = new System.Windows.Forms.PictureBox();
			this.validateButtonPictureBox = new System.Windows.Forms.PictureBox();
			this.goToWebsiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.searchPanel.SuspendLayout();
			this.panel1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.maxBytesHelp)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.processImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.validateButtonPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// marginOffsetTextBox
			// 
			this.marginOffsetTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.marginOffsetTextBox.Location = new System.Drawing.Point(12, 124);
			this.marginOffsetTextBox.MaxLength = 8;
			this.marginOffsetTextBox.Name = "marginOffsetTextBox";
			this.marginOffsetTextBox.Size = new System.Drawing.Size(191, 20);
			this.marginOffsetTextBox.TabIndex = 0;
			this.marginOffsetTextBox.Text = "32";
			this.marginOffsetTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// addressesToFindTextBox
			// 
			this.addressesToFindTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.addressesToFindTextBox.Location = new System.Drawing.Point(12, 166);
			this.addressesToFindTextBox.Multiline = true;
			this.addressesToFindTextBox.Name = "addressesToFindTextBox";
			this.addressesToFindTextBox.Size = new System.Drawing.Size(191, 213);
			this.addressesToFindTextBox.TabIndex = 1;
			// 
			// attachButton
			// 
			this.attachButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.attachButton.Location = new System.Drawing.Point(12, 59);
			this.attachButton.Name = "attachButton";
			this.attachButton.Size = new System.Drawing.Size(191, 23);
			this.attachButton.TabIndex = 2;
			this.attachButton.Text = "Attach";
			this.attachButton.UseVisualStyleBackColor = true;
			this.attachButton.Click += new System.EventHandler(this.AttachButton_Click);
			// 
			// processNameLabel
			// 
			this.processNameLabel.AutoSize = true;
			this.processNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.processNameLabel.ForeColor = System.Drawing.Color.Green;
			this.processNameLabel.Location = new System.Drawing.Point(9, 83);
			this.processNameLabel.Name = "processNameLabel";
			this.processNameLabel.Size = new System.Drawing.Size(194, 16);
			this.processNameLabel.TabIndex = 3;
			this.processNameLabel.Text = "ProcessName Placeholder";
			// 
			// maxBytesBetweenAddressesLabel
			// 
			this.maxBytesBetweenAddressesLabel.AutoSize = true;
			this.maxBytesBetweenAddressesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.maxBytesBetweenAddressesLabel.Location = new System.Drawing.Point(9, 105);
			this.maxBytesBetweenAddressesLabel.Name = "maxBytesBetweenAddressesLabel";
			this.maxBytesBetweenAddressesLabel.Size = new System.Drawing.Size(175, 15);
			this.maxBytesBetweenAddressesLabel.TabIndex = 4;
			this.maxBytesBetweenAddressesLabel.Text = "Max bytes between addresses:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 147);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(196, 16);
			this.label2.TabIndex = 5;
			this.label2.Text = "Addresses to find (one per line):";
			// 
			// label3
			// 
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label3.Location = new System.Drawing.Point(214, 29);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(3, 408);
			this.label3.TabIndex = 8;
			// 
			// loadAddressesButton
			// 
			this.loadAddressesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loadAddressesButton.Location = new System.Drawing.Point(12, 385);
			this.loadAddressesButton.Name = "loadAddressesButton";
			this.loadAddressesButton.Size = new System.Drawing.Size(191, 23);
			this.loadAddressesButton.TabIndex = 4;
			this.loadAddressesButton.Text = "Load addresses from file";
			this.loadAddressesButton.UseVisualStyleBackColor = true;
			this.loadAddressesButton.Click += new System.EventHandler(this.LoadAddressesButton_Click);
			// 
			// searchButton
			// 
			this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.searchButton.Location = new System.Drawing.Point(12, 414);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(191, 23);
			this.searchButton.TabIndex = 5;
			this.searchButton.Text = "Search for entity list";
			this.searchButton.UseVisualStyleBackColor = true;
			this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(39, 8);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(182, 32);
			this.label5.TabIndex = 13;
			this.label5.Text = "Possible entity list or address\r\nclose enough to an entity list:";
			// 
			// possibleEntityListTextBox
			// 
			this.possibleEntityListTextBox.Location = new System.Drawing.Point(3, 48);
			this.possibleEntityListTextBox.Multiline = true;
			this.possibleEntityListTextBox.Name = "possibleEntityListTextBox";
			this.possibleEntityListTextBox.ReadOnly = true;
			this.possibleEntityListTextBox.Size = new System.Drawing.Size(257, 302);
			this.possibleEntityListTextBox.TabIndex = 14;
			// 
			// saveButton
			// 
			this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.saveButton.Location = new System.Drawing.Point(3, 381);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(257, 23);
			this.saveButton.TabIndex = 7;
			this.saveButton.Text = "Save addresses to Desktop";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// searchPanel
			// 
			this.searchPanel.Controls.Add(this.validateButtonPictureBox);
			this.searchPanel.Controls.Add(this.validateButton);
			this.searchPanel.Controls.Add(this.possibleEntityListTextBox);
			this.searchPanel.Controls.Add(this.saveButton);
			this.searchPanel.Controls.Add(this.label5);
			this.searchPanel.Location = new System.Drawing.Point(223, 29);
			this.searchPanel.Name = "searchPanel";
			this.searchPanel.Size = new System.Drawing.Size(263, 408);
			this.searchPanel.TabIndex = 17;
			// 
			// validateButton
			// 
			this.validateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.validateButton.Location = new System.Drawing.Point(3, 356);
			this.validateButton.Name = "validateButton";
			this.validateButton.Size = new System.Drawing.Size(235, 23);
			this.validateButton.TabIndex = 17;
			this.validateButton.Text = "Validate";
			this.validateButton.UseVisualStyleBackColor = true;
			this.validateButton.Click += new System.EventHandler(this.ValidateButton_Click);
			// 
			// processesList
			// 
			this.processesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.processesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.processesList.FormattingEnabled = true;
			this.processesList.Location = new System.Drawing.Point(33, 3);
			this.processesList.MaxDropDownItems = 50;
			this.processesList.Name = "processesList";
			this.processesList.Size = new System.Drawing.Size(155, 21);
			this.processesList.Sorted = true;
			this.processesList.TabIndex = 19;
			this.processesList.DropDown += new System.EventHandler(this.ProcessesList_DropDown);
			this.processesList.SelectedIndexChanged += new System.EventHandler(this.ProcessesList_SelectedIndexChanged);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.processImage);
			this.panel1.Controls.Add(this.processesList);
			this.panel1.Location = new System.Drawing.Point(12, 29);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(191, 27);
			this.panel1.TabIndex = 20;
			// 
			// processesListToolTip
			// 
			this.processesListToolTip.AutomaticDelay = 100;
			this.processesListToolTip.AutoPopDelay = 32766;
			this.processesListToolTip.InitialDelay = 100;
			this.processesListToolTip.ReshowDelay = 20;
			// 
			// maxBytesToolTip
			// 
			this.maxBytesToolTip.AutomaticDelay = 100;
			this.maxBytesToolTip.AutoPopDelay = 32766;
			this.maxBytesToolTip.InitialDelay = 100;
			this.maxBytesToolTip.ReshowDelay = 20;
			this.maxBytesToolTip.StripAmpersands = true;
			this.maxBytesToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.maxBytesToolTip.ToolTipTitle = "Information: This number is in HEX.";
			// 
			// validateToolTip
			// 
			this.validateToolTip.AutomaticDelay = 100;
			this.validateToolTip.AutoPopDelay = 32766;
			this.validateToolTip.InitialDelay = 100;
			this.validateToolTip.ReshowDelay = 20;
			this.validateToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.validateToolTip.ToolTipTitle = "Information";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.menuStrip1.Size = new System.Drawing.Size(497, 24);
			this.menuStrip1.TabIndex = 22;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goToWebsiteToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// maxBytesHelp
			// 
			this.maxBytesHelp.Image = global::EntityListFinder.Properties.Resources.Button_Help_icon;
			this.maxBytesHelp.Location = new System.Drawing.Point(183, 105);
			this.maxBytesHelp.Name = "maxBytesHelp";
			this.maxBytesHelp.Size = new System.Drawing.Size(16, 16);
			this.maxBytesHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.maxBytesHelp.TabIndex = 21;
			this.maxBytesHelp.TabStop = false;
			// 
			// processImage
			// 
			this.processImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.processImage.Image = ((System.Drawing.Image)(resources.GetObject("processImage.Image")));
			this.processImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("processImage.InitialImage")));
			this.processImage.Location = new System.Drawing.Point(7, 4);
			this.processImage.Name = "processImage";
			this.processImage.Size = new System.Drawing.Size(18, 18);
			this.processImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.processImage.TabIndex = 20;
			this.processImage.TabStop = false;
			// 
			// validateButtonPictureBox
			// 
			this.validateButtonPictureBox.Image = global::EntityListFinder.Properties.Resources.Button_Help_icon;
			this.validateButtonPictureBox.Location = new System.Drawing.Point(241, 360);
			this.validateButtonPictureBox.Name = "validateButtonPictureBox";
			this.validateButtonPictureBox.Size = new System.Drawing.Size(16, 16);
			this.validateButtonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.validateButtonPictureBox.TabIndex = 22;
			this.validateButtonPictureBox.TabStop = false;
			// 
			// goToWebsiteToolStripMenuItem
			// 
			this.goToWebsiteToolStripMenuItem.Image = global::EntityListFinder.Properties.Resources.earth_globe_icon_globe_png;
			this.goToWebsiteToolStripMenuItem.Name = "goToWebsiteToolStripMenuItem";
			this.goToWebsiteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.goToWebsiteToolStripMenuItem.Text = "Go to website";
			this.goToWebsiteToolStripMenuItem.Click += new System.EventHandler(this.GoToWebsiteToolStripMenuItem_Click);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(497, 446);
			this.Controls.Add(this.maxBytesHelp);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.searchPanel);
			this.Controls.Add(this.searchButton);
			this.Controls.Add(this.loadAddressesButton);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.maxBytesBetweenAddressesLabel);
			this.Controls.Add(this.processNameLabel);
			this.Controls.Add(this.attachButton);
			this.Controls.Add(this.addressesToFindTextBox);
			this.Controls.Add(this.marginOffsetTextBox);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "GH Entity List Finder v1.0";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.searchPanel.ResumeLayout(false);
			this.searchPanel.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.maxBytesHelp)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.processImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.validateButtonPictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.TextBox marginOffsetTextBox;
		public System.Windows.Forms.TextBox addressesToFindTextBox;
		public System.Windows.Forms.Button attachButton;
		public System.Windows.Forms.Label processNameLabel;
		private System.Windows.Forms.Label maxBytesBetweenAddressesLabel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		public System.Windows.Forms.Button loadAddressesButton;
		public System.Windows.Forms.Button searchButton;
		private System.Windows.Forms.Label label5;
		public System.Windows.Forms.TextBox possibleEntityListTextBox;
		public System.Windows.Forms.Button saveButton;
		public System.Windows.Forms.Panel searchPanel;
		public System.Windows.Forms.Button validateButton;
		private System.Windows.Forms.ComboBox processesList;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox processImage;
		private System.Windows.Forms.ToolTip processesListToolTip;
		private System.Windows.Forms.ToolTip maxBytesToolTip;
		private System.Windows.Forms.PictureBox maxBytesHelp;
		private System.Windows.Forms.PictureBox validateButtonPictureBox;
		private System.Windows.Forms.ToolTip validateToolTip;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem goToWebsiteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
	}
}

