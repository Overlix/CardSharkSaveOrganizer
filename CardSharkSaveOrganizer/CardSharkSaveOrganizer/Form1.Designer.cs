
namespace CardSharkSaveOrganizer
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
            this.LocationButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtProfile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ProfileButton = new System.Windows.Forms.Button();
            this.listFiles = new System.Windows.Forms.ListBox();
            this.ImportButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.ReplaceButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.RenameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LocationButton
            // 
            this.LocationButton.Location = new System.Drawing.Point(134, 5);
            this.LocationButton.Name = "LocationButton";
            this.LocationButton.Size = new System.Drawing.Size(75, 23);
            this.LocationButton.TabIndex = 0;
            this.LocationButton.Text = "Browse";
            this.LocationButton.UseVisualStyleBackColor = true;
            this.LocationButton.Click += new System.EventHandler(this.LocationButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Location of Savefile :";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(12, 34);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.ReadOnly = true;
            this.txtLocation.Size = new System.Drawing.Size(395, 23);
            this.txtLocation.TabIndex = 2;
            // 
            // txtProfile
            // 
            this.txtProfile.Location = new System.Drawing.Point(12, 103);
            this.txtProfile.Name = "txtProfile";
            this.txtProfile.ReadOnly = true;
            this.txtProfile.Size = new System.Drawing.Size(395, 23);
            this.txtProfile.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Profile Directory :";
            // 
            // ProfileButton
            // 
            this.ProfileButton.Location = new System.Drawing.Point(134, 74);
            this.ProfileButton.Name = "ProfileButton";
            this.ProfileButton.Size = new System.Drawing.Size(75, 23);
            this.ProfileButton.TabIndex = 3;
            this.ProfileButton.Text = "Browse";
            this.ProfileButton.UseVisualStyleBackColor = true;
            this.ProfileButton.Click += new System.EventHandler(this.ProfileButton_Click);
            // 
            // listFiles
            // 
            this.listFiles.FormattingEnabled = true;
            this.listFiles.ItemHeight = 15;
            this.listFiles.Location = new System.Drawing.Point(12, 153);
            this.listFiles.Name = "listFiles";
            this.listFiles.Size = new System.Drawing.Size(395, 274);
            this.listFiles.TabIndex = 6;
            this.listFiles.SelectedIndexChanged += new System.EventHandler(this.listFiles_SelectedIndexChanged);
            // 
            // ImportButton
            // 
            this.ImportButton.Location = new System.Drawing.Point(413, 221);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(113, 23);
            this.ImportButton.TabIndex = 7;
            this.ImportButton.Text = "Import Savestate";
            this.ImportButton.UseVisualStyleBackColor = true;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Enabled = false;
            this.LoadButton.Location = new System.Drawing.Point(413, 250);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(113, 23);
            this.LoadButton.TabIndex = 8;
            this.LoadButton.Text = "Load Savestate";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // ReplaceButton
            // 
            this.ReplaceButton.Enabled = false;
            this.ReplaceButton.Location = new System.Drawing.Point(413, 279);
            this.ReplaceButton.Name = "ReplaceButton";
            this.ReplaceButton.Size = new System.Drawing.Size(113, 23);
            this.ReplaceButton.TabIndex = 9;
            this.ReplaceButton.Text = "Replace Savestate";
            this.ReplaceButton.UseVisualStyleBackColor = true;
            this.ReplaceButton.Click += new System.EventHandler(this.ReplaceButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Enabled = false;
            this.DeleteButton.Location = new System.Drawing.Point(413, 308);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(113, 23);
            this.DeleteButton.TabIndex = 10;
            this.DeleteButton.Text = "Delete Savestate";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // RenameButton
            // 
            this.RenameButton.Enabled = false;
            this.RenameButton.Location = new System.Drawing.Point(413, 337);
            this.RenameButton.Name = "RenameButton";
            this.RenameButton.Size = new System.Drawing.Size(113, 23);
            this.RenameButton.TabIndex = 11;
            this.RenameButton.Text = "Rename Savestate";
            this.RenameButton.UseVisualStyleBackColor = true;
            this.RenameButton.Click += new System.EventHandler(this.RenameButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 450);
            this.Controls.Add(this.RenameButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ReplaceButton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.ImportButton);
            this.Controls.Add(this.listFiles);
            this.Controls.Add(this.txtProfile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProfileButton);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LocationButton);
            this.Name = "Form1";
            this.Text = "Card Shark Save Organizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LocationButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtProfile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ProfileButton;
        private System.Windows.Forms.ListBox listFiles;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button ReplaceButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button RenameButton;
    }
}

