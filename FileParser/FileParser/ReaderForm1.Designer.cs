namespace FileReadParser
{
    partial class FileReader
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
            this.open_btn = new System.Windows.Forms.Button();
            this.file_stats_gb = new System.Windows.Forms.GroupBox();
            this.stats_lbl = new System.Windows.Forms.Label();
            this.file_stats_gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // open_btn
            // 
            this.open_btn.Location = new System.Drawing.Point(119, 161);
            this.open_btn.Name = "open_btn";
            this.open_btn.Size = new System.Drawing.Size(143, 23);
            this.open_btn.TabIndex = 0;
            this.open_btn.Text = "Open File";
            this.open_btn.UseVisualStyleBackColor = true;
            this.open_btn.Click += new System.EventHandler(this.open_btn_Click);
            // 
            // file_stats_gb
            // 
            this.file_stats_gb.Controls.Add(this.stats_lbl);
            this.file_stats_gb.Location = new System.Drawing.Point(12, 12);
            this.file_stats_gb.Name = "file_stats_gb";
            this.file_stats_gb.Size = new System.Drawing.Size(346, 139);
            this.file_stats_gb.TabIndex = 1;
            this.file_stats_gb.TabStop = false;
            this.file_stats_gb.Text = "File Stats";
            // 
            // stats_lbl
            // 
            this.stats_lbl.AutoSize = true;
            this.stats_lbl.Location = new System.Drawing.Point(17, 28);
            this.stats_lbl.Name = "stats_lbl";
            this.stats_lbl.Size = new System.Drawing.Size(0, 13);
            this.stats_lbl.TabIndex = 0;
            // 
            // FileReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 196);
            this.Controls.Add(this.file_stats_gb);
            this.Controls.Add(this.open_btn);
            this.Name = "FileReader";
            this.Text = "File Parser";
            this.file_stats_gb.ResumeLayout(false);
            this.file_stats_gb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button open_btn;
        private System.Windows.Forms.GroupBox file_stats_gb;
        private System.Windows.Forms.Label stats_lbl;
    }
}

