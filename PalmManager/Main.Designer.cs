namespace PalmManager
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.installbtn = new System.Windows.Forms.Button();
            this.addonlist = new System.Windows.Forms.CheckedListBox();
            this.sourcebtn = new System.Windows.Forms.Button();
            this.applist = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.customdir = new System.Windows.Forms.TextBox();
            this.currentdirused = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.setcustomdirbtn = new System.Windows.Forms.Button();
            this.viewbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.vertext = new System.Windows.Forms.Label();
            this.dirshow = new System.Windows.Forms.OpenFileDialog();
            this.diropen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // installbtn
            // 
            this.installbtn.Location = new System.Drawing.Point(563, 27);
            this.installbtn.Name = "installbtn";
            this.installbtn.Size = new System.Drawing.Size(130, 23);
            this.installbtn.TabIndex = 1;
            this.installbtn.Text = "Install Selected";
            this.installbtn.UseVisualStyleBackColor = true;
            this.installbtn.Click += new System.EventHandler(this.installbtn_Click);
            // 
            // addonlist
            // 
            this.addonlist.CheckOnClick = true;
            this.addonlist.FormattingEnabled = true;
            this.addonlist.Location = new System.Drawing.Point(12, 27);
            this.addonlist.Name = "addonlist";
            this.addonlist.ScrollAlwaysVisible = true;
            this.addonlist.Size = new System.Drawing.Size(430, 364);
            this.addonlist.TabIndex = 2;
            // 
            // sourcebtn
            // 
            this.sourcebtn.Location = new System.Drawing.Point(563, 56);
            this.sourcebtn.Name = "sourcebtn";
            this.sourcebtn.Size = new System.Drawing.Size(130, 23);
            this.sourcebtn.TabIndex = 3;
            this.sourcebtn.Text = "show source (broken)";
            this.sourcebtn.UseVisualStyleBackColor = true;
            this.sourcebtn.Click += new System.EventHandler(this.sourcebtn_Click);
            // 
            // applist
            // 
            this.applist.FormattingEnabled = true;
            this.applist.Location = new System.Drawing.Point(563, 85);
            this.applist.Name = "applist";
            this.applist.Size = new System.Drawing.Size(130, 21);
            this.applist.TabIndex = 4;
            this.applist.SelectedIndexChanged += new System.EventHandler(this.applist_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mods:";
            // 
            // customdir
            // 
            this.customdir.Location = new System.Drawing.Point(448, 170);
            this.customdir.Name = "customdir";
            this.customdir.Size = new System.Drawing.Size(310, 20);
            this.customdir.TabIndex = 6;
            // 
            // currentdirused
            // 
            this.currentdirused.Location = new System.Drawing.Point(12, 412);
            this.currentdirused.Name = "currentdirused";
            this.currentdirused.ReadOnly = true;
            this.currentdirused.Size = new System.Drawing.Size(430, 20);
            this.currentdirused.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Current Dir Used";
            // 
            // setcustomdirbtn
            // 
            this.setcustomdirbtn.Location = new System.Drawing.Point(563, 141);
            this.setcustomdirbtn.Name = "setcustomdirbtn";
            this.setcustomdirbtn.Size = new System.Drawing.Size(130, 23);
            this.setcustomdirbtn.TabIndex = 9;
            this.setcustomdirbtn.Text = "Set Custom Dir";
            this.setcustomdirbtn.UseVisualStyleBackColor = true;
            this.setcustomdirbtn.Click += new System.EventHandler(this.setcustomdirbtn_Click);
            // 
            // viewbtn
            // 
            this.viewbtn.Location = new System.Drawing.Point(563, 112);
            this.viewbtn.Name = "viewbtn";
            this.viewbtn.Size = new System.Drawing.Size(130, 23);
            this.viewbtn.TabIndex = 10;
            this.viewbtn.Text = "View Dir";
            this.viewbtn.UseVisualStyleBackColor = true;
            this.viewbtn.Click += new System.EventHandler(this.viewbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(503, 196);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // vertext
            // 
            this.vertext.AutoSize = true;
            this.vertext.BackColor = System.Drawing.Color.Transparent;
            this.vertext.Location = new System.Drawing.Point(630, 396);
            this.vertext.Name = "vertext";
            this.vertext.Size = new System.Drawing.Size(108, 13);
            this.vertext.TabIndex = 12;
            this.vertext.Text = "Palm Manager v0.0.0";
            // 
            // dirshow
            // 
            this.dirshow.DefaultExt = "exe";
            this.dirshow.Filter = "Gorilla Tag EXE (Gorilla Tag*.exe)|Gorilla Tag.exe";
            // 
            // diropen
            // 
            this.diropen.Location = new System.Drawing.Point(764, 170);
            this.diropen.Name = "diropen";
            this.diropen.Size = new System.Drawing.Size(24, 20);
            this.diropen.TabIndex = 13;
            this.diropen.Text = "...";
            this.diropen.UseVisualStyleBackColor = true;
            this.diropen.Click += new System.EventHandler(this.diropen_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.diropen);
            this.Controls.Add(this.vertext);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.viewbtn);
            this.Controls.Add(this.setcustomdirbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.currentdirused);
            this.Controls.Add(this.customdir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.applist);
            this.Controls.Add(this.sourcebtn);
            this.Controls.Add(this.addonlist);
            this.Controls.Add(this.installbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Palm Manager";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button installbtn;
        private System.Windows.Forms.CheckedListBox addonlist;
        private System.Windows.Forms.Button sourcebtn;
        private System.Windows.Forms.ComboBox applist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox customdir;
        private System.Windows.Forms.TextBox currentdirused;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button setcustomdirbtn;
        private System.Windows.Forms.Button viewbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label vertext;
        private System.Windows.Forms.OpenFileDialog dirshow;
        private System.Windows.Forms.Button diropen;
    }
}