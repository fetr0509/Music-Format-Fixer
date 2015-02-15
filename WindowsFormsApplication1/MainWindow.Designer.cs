namespace MusicFormatFixer
{
    partial class MusicFormatFixer
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
            this.B_PickFolder = new System.Windows.Forms.Button();
            this.TB_FolderPath = new System.Windows.Forms.TextBox();
            this.B_Start = new System.Windows.Forms.Button();
            this.RB_Style1 = new System.Windows.Forms.RadioButton();
            this.RB_Style2 = new System.Windows.Forms.RadioButton();
            this.L_ChooseType = new System.Windows.Forms.Label();
            this.PB_PercentDone = new System.Windows.Forms.ProgressBar();
            this.L_Percent = new System.Windows.Forms.Label();
            this.B_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // B_PickFolder
            // 
            this.B_PickFolder.Location = new System.Drawing.Point(389, 12);
            this.B_PickFolder.Name = "B_PickFolder";
            this.B_PickFolder.Size = new System.Drawing.Size(100, 22);
            this.B_PickFolder.TabIndex = 0;
            this.B_PickFolder.Text = "Choose Folder";
            this.B_PickFolder.UseVisualStyleBackColor = true;
            this.B_PickFolder.Click += new System.EventHandler(this.B_PickFolder_Click);
            // 
            // TB_FolderPath
            // 
            this.TB_FolderPath.Location = new System.Drawing.Point(12, 12);
            this.TB_FolderPath.Name = "TB_FolderPath";
            this.TB_FolderPath.Size = new System.Drawing.Size(371, 20);
            this.TB_FolderPath.TabIndex = 1;
            this.TB_FolderPath.WordWrap = false;
            // 
            // B_Start
            // 
            this.B_Start.Location = new System.Drawing.Point(389, 41);
            this.B_Start.Name = "B_Start";
            this.B_Start.Size = new System.Drawing.Size(100, 23);
            this.B_Start.TabIndex = 2;
            this.B_Start.Text = "Start";
            this.B_Start.UseVisualStyleBackColor = true;
            this.B_Start.Click += new System.EventHandler(this.B_Start_Click);
            // 
            // RB_Style1
            // 
            this.RB_Style1.AutoSize = true;
            this.RB_Style1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Style1.Location = new System.Drawing.Point(125, 38);
            this.RB_Style1.Name = "RB_Style1";
            this.RB_Style1.Size = new System.Drawing.Size(126, 20);
            this.RB_Style1.TabIndex = 3;
            this.RB_Style1.TabStop = true;
            this.RB_Style1.Text = "Artist - Song Title";
            this.RB_Style1.UseVisualStyleBackColor = true;
            // 
            // RB_Style2
            // 
            this.RB_Style2.AutoSize = true;
            this.RB_Style2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Style2.Location = new System.Drawing.Point(257, 38);
            this.RB_Style2.Name = "RB_Style2";
            this.RB_Style2.Size = new System.Drawing.Size(126, 20);
            this.RB_Style2.TabIndex = 4;
            this.RB_Style2.TabStop = true;
            this.RB_Style2.Text = "Song Title - Artist";
            this.RB_Style2.UseVisualStyleBackColor = true;
            // 
            // L_ChooseType
            // 
            this.L_ChooseType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_ChooseType.Location = new System.Drawing.Point(10, 37);
            this.L_ChooseType.Name = "L_ChooseType";
            this.L_ChooseType.Size = new System.Drawing.Size(110, 20);
            this.L_ChooseType.TabIndex = 5;
            this.L_ChooseType.Text = "Choose Format:";
            this.L_ChooseType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PB_PercentDone
            // 
            this.PB_PercentDone.Location = new System.Drawing.Point(13, 72);
            this.PB_PercentDone.Name = "PB_PercentDone";
            this.PB_PercentDone.Size = new System.Drawing.Size(302, 23);
            this.PB_PercentDone.TabIndex = 6;
            // 
            // L_Percent
            // 
            this.L_Percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Percent.Location = new System.Drawing.Point(321, 72);
            this.L_Percent.Name = "L_Percent";
            this.L_Percent.Size = new System.Drawing.Size(62, 23);
            this.L_Percent.TabIndex = 7;
            this.L_Percent.Text = "100%";
            this.L_Percent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // B_Close
            // 
            this.B_Close.Location = new System.Drawing.Point(389, 72);
            this.B_Close.Name = "B_Close";
            this.B_Close.Size = new System.Drawing.Size(100, 23);
            this.B_Close.TabIndex = 8;
            this.B_Close.Text = "Close";
            this.B_Close.UseVisualStyleBackColor = true;
            this.B_Close.Click += new System.EventHandler(this.B_Close_Click);
            // 
            // MusicFormatFixer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 107);
            this.Controls.Add(this.B_Close);
            this.Controls.Add(this.L_Percent);
            this.Controls.Add(this.PB_PercentDone);
            this.Controls.Add(this.L_ChooseType);
            this.Controls.Add(this.RB_Style2);
            this.Controls.Add(this.RB_Style1);
            this.Controls.Add(this.B_Start);
            this.Controls.Add(this.TB_FolderPath);
            this.Controls.Add(this.B_PickFolder);
            this.Name = "MusicFormatFixer";
            this.Text = "Music Format Fixer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_PickFolder;
        private System.Windows.Forms.TextBox TB_FolderPath;
        private System.Windows.Forms.Button B_Start;
        private System.Windows.Forms.RadioButton RB_Style1;
        private System.Windows.Forms.RadioButton RB_Style2;
        private System.Windows.Forms.Label L_ChooseType;
        private System.Windows.Forms.ProgressBar PB_PercentDone;
        private System.Windows.Forms.Label L_Percent;
        private System.Windows.Forms.Button B_Close;
    }
}

