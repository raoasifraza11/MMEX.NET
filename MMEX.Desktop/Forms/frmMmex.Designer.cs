namespace MMEX.Desktop.Forms
{
    partial class frmMmex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMmex));
            this.btnLastDb = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnWebsite = new System.Windows.Forms.Button();
            this.btnNewDb = new System.Windows.Forms.Button();
            this.btnOpenDb = new System.Windows.Forms.Button();
            this.btnDoc = new System.Windows.Forms.Button();
            this.cbShowNextTime = new System.Windows.Forms.CheckBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLastDb
            // 
            this.btnLastDb.Location = new System.Drawing.Point(116, 205);
            this.btnLastDb.Name = "btnLastDb";
            this.btnLastDb.Size = new System.Drawing.Size(203, 25);
            this.btnLastDb.TabIndex = 0;
            this.btnLastDb.Text = "Open last opened database";
            this.btnLastDb.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(409, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnWebsite
            // 
            this.btnWebsite.Location = new System.Drawing.Point(116, 389);
            this.btnWebsite.Name = "btnWebsite";
            this.btnWebsite.Size = new System.Drawing.Size(203, 25);
            this.btnWebsite.TabIndex = 2;
            this.btnWebsite.Text = "Visit website for more information";
            this.btnWebsite.UseVisualStyleBackColor = true;
            this.btnWebsite.Click += new System.EventHandler(this.btnWebsite_Click);
            // 
            // btnNewDb
            // 
            this.btnNewDb.Location = new System.Drawing.Point(116, 251);
            this.btnNewDb.Name = "btnNewDb";
            this.btnNewDb.Size = new System.Drawing.Size(203, 25);
            this.btnNewDb.TabIndex = 3;
            this.btnNewDb.Text = "Create a new database";
            this.btnNewDb.UseVisualStyleBackColor = true;
            // 
            // btnOpenDb
            // 
            this.btnOpenDb.Location = new System.Drawing.Point(116, 297);
            this.btnOpenDb.Name = "btnOpenDb";
            this.btnOpenDb.Size = new System.Drawing.Size(203, 25);
            this.btnOpenDb.TabIndex = 4;
            this.btnOpenDb.Text = "Open existing database";
            this.btnOpenDb.UseVisualStyleBackColor = true;
            // 
            // btnDoc
            // 
            this.btnDoc.Location = new System.Drawing.Point(116, 343);
            this.btnDoc.Name = "btnDoc";
            this.btnDoc.Size = new System.Drawing.Size(203, 25);
            this.btnDoc.TabIndex = 5;
            this.btnDoc.Text = "Read documentation";
            this.btnDoc.UseVisualStyleBackColor = true;
            // 
            // cbShowNextTime
            // 
            this.cbShowNextTime.AutoSize = true;
            this.cbShowNextTime.Location = new System.Drawing.Point(12, 480);
            this.cbShowNextTime.Name = "cbShowNextTime";
            this.cbShowNextTime.Size = new System.Drawing.Size(286, 17);
            this.cbShowNextTime.TabIndex = 6;
            this.cbShowNextTime.Text = "Show this windows next time Money Manager EX starts";
            this.cbShowNextTime.UseVisualStyleBackColor = true;
            this.cbShowNextTime.CheckedChanged += new System.EventHandler(this.cbShowNextTime_CheckedChanged);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(347, 476);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 25);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMmex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 511);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cbShowNextTime);
            this.Controls.Add(this.btnDoc);
            this.Controls.Add(this.btnOpenDb);
            this.Controls.Add(this.btnNewDb);
            this.Controls.Add(this.btnWebsite);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLastDb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMmex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Money Manager EX";
            this.Load += new System.EventHandler(this.frmMmex_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLastDb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnWebsite;
        private System.Windows.Forms.Button btnNewDb;
        private System.Windows.Forms.Button btnOpenDb;
        private System.Windows.Forms.Button btnDoc;
        private System.Windows.Forms.CheckBox cbShowNextTime;
        private System.Windows.Forms.Button btnExit;
    }
}